using System.Drawing;
using EyeRoll.Classes.Fields_Inherit;

namespace EyeRoll.Classes.Figures
{
    class PathSquare : Path, IDirectionPath, ISmoothingPath
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
            int lengthOfSide = 100; // if to x2 = startPoint of drawing
            int res = 1156 / 681;
            int coefX = 1156 / Width;
            int coefY = 681 / Height;

            timer += speed;
            if (Direction == "Inverted")
            {
                switch (index)
                {
                    case 0:
                        velY += (int)(4 * speed);
                        break;
                    case 1:
                        velX += (int)(4 * speed);
                        break;
                    case 2:
                        velY -= (int)(4 * speed);
                        break;
                    case 3:
                        velX -= (int)(4 * speed);
                        break;
                    
                }
            }
            else
            {
                switch (index)
                {
                    case 0:
                        velX += (int)(4 * speed);
                        break;
                    case 1:
                        velY += (int)(4 * speed);
                        break;
                    case 2:
                        velX -= (int)(4 * speed);
                        break;
                    case 3:
                        velY -= (int)(4 * speed);
                        break;
                }
            }
            

            if (Width / Height < res)
            {
                if (Width > Height)
                    lengthOfSide /= coefY;
                else if (Height > Width)
                    lengthOfSide /= coefX;
            }

            else if (Width / Height > res)
            {
                if (Width > Height)
                    lengthOfSide *= coefY;
                else if (Height > Width)
                    lengthOfSide *= coefX;
            }

            if (timer > lengthOfSide)
            {
                timer = 0;
                index = (index + 1) % 4;
            }



            int x = velX + init_position.X - lengthOfSide * 2;
            int y = velY + init_position.Y - lengthOfSide * 2;

            return new Point(x, y);
        }
    }
}
