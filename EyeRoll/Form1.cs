using EyeRoll.Classes;
using EyeRoll.Classes.Fields_Inherit;
using EyeRoll.Classes.Figures;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using static EyeRoll.Classes.PathTypes;

namespace EyeRoll
{
    public partial class MainWindow : Form
    {
        private int simulationTime = 0;
        private Path PathFigure;
        private string mm_width, mm_height;
        private decimal delay;
        Point GetCenter() => new Point(Width / 2 - 10, Height / 2 - 20);

        // init

        public MainWindow() => InitializeComponent();
        private void MainWindow_Load(object sender, EventArgs e)
        {
            Enum.GetValues(typeof(PathTypes)).Cast<PathTypes>().ToList().ForEach(x => Movement.Items.Add(x));
            Movement.SelectedIndexChanged += (s, args) => InitPath();

            TopMost = true;
            DrawCirclePen();

            void changeSize(TextBox s, EventArgs args)
            {
                var mm = s.Text;
                if (!double.TryParse(mm, out var num))
                {
                    if (s == Width_TextBox)
                    {
                        (s as TextBox).Text = mm_width;
                        return;
                    }
                    if (s == Height_TextBox)
                    {
                        (s as TextBox).Text = mm_height;
                        return;
                    }
                }

                var px = (int)Math.Round(num * 96.0 / 25.4);
                if (s == Width_TextBox)
                {
                    pictureBox1.Width = px;
                    mm_width = mm;
                } else if (s == Height_TextBox)
                {
                    if (Movement.SelectedItem.ToString() == "Square"|| Movement.SelectedItem.ToString() == "Triangle" || Movement.SelectedItem.ToString() == "Line" || Movement.SelectedItem.ToString() == "Diagonal")
                        pictureBox1.Height = 1300;
                    else pictureBox1.Height = (int)(pictureBox1.Width/1.6);
                    mm_height = mm;
                }

                PathFigure.init_position = GetCenter();
                pictureBox1.Location = new Point(GetCenter().X - pictureBox1.Width / 2, GetCenter().Y - pictureBox1.Height / 2);
            };

            pictureBox1.Location = new Point(GetCenter().X - pictureBox1.Width / 2, GetCenter().Y - pictureBox1.Height / 2);
            Ball.Location = GetCenter();


            Width_TextBox.Text = "247";  //406
            Height_TextBox.Text = "180"; //211

            ApplyButton.Click += (s, args) =>
            {
                Width_TextBox.Text = CalcDisplayInMM((double)DistanceUpDown.Value, (double)AngleViewDown.Value / 2).ToString();
                changeSize(Width_TextBox, args);
                double.TryParse(Width_TextBox.Text, out var height);
                Height_TextBox.Text = ((int)(height / 1.6)).ToString();
                DrawCirclePen();
                changeSize(Height_TextBox, args);
                InitPath();
            };

            Movement.SelectedItem = Circle;
        }

        // simulation

        private void StartSimulation()
        {
            PathFigure.Drop();
            UpdateTimer.Enabled = true;
            SecTimer.Enabled = true;
            DrawCirclePen();
            UserUpDownTimer.Enabled = false;
        }
        private void StopSimulation()
        {
            UpdateTimer.Enabled = false;
            SecTimer.Enabled = false;
            simulationTime = 0;
            UserUpDownTimer.Enabled = true;
        }

        readonly Random rnd = new Random();
        private void InitPath()
        {
            var center = GetCenter();
            WhichFigureShouldDraw(Movement.SelectedItem as PathTypes?);

            PathFigure.init_position = center;
            Direction.Enabled = PathFigure is IDirectionPath;
            MoveType.Enabled = PathFigure is ISmoothingPath;
            pictureBox1.Enabled = PathFigure is ILocationBox;
            Ball.Enabled = Ball is IBallCoordinates;

            if (PathFigure is IDirectionPath path_)
            {
                path_.Direction = Direction.Text;
                path_.Width = pictureBox1.Width;
                path_.Height = pictureBox1.Height;
            }

            if (PathFigure is ILocationBox location_)
            {
                location_.LocationX = pictureBox1.Location.X;
                location_.LocationY = pictureBox1.Location.Y;
            }
            if (Ball is IBallCoordinates ballCoordinates_)
            {
                ballCoordinates_.Top = Ball.Top;
                ballCoordinates_.Left = Ball.Left;
            }
            if (PathFigure is ISmoothingPath movetype_)
            {
                movetype_.Type = MoveType.SelectedItem.ToString();
            }
            PathFigure.Drop();
        }

