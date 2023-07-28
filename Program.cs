using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cümle Yazınız:");
            string word=Console.ReadLine();

            Console.WriteLine("Aradığınız Kelime:");
            string search=Console.ReadLine();
            if (word.Contains(search))
            {
                if (word.StartsWith(search)) Console.WriteLine("Kelime Baştadır");
                else if (word.EndsWith(search)) Console.WriteLine("Kelimeniz Sondadır");
                else Console.WriteLine("Kelime Ortadadır.");
            }
            else Console.WriteLine("Kelime Bulunamadı");
            Console.ReadKey();

        }
    }
}
