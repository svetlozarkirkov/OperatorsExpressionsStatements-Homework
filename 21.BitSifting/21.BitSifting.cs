using System;

namespace BitSifting
{
    class BitSifting
    {
        static void Main()
        {
            UInt64 inputNum = UInt64.Parse(Console.ReadLine());
            string inputNumBinary = Convert.ToString((long)inputNum, 2).PadLeft(64, '0');
            int sievesCount = int.Parse(Console.ReadLine());
            UInt64[] sieves = new UInt64[sievesCount];
            string[] sievesBinary = new string[sievesCount];
            int zeroesCount = 0;

            for (int i = 0; i < sievesCount; i++)
            {
                sieves[i] = UInt64.Parse(Console.ReadLine());
                sievesBinary[i] = Convert.ToString((long)sieves[i], 2).PadLeft(64, '0');
            }

            string[] finalNum = new string[64];

            for (int i = 0; i < inputNumBinary.Length; i++)
            {
                if (inputNumBinary[i] == '1')
                {
                    zeroesCount = 0;

                    for (int j = 0; j < sievesBinary.Length; j++)
                    {
                        if (sievesBinary[j][i] == '0')
                        {
                            zeroesCount++;
                        }
                    }
                    if (zeroesCount == sievesBinary.Length)
                    {
                        finalNum[i] = "1";
                    }
                }
                else
                {
                    finalNum[i] = "0";
                }
            }

            int onesCount = 0;

            for (int i = 0; i < finalNum.Length; i++)
            {
                if (finalNum[i] == "1")
                {
                    onesCount++;
                }
            }

            Console.WriteLine(onesCount);
        }
    }
}