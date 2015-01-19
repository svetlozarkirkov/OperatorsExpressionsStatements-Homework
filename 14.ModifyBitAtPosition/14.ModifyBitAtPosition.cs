using System;

namespace ModifyBitAtPosition
{
    class ModifyBitAtPosition
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("v = ");
            int v = int.Parse(Console.ReadLine());
            Console.Write("p = ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("n in binary: {0}",Convert.ToString(n, 2).PadLeft(16, '0'));
            int mask = 1 << p;
            int bit = (n & mask) >> p;
            Console.WriteLine("bit @ p = {0}",bit);
            if (bit == v)
            {
                Console.WriteLine("result = {0} ({1}) (same)",n,Convert.ToString(n,2).PadLeft(16,'0'));
            }
            else
            {
                if (v == 1)
                {
                    int modifier = 1 << p;
                    int result = modifier ^ n;
                    Console.WriteLine("result = {0} ({1})",result,Convert.ToString(result,2).PadLeft(16,'0'));
                }
                else
                {
                    int modifier = ~(1 << p);
                    int result = modifier & n;
                    Console.WriteLine("result = {0} ({1})", result, Convert.ToString(result, 2).PadLeft(16, '0'));
                }
            }
        }
    }
}
