using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException();
            }
            a = Math.Abs(a);
            b = Math.Abs(b);
            return GcdInner(a, b);
        }
        private static int GcdInner(int a, int b)
        {
            return b == 0 ? a : Gcd(b, a % b);
        }
    }
}

