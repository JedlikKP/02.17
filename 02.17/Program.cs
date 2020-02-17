using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._17
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] Színek = { ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.Green };
            Console.WriteLine("Addja meg a szöveget:");
            string szöveg = Console.ReadLine();
            Console.WriteLine("Add meg a színét: 1től-3ig");
            int szín = int.Parse(Console.ReadLine())-1;
            Console.WriteLine("Add meg a sort: ");
            int sor = int.Parse(Console.ReadLine());
            Console.WriteLine("add meg az oszlopot: ");
            int oszlop = int.Parse(Console.ReadLine());
            Console.Clear();
            kiirató(szöveg, szín, sor, oszlop, Színek);
            Console.ReadKey();
        }

        private static void kiirató(string szöveg, int szín, int sor, int oszlop, ConsoleColor[] színek)
        {
            Console.ForegroundColor = színek[szín];

            Console.SetCursorPosition(sor, oszlop);

            Console.WriteLine(szöveg);
        }
    }
}
