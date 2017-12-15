using System;

namespace Exceptions
{
    public static class Base
    {
        public static int Fibonacci(int n)
        {
            if (n < 0)
            {
                throw new NotImplementedException("N must be positive");
            }
            else
            {
                int a = 0;
                int b = 1;
                int c = 0;

                if (n == 1 || n == 2)
                    return 1;
                
                for (int i = 1; i < n; i++ )
                {
                    c = a + b;
                    a = b;
                    b = c;
                }

                return c;
            }
        }

        public static float DegToRad(float angle)
        {
            if (angle < -180 || angle > 180)
            {     
                throw new NotImplementedException("The angle muste be between minus 180 and 180");
            }
            
            return angle * (float)Math.PI / 180;
        }
        
        public static float RadToDeg(float angle)
        {
            if (angle < -(float)Math.PI || angle > (float)Math.PI)
            {     
                throw new NotImplementedException("The angle muste be between minus pi and pi");
            }
            
            return angle / ((float)Math.PI / 180);
        }
        
        public static float Pow(float n, int p)
        {
            if (p <= 0)
            {
                throw new NotImplementedException("The exponent has to be positive");
            }
            else
            {
                float tmp = (float)1.0;

                for (int i = 0; i < p; i++)
                {
                    tmp *= n;
                }

                return tmp;
            }
        }
    }
}