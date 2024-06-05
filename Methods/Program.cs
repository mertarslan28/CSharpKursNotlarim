using System;
using System.Linq;
using System.Threading;
using System.Xml.Schema;

namespace Methods
{
    internal class Program
    {

        public static void Sleep(int Sleeptime)
        {
            Thread.Sleep(Sleeptime);
        }

        public static void Sound(int frekans, int sure)
        {
            Console.Beep(frekans, sure);
        }

        static void Start()
        {
            Sound(200,500);
            Sound(300,500);
            Sound(400,500);
            Sound(500,500);
        }
        static void Main(string[] args)
        {
            Add();
            //var result = Add1(2, 3);
            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add2(number1 , number2);


            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));

            

            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add1(int number1, int number2)
        {
            //var result = number1 + number2
            //return result;
            return number1 + number2;
        }

        static int Add2(ref int number1, int number2)
        {
            number1 = 30;
            return (number1 + number2);
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        } 
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Topla(int n)
        {
            int total = n * (n + 1) / 2;
            return total;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