        // timers tick

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (PathFigure is ISmoothingPath path)
            {
                switch (MoveType.Text)
                {
                    case "smooth":
                        if (Movement.SelectedItem.ToString() == "Square" || Movement.SelectedItem.ToString() == "Triangle" || Movement.SelectedItem.ToString() == "Line" || Movement.SelectedItem.ToString() == "Diagonal")
                            path.Smoothing = 0.0001f;
                            else path.Smoothing = 0.0015f;
                        UpdateTimer.Interval = 20;
                        break;
                    case "step":
                        path.Smoothing = 0.05f;
                        delay = Step_delay.Value * 25;
                        UpdateTimer.Interval = (int)delay;
                        break;
                }
            }
            if (PathFigure is IDirectionPath path_)
            {
                path_.Direction = Direction.Text;
                path_.Width = pictureBox1.Width;
                path_.Height = pictureBox1.Height;
            }

            if (!double.TryParse(Speed.Text, out double speed)) speed = 1;
            else if (speed < 1) speed = 1;
            else if (speed > 130) speed = 130;
            Speed.Text = speed.ToString();

            if (Movement.SelectedItem.ToString() == "Square" || Movement.SelectedItem.ToString() == "Triangle" || Movement.SelectedItem.ToString() == "Line" || Movement.SelectedItem.ToString() == "Diagonal")
                Ball.Location = PathFigure.Update(speed * (double)AngleViewDown.Value * 0.026);
                else
                    Ball.Location = PathFigure.Update(speed);
        }
        private void SecTimer_Tick(object sender, EventArgs e)
        {
            Timer.Text = "Time: " + (++simulationTime).ToString();
            if (simulationTime >= int.Parse(UserUpDownTimer.Text)) StopSimulation();
        }

        // render

        readonly Color CurrentColor = Color.FromArgb(204, 0, 0);
        private void DrawCirclePen()
        {

            /*            if (!double.TryParse(Size.Text, out double size))
                        {
                            Size.Text = (Ball.Size.Height / 5).ToString();
                            return;
                        }
                        if (size <= 0 || size > 10)
                        {
                            Size.Text = (Ball.Size.Height / 5).ToString();
                            return;
                        }*/

            double size = (double)Size.Value;
            int sizeOFBall = CalcSizeOfBall((double)DistanceUpDown.Value, size);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, sizeOFBall, sizeOFBall);
            Region rgn = new Region(path);
            Ball.Region = rgn;
            Ball.BackColor = CurrentColor;

