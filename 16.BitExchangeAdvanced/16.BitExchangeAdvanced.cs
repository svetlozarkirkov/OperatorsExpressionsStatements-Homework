using System;

namespace BitExchangeAdvanced
{
    class BitExchangeAdvanced
    {
        static void Main()
        {
            uint n = 0;
            Console.Write("n = ");
            bool testUint = uint.TryParse(Console.ReadLine(), out n);
            //uint n = uint.Parse(Console.ReadLine());
            if (testUint == false)
            {
                Console.WriteLine("Out of range");
                return;
            }
            Console.Write("p = ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("q = ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            if (p+k > 32 || q+k > 32 || p < 0 || q < 0 || k < 0)
            {
                Console.WriteLine("Out of range");
                return;
            }
            else if (Math.Min(p,q)+k>=Math.Max(p,q))
            {
                Console.WriteLine("Overlapping");
                return;
            }
            else
            {
                string binaryRep = Convert.ToString(n, 2).PadLeft(32, '0');
                Console.WriteLine("n in binary = {0}", binaryRep);
                int[] binaryArray = new int[32];
                for (int i = 0; i < binaryRep.Length; i++)
                {
                    binaryArray[i] = Convert.ToInt32(binaryRep[i].ToString());
                }
                Array.Reverse(binaryArray);
                for (int i = 0; i < k; i++)
                {
                    int temp = binaryArray[p];
                    binaryArray[p] = binaryArray[q];
                    binaryArray[q] = temp;
                    p++;
                    q++;
                }
                Array.Reverse(binaryArray);
                string result = string.Join("", binaryArray);
                Console.WriteLine("result = {0}", Convert.ToUInt32(result, 2));
                Console.WriteLine("result in binary: {0}", result);
            }
        }
    }
}
