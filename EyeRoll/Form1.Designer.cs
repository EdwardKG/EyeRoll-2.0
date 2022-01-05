
namespace EyeRoll
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.VisibleButton = new System.Windows.Forms.Button();
            this.Tools = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.BallTypeMenu = new System.Windows.Forms.ComboBox();
            this.BallType = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.NumericUpDown();
            this.AngleVIew = new System.Windows.Forms.Label();
            this.AngleViewDown = new System.Windows.Forms.NumericUpDown();
            this.Speed = new System.Windows.Forms.NumericUpDown();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.DistanceUpDown = new System.Windows.Forms.NumericUpDown();
            this.Distance = new System.Windows.Forms.Label();
            this.UserUpDownTimer = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.Width_TextBox = new System.Windows.Forms.TextBox();
            this.Height_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Direction = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MoveType = new System.Windows.Forms.ComboBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Movement = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackColor1 = new System.Windows.Forms.Button();
            this.BackColor2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RedButton = new System.Windows.Forms.Button();
            this.BlueButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.Step_delay = new System.Windows.Forms.NumericUpDown();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.Timer = new System.Windows.Forms.Label();
            this.SecTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngleViewDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserUpDownTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Step_delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VisibleButton
            // 
            this.VisibleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VisibleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisibleButton.Location = new System.Drawing.Point(939, 11);
            this.VisibleButton.Name = "VisibleButton";
            this.VisibleButton.Size = new System.Drawing.Size(92, 23);
            this.VisibleButton.TabIndex = 0;
            this.VisibleButton.Text = "visible";
            this.VisibleButton.UseVisualStyleBackColor = true;
            this.VisibleButton.Click += new System.EventHandler(this.VisibleButton_Click);
            // 
            // Tools
            // 
            this.Tools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Tools.BackColor = System.Drawing.SystemColors.Control;
            this.Tools.Controls.Add(this.label11);
            this.Tools.Controls.Add(this.BallTypeMenu);
            this.Tools.Controls.Add(this.BallType);
            this.Tools.Controls.Add(this.Size);
            this.Tools.Controls.Add(this.AngleVIew);
            this.Tools.Controls.Add(this.AngleViewDown);
            this.Tools.Controls.Add(this.Speed);
            this.Tools.Controls.Add(this.ApplyButton);
            this.Tools.Controls.Add(this.DistanceUpDown);
            this.Tools.Controls.Add(this.Distance);
            this.Tools.Controls.Add(this.UserUpDownTimer);
            this.Tools.Controls.Add(this.label10);
            this.Tools.Controls.Add(this.Width_TextBox);
            this.Tools.Controls.Add(this.Height_TextBox);
            this.Tools.Controls.Add(this.label8);
            this.Tools.Controls.Add(this.label7);
            this.Tools.Controls.Add(this.label9);
            this.Tools.Controls.Add(this.Direction);
            this.Tools.Controls.Add(this.label6);
            this.Tools.Controls.Add(this.MoveType);
            this.Tools.Controls.Add(this.StopButton);
            this.Tools.Controls.Add(this.Start);
            this.Tools.Controls.Add(this.label5);
            this.Tools.Controls.Add(this.label4);
            this.Tools.Controls.Add(this.label3);
            this.Tools.Controls.Add(this.Movement);
            this.Tools.Controls.Add(this.label2);
            this.Tools.Controls.Add(this.label1);
            this.Tools.Controls.Add(this.BackColor1);
            this.Tools.Controls.Add(this.BackColor2);
            this.Tools.Controls.Add(this.button4);
            this.Tools.Controls.Add(this.RedButton);
            this.Tools.Controls.Add(this.BlueButton);
            this.Tools.Controls.Add(this.GreenButton);
            this.Tools.Controls.Add(this.Step_delay);
            this.Tools.Location = new System.Drawing.Point(939, 40);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(216, 641);
            this.Tools.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(2, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 36);
            this.label11.TabIndex = 35;
            this.label11.Text = "Before starting the programm \r\npress \"Apply\" button";
            // 
            // BallTypeMenu
            // 
            this.BallTypeMenu.FormattingEnabled = true;
            this.BallTypeMenu.Items.AddRange(new object[] {
            "Circle",
            "Star",
            "Square",
            "Triangle"});
            this.BallTypeMenu.Location = new System.Drawing.Point(89, 259);
            this.BallTypeMenu.Name = "BallTypeMenu";
            this.BallTypeMenu.Size = new System.Drawing.Size(108, 21);
            this.BallTypeMenu.TabIndex = 34;
            this.BallTypeMenu.Text = "Circle";
            this.BallTypeMenu.SelectedValueChanged += new System.EventHandler(this.TypeOfBallChanged);
            // 
            // BallType
            // 
            this.BallType.AutoSize = true;
            this.BallType.Location = new System.Drawing.Point(3, 262);
            this.BallType.Name = "BallType";
            this.BallType.Size = new System.Drawing.Size(47, 13);
            this.BallType.TabIndex = 33;
            this.BallType.Text = "Ball type";
            // 
            // Size
            // 
            this.Size.DecimalPlaces = 1;
            this.Size.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Size.Location = new System.Drawing.Point(140, 110);
            this.Size.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Size.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Size.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(57, 20);
            this.Size.TabIndex = 32;
            this.Size.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.Size.ValueChanged += new System.EventHandler(this.Size_SelectedItemChanged);
            // 
            // AngleVIew
            // 
            this.AngleVIew.AutoSize = true;
            this.AngleVIew.Location = new System.Drawing.Point(4, 156);
            this.AngleVIew.Name = "AngleVIew";
            this.AngleVIew.Size = new System.Drawing.Size(58, 13);
            this.AngleVIew.TabIndex = 31;
            this.AngleVIew.Text = "Angle, deg";
            // 
            // AngleViewDown
            // 
            this.AngleViewDown.Location = new System.Drawing.Point(140, 154);
            this.AngleViewDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AngleViewDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.AngleViewDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AngleViewDown.Name = "AngleViewDown";
            this.AngleViewDown.Size = new System.Drawing.Size(58, 20);
            this.AngleViewDown.TabIndex = 30;
            this.AngleViewDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(140, 84);
            this.Speed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Speed.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.Speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(57, 20);
            this.Speed.TabIndex = 29;
            this.Speed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(141, 286);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(56, 48);
            this.ApplyButton.TabIndex = 28;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            // 
            // DistanceUpDown
            // 
            this.DistanceUpDown.DecimalPlaces = 1;
            this.DistanceUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.DistanceUpDown.Location = new System.Drawing.Point(140, 179);
            this.DistanceUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DistanceUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DistanceUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            this.DistanceUpDown.Name = "DistanceUpDown";
            this.DistanceUpDown.Size = new System.Drawing.Size(57, 20);
            this.DistanceUpDown.TabIndex = 27;
            this.DistanceUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(3, 183);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(63, 13);
            this.Distance.TabIndex = 26;
            this.Distance.Text = "Distance, m";
            // 
            // UserUpDownTimer
            // 
            this.UserUpDownTimer.Location = new System.Drawing.Point(140, 132);
            this.UserUpDownTimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserUpDownTimer.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.UserUpDownTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UserUpDownTimer.Name = "UserUpDownTimer";
            this.UserUpDownTimer.Size = new System.Drawing.Size(57, 20);
            this.UserUpDownTimer.TabIndex = 22;
            this.UserUpDownTimer.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Type";
            // 
            // Width_TextBox
            // 
            this.Width_TextBox.Enabled = false;
            this.Width_TextBox.Location = new System.Drawing.Point(89, 286);
            this.Width_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Width_TextBox.Name = "Width_TextBox";
            this.Width_TextBox.Size = new System.Drawing.Size(38, 20);
            this.Width_TextBox.TabIndex = 7;
            // 
            // Height_TextBox
            // 
            this.Height_TextBox.Enabled = false;
            this.Height_TextBox.Location = new System.Drawing.Point(89, 316);
            this.Height_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Height_TextBox.Name = "Height_TextBox";
            this.Height_TextBox.Size = new System.Drawing.Size(38, 20);
            this.Height_TextBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 289);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Horizontal, mm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Line direction";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 319);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Vertical, mm";
            // 
            // Direction
            // 
            this.Direction.FormattingEnabled = true;
            this.Direction.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.Direction.Location = new System.Drawing.Point(90, 233);
            this.Direction.Name = "Direction";
            this.Direction.Size = new System.Drawing.Size(108, 21);
            this.Direction.TabIndex = 19;
            this.Direction.Text = "Horizontal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Movement type";
            // 
            // MoveType
            // 
            this.MoveType.FormattingEnabled = true;
            this.MoveType.Items.AddRange(new object[] {
            "smooth",
            "step"});
            this.MoveType.Location = new System.Drawing.Point(89, 208);
            this.MoveType.Name = "MoveType";
            this.MoveType.Size = new System.Drawing.Size(108, 21);
            this.MoveType.TabIndex = 17;
            this.MoveType.Text = "smooth";
            this.MoveType.TextChanged += new System.EventHandler(this.TypeOfMovementChanged);
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopButton.Location = new System.Drawing.Point(5, 574);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(88, 23);
            this.StopButton.TabIndex = 16;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Location = new System.Drawing.Point(116, 574);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(97, 23);
            this.Start.TabIndex = 15;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Timer, sec";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Circle size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Speed of movement";
            // 
            // Movement
            // 
            this.Movement.FormattingEnabled = true;
            this.Movement.Location = new System.Drawing.Point(89, 55);
            this.Movement.Name = "Movement";
            this.Movement.Size = new System.Drawing.Size(108, 21);
            this.Movement.TabIndex = 8;
            this.Movement.Text = "Circle";
            this.Movement.TextChanged += new System.EventHandler(this.IsTypeChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Background color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Circle color";
            // 
            // BackColor1
            // 
            this.BackColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackColor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BackColor1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackColor1.Location = new System.Drawing.Point(142, 29);
            this.BackColor1.Name = "BackColor1";
            this.BackColor1.Size = new System.Drawing.Size(20, 20);
            this.BackColor1.TabIndex = 5;
            this.BackColor1.UseVisualStyleBackColor = false;
            this.BackColor1.Click += new System.EventHandler(this.BackgroundColorButtonClick);
            // 
            // BackColor2
            // 
            this.BackColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackColor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BackColor2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackColor2.Location = new System.Drawing.Point(167, 29);
            this.BackColor2.Name = "BackColor2";
            this.BackColor2.Size = new System.Drawing.Size(20, 20);
            this.BackColor2.TabIndex = 4;
            this.BackColor2.UseVisualStyleBackColor = false;
            this.BackColor2.Click += new System.EventHandler(this.BackgroundColorButtonClick);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(193, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 20);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.BackgroundColorButtonClick);
            // 
            // RedButton
            // 
            this.RedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RedButton.Location = new System.Drawing.Point(142, 3);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(20, 20);
            this.RedButton.TabIndex = 2;
            this.RedButton.UseVisualStyleBackColor = false;
            this.RedButton.Click += new System.EventHandler(this.ForegroundColorButtonClick);
            // 
            // BlueButton
            // 
            this.BlueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BlueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.BlueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BlueButton.Location = new System.Drawing.Point(167, 3);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(20, 20);
            this.BlueButton.TabIndex = 1;
            this.BlueButton.UseVisualStyleBackColor = false;
            this.BlueButton.Click += new System.EventHandler(this.ForegroundColorButtonClick);
            // 
            // GreenButton
            // 
            this.GreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.GreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GreenButton.Location = new System.Drawing.Point(193, 3);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(20, 20);
            this.GreenButton.TabIndex = 0;
            this.GreenButton.UseVisualStyleBackColor = false;
            this.GreenButton.Click += new System.EventHandler(this.ForegroundColorButtonClick);
            // 
            // Step_delay
            // 
            this.Step_delay.DecimalPlaces = 1;
            this.Step_delay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Step_delay.Location = new System.Drawing.Point(140, 84);
            this.Step_delay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Step_delay.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Step_delay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Step_delay.Name = "Step_delay";
            this.Step_delay.Size = new System.Drawing.Size(57, 20);
            this.Step_delay.TabIndex = 25;
            this.Step_delay.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // Ball
            // 
            this.Ball.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.Image = global::EyeRoll.Properties.Resources.RedTriangle;
            this.Ball.Location = new System.Drawing.Point(332, 225);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(15, 15);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 20;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // Timer
            // 
            this.Timer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Timer.AutoSize = true;
            this.Timer.Location = new System.Drawing.Point(1078, 15);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(30, 13);
            this.Timer.TabIndex = 3;
            this.Timer.Text = "Time";
            // 
            // SecTimer
            // 
            this.SecTimer.Interval = 1000;
            this.SecTimer.Tick += new System.EventHandler(this.SecTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1155, 680);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 681);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.VisibleButton);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Eye roll";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngleViewDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserUpDownTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Step_delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VisibleButton;
        private System.Windows.Forms.Panel Tools;
        private System.Windows.Forms.Button BackColor1;
        private System.Windows.Forms.Button BackColor2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Movement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MoveType;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Timer SecTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Direction;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Width_TextBox;
        private System.Windows.Forms.TextBox Height_TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown UserUpDownTimer;
        private System.Windows.Forms.NumericUpDown Step_delay;
        private System.Windows.Forms.NumericUpDown DistanceUpDown;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.NumericUpDown Speed;
        private System.Windows.Forms.Label AngleVIew;
        private System.Windows.Forms.NumericUpDown AngleViewDown;
        private System.Windows.Forms.NumericUpDown Size;
        private System.Windows.Forms.ComboBox BallTypeMenu;
        private System.Windows.Forms.Label BallType;
        private System.Windows.Forms.Label label11;
    }
}