            Ball.Size = new Size((int)(size * 100) * 5, (int)(size * 100) * 5);
        }


        // click events & design

        private void Size_SelectedItemChanged(object sender, EventArgs e) => DrawCirclePen();
        private void Start_Click(object sender, EventArgs e) => StartSimulation();
        private void StopButton_Click(object sender, EventArgs e) => StopSimulation();

        private void VisibleButton_Click(object sender, EventArgs e) => Tools.Visible = !Tools.Visible;
        private void ForegroundColorButtonClick(object sender, EventArgs e) => Ball.BackColor = (sender as Button).BackColor;

        private void TypeOfMovementChanged(object sender, EventArgs e)
        {
            var temp = (sender as ComboBox);
            switch (temp.Text)
            {
                case "smooth":
                    label3.Text = "Speed of movement";
                    Step_delay.Visible = false;
                    Speed.Visible = true;
                    break;
                case "step":
                    label3.Text = "Step delay, seconds";
                    Step_delay.Visible = true;
                    Speed.Visible = false;
                    break;
            }
        }

        private void IsTypeChanged(object sender, EventArgs e)
        {
            var temp = Movement.SelectedItem as PathTypes?;
            label7.Visible = true;
            Direction.Visible = true;
            if (temp == PathTypes.Line)
            {
                label7.Text = "Line direction";
                Direction.Items.Clear();
                
                if (!Direction.Items.Contains("Horizontal")) Direction.Items.Add("Horizontal");
                if (!Direction.Items.Contains("Vertical")) Direction.Items.Add("Vertical");
            }
            else if (temp == PathTypes.Hopping_dot || temp == PathTypes.Ping_pong)
            {
                label7.Visible = false;
                Direction.Visible = false;
            }
            else
            {
                label7.Text = "Line direction";
                Direction.Items.Clear();

                if (!Direction.Items.Contains("Standart")) Direction.Items.Add("Standart");
                if (!Direction.Items.Contains("Inverted")) Direction.Items.Add("Inverted");
            }
            Direction.SelectedItem = Direction.Items[0];
            if (temp == PathTypes.Hopping_dot)
            {
                MoveType.Text = "step";
                MoveType.Items.Remove("smooth");
            }
            else if (!MoveType.Items.Contains("smooth"))
            {
                MoveType.Items.Add("smooth");
                MoveType.SelectedItem = "smooth";
            }
        }

        private void BackgroundColorButtonClick(object sender, EventArgs e)
        {
            BackColor = (sender as Button).BackColor;
            Tools.BackColor = (sender as Button).BackColor;
        }

        private void WhichFigureShouldDraw(PathTypes? val) {
            switch (val)
            {
                case Eight:
                    PathFigure = new PathEight();
                    break;
                case Circle:
                    PathFigure = new PathCircle();
                    break;
                case Infinity:
                    PathFigure = new PathInfinity();
                    break;
                case Ellipse:
                    PathFigure = new PathEllipse();
                    break;
                case Triangle:
                    PathFigure = new PathTriangle();
                    break;
                case Square:
                    PathFigure = new PathSquare();
                    break;
                case Hopping_dot:
                    PathFigure = new PathHoppingDot();
                    break;
                case Line:
                    PathFigure = new PathLine();
                    break;
                case Diagonal:
                    PathFigure = new PathDiagonal();
                    break;
                case Ping_pong:
                    PathFigure = new PathPing_pong();
                    break;
                case PathTypes.Random:
                    var randomFigure = Movement.Items[rnd.Next(0, Movement.Items.Count - 1)];
                        for (int i = 0; i < 5; i++)
                        {
                            WhichFigureShouldDraw(randomFigure as PathTypes?);
                        }
                    break;
                default:
                    InitPath();
                    return;
            }

        }

        private int CalcDisplayInMM(double distance, double halfOfDegrees)
        {
            double radians = halfOfDegrees * (Math.PI / 180);
            double sizeOfDisplay = (Math.Tan(radians) * distance) * 2;
            int valueInMM = (int)(sizeOfDisplay * 1000);
            return valueInMM;
        }

        private void TypeOfBallChanged(object sender, EventArgs e)
        {
            var selected = BallTypeMenu.SelectedItem.ToString();
            if (selected == "Circle")
            {
                Ball.Image = Properties.Resources.RedCircle;
            }
            else if (selected == "Square")
            {
                Ball.Image = Properties.Resources.RedSquare;
            }
            else if (selected == "Star")
            {
                Ball.Image = Properties.Resources.RedStar;
            }
            else if (selected == "Triangle")
            {
                Ball.Image = Properties.Resources.RedTriangle;
            }
        }

        private int CalcSizeOfBall(double distance, double degrees)
        {
            double radians = degrees * (Math.PI / 180);
            double sizeOfBall = Math.Tan(radians) * distance;
            int valueInMM = (int)(sizeOfBall * 1000 + 1);
            return valueInMM;
        }
    }
}
