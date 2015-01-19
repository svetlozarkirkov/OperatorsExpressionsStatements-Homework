using System;
using System.Collections.Generic;
using System.Linq;

namespace BitsUp
{
    class BitsUp
    {
        static void Main()
        {
            byte[] n = new byte[int.Parse(Console.ReadLine())];
            int step = int.Parse(Console.ReadLine());
            List<string> collected = new List<string>();

            for (int i = 0; i < n.Length; i++)
            {
                n[i] = byte.Parse(Console.ReadLine());
            }

            foreach (var item in n)
            {
                collected.Add(Convert.ToString(item, 2).PadLeft(8, '0'));
            }

            string finalNumStr = string.Join("", collected.ToArray());
            int[] finalNum = finalNumStr.Select(c => (int)(c - '0')).ToArray();

            for (int k = 1; k < finalNum.Length; k += step)
            {
                if (finalNum[k] == 0)
                {
                    finalNum[k] = 1;
                }
            }

            string finalNumBEE = string.Join("", finalNum.ToArray());
            int nBytes = (int)Math.Ceiling(finalNumBEE.Length / 8m);
            var bytesAsStrings =
                Enumerable.Range(0, nBytes)
                          .Select(i => finalNumBEE.Substring(8 * i, Math.Min(8, finalNumBEE.Length - 8 * i)));

            foreach (var item in bytesAsStrings)
            {
                Console.WriteLine(Convert.ToInt32(item, 2));
            }
        }
    }
}