using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte binarni cislo: ");
            string bin = Console.ReadLine();
            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i] != '1' && bin[i] != '0')
                {
                    Console.WriteLine("Nespravny vstup!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            Console.Write("Pocet bitu: ");
            Console.WriteLine(bin.Length);
            int dec = 0;
            int n = 1;
            for (int i = bin.Length-1; i >= 0; i--)
            {
                dec = (bin[i] - '0') *n + dec;
                n = n * 2;
            }
            Console.Write("Decimalni hodnota: ");
            Console.WriteLine(dec);
            Console.ReadKey();
        }
    }
}
