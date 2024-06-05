using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForeachLoop();
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //IsPrimeNumber(1);
            if (AsalSayi(7))
            {
                Console.WriteLine("Asal sayıdır.");
            }
            else
            {
                Console.WriteLine("Asal sayı değildir");
            }
            Console.ReadLine();
        }

        //private static bool IsPrimeNumber(int number)
        //{
        //    bool result = true;
        //}

        private static bool AsalSayi(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }



        private static void ForeachLoop()
        {   //Foreach Döngüsü
            string[] isimler = { "Ali", "Ayşe", "Fatma" };
            foreach (string isim in isimler)
            {
                Console.WriteLine("İsim: " + isim);
            }
            //Bu döngü, isimler dizisindeki her bir öğeyi sırayla 
            //isim değişkenine atar ve döngü gövdesinde kullanır.
        }

        private static void ForLoop()
        {   //For Döngüsü
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            //Bu döngü, i değişkenini 0'dan başlatır, 10'dan küçük olduğu sürece döner 
            //her seferinde i'yi 1 artırır. Döngü her iterasyonda
            //Console.WriteLine ifadesini çalıştırır.
        }

        private static void WhileLoop()
        {   //While Döngüsü
            int number = 10;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            //Bu döngüde, i değişkeni 10'dan küçük olduğu sürece döngü çalışmaya devam eder 
            //ve her seferinde i 1 artırılır.
        }

        private static void DoWhileLoop()
        {   //Do While Döngüsü
            int i = 0;
            do
            {
                Console.WriteLine("i değeri: " + i);
                i++;
            } while (i < 10);
            //Bu döngüde, önce döngü gövdesi çalışır, ardından koşul kontrol edilir.
            //Koşul doğru olduğu sürece döngü devam eder.
        }



    }
}
