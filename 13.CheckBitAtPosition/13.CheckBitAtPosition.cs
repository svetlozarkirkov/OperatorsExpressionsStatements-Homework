using System;

namespace CheckBitAtPosition
{
    class CheckBitAtPosition
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("p = ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("n in binary: {0}",Convert.ToString(n,2).PadLeft(16,'0'));
            int mask = 1 << p;
            bool bitIsOne = (n & mask)>>p==1;
            Console.WriteLine("Bit @ p = 1 --> {0}",bitIsOne);
        }
    }
}
