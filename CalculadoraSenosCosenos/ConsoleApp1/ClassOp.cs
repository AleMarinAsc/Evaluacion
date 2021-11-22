using System;

namespace ConsoleApp1
{
    public class ClassOp
    {
        double x, y, z;

        public ClassOp(double x, double y, double z) 
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double OpcionCosenoLAL() 
        {
            double result = 0;

            if (x == 0 || y == 0 || z == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                double cos = (z * Math.PI) / 180;

                result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) - 2 * x * y * Math.Cos(cos));
            }

            return Math.Round(result, 2);
        }

        public double OpcionCosenoLLL() 
        {
            double result = 0;

            if( x + y <= z || x + z <= y || y + z <= x || x == 0 || y == 0 || z == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            { 
                result = Math.Acos((Math.Pow(y, 2) - Math.Pow(x, 2) - Math.Pow(z, 2)) / (-2 * x * z));

                result = (result * 180) / Math.PI;
            }

            return Math.Round(result, 2);
        }

        public double OpcionSenoAAL() 
        {
            double result = 0;

            if (x == 0 || y == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                result = 180 - x - y;
            }

            return Math.Round(result, 2);
        }

    }
}
