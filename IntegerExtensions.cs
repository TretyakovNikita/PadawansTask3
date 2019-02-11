using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            return b == 0 ? a : Gcd(b, a % b);
        }
    }
}
