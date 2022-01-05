using System;
using System.Drawing;
using EyeRoll.Classes.Fields_Inherit;

namespace EyeRoll.Classes.Figures
{

    class PathDiagonal : Path, IDirectionPath, ISmoothingPath
    {
        private int index = 0;
        private double timer = 0;
        public string Direction { get; set; }
        public string Type { get; set; }
        public float Smoothing { get; set; }
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
            int startX = 200;
            int startY = 200;
            int lengthOfSide = 100;
            int res = 1156 / 681;
            int coefX = 1156 / Width;
            int coefY = 681 / Height;

            timer += speed;


            if (Direction == "Standart")
            { 
                if (index == 0)
                {
                    velX += (int)(4 * speed);
                    velY += (int)(4 * speed);
                    
                }
                else if (index == 1)
                {
                    velX -= (int)(4 * speed);
                    velY -= (int)(4 * speed);

                }

            }
            else if (Direction == "Inverted")
            {
                startY = 200;
                startX = -225;
                if (index == 0)
                {
                    velX -= (int)(4 * speed);
                    velY += (int)(4 * speed);
                }
                else if (index == 1)
                {
                    velX += (int)(4 * speed);
                    velY -= (int)(4 * speed);
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

            if (timer > lengthOfSide && index == 1) Drop();
            else if (timer > lengthOfSide && index != 1)
            {
                index++;
                timer = 0;
            }

            int x = 0;
            int y = 0;
            if (Type == "smooth")
            {
                x = velX + init_position.X - startX;
                y = velY + init_position.Y - startY;
                return new Point(x, y);
            }
            else if (Type == "step")
            {
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
