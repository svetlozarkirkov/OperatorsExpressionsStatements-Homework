using System;

namespace ExtractBit3
{
    class ExtractBit3
    {
        static void Main()
        {
            Console.Write("n = ");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("n in binary: {0}",Convert.ToString(n,2).PadLeft(32,'0'));
            uint mask = 1 << 3;
            uint result = n & mask;
            Console.WriteLine("Bit #3 = {0}",result>>3);
        }
    }
}
