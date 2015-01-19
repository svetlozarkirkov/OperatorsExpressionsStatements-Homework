using System;

namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("p = ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("n in binary: ");
            Console.WriteLine(Convert.ToString(n,2).PadLeft(16,'0'));
            int mask = 1 << p;
            int result = n & mask;
            Console.WriteLine(result>>p==1?"Bit @ p = 1":"Bit @ p = 0");
        }
    }
}
