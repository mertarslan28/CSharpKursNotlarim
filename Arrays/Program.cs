using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Sleep(int Sleeptime)
        {
            Thread.Sleep(Sleeptime);
        }
        static void Main(string[] args)
        {
            //string[] students = new string[3];
            //students[0] = "Engin";
            //students[1] = "Mert";
            //students[2] = "Beyza";
            //string[] students = new string[3] { "Mert", "Beyza", "Emine" };
            //string[] students2 = { "Mert", "Beyza", "Zümra" };
            //foreach (string student in students)
            //{
            //    Console.WriteLine(student);
            //}
            //foreach (string student in students2)
            //{
            //    Console.WriteLine(student);

            //}

            string[,] regions = new string[5, 3]
            {
                { "İstanbul","İzmit","Kocaeli" },
                { "Ankara","Konya","Kırıkkale" },
                { "Antalya","Adana","Mersin" },
                { "Trabzon","Gireun","Samsun" },
                { "İzmir","Muğla","Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**********");
            }

            Console.ReadLine();
        }
    }
}
