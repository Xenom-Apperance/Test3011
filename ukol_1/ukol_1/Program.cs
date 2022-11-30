using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte hledaný znak: ");
            char znak = char.Parse(Console.ReadLine());
            Console.Write("Zadejte řetězec: ");
            string s = Console.ReadLine();
            int pocet = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == znak)
                {
                    pocet++;
                }
            }
            Console.Write("Pocet vyskytu hledaneho znaku: ");
            Console.Write(pocet);
            Console.Read();
        }
    }
}
