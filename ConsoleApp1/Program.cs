using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Books books = new Books("Война и Мир","Лев Н.Толстой",1867,4700);
            //Console.WriteLine($"{books.Info()}");


            Bug bug = new Bug("кузнечик", 5, "бабочки", "луга");
            //Console.WriteLine($"{bug.Info()}");


            Journal journal = new Journal("Приднестровская", 456, "30.11.23");
            Console.WriteLine(journal.Info());

            Console.Read();

        }
    }
}
