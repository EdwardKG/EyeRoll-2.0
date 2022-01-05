using System.Drawing;
using EyeRoll.Classes.Fields_Inherit;

namespace EyeRoll.Classes.Figures
{
    class PathLine : Path, IDirectionPath, ISmoothingPath
    {
        private int index = 0;
        private double timer = 0;
        public string Direction { get; set; }
        public float Smoothing { get; set; }
        public string Type { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        private int velY, velX;

        public override void Drop()
        {
            index = 0;
            timer = 0;
            velY = 0;
            velX = 0;
        }

        public override Point Update(double speed)
        {
            int startX = 400;
            int startY = 0;
            int res = 1156 / 681;
            int coefX = 1156 / Width;
            int coefY = 681 / Height;
            int lengthOfSide = 200;


            timer += speed;

            if (Direction == "Horizontal")
            {
                startY = 0;
                switch (index)
                {
                    case 0:
                        velX += (int)(4 * speed);
                        break;
                    case 1:
                        velX -= (int)(4 * speed);
                        break;
                }
            }
            else
            {
                startX = 0;
                startY = 400;
                switch (index)
                {
                    case 0:
                        velY += (int)(4 * speed);
                        break;
                    case 1:
                        velY -= (int)(4 * speed);
                        break;
                }
            }

            if (Width / Height < res)
            {
                if (Width > Height)
                {
                    lengthOfSide /= coefY;
                    startX /= coefY;
                    startY /= coefY;

                }
                else if (Height > Width)
                {
                    lengthOfSide /= coefX;
                    startX /= coefX;
                    startY /= coefX;
                }

            }

            //681 1156

            else if (Width / Height > res)
            {
                if (Width > Height)
                {
                    lengthOfSide *= coefY;
                    startX *= coefY;
                    startY *= coefY;
                }
                else if (Height > Width)
                {
                    lengthOfSide *= coefX;
                    startX *= coefX;
                    startY *= coefX;
                }
            }

            if (timer > lengthOfSide)
            {
                timer = 0;
                index = (index + 1) % 2;
            }

            int x = 0;
            int y = 0;

            if (Type == "smooth") { 
                x = velX + init_position.X - startX;
                y = velY + init_position.Y - startY;
                return new Point(x, y);
            } else if (Type == "step") { 
                switch (index)
                {
                    case 0:
                        x = init_position.X - startX;
                        y = init_position.Y - startY;
                        break;
                    case 1:
                        x = init_position.X + startX;
                        y = init_position.Y + startY;
                        break;
                } 
            }
                return new Point(x, y);
        }
    }
}
