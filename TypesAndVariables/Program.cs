using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello world!");
            int number1 = 2147483647;  //32bit
            long number2 = 2147483648; //64bit
            short number3 = 32767;     //16bit
            byte number4 = 255;        //8bit
            bool condition = true;     //Condition
            char character = 'A';      //Character 
            double number5 = 10.4;     //Ondalıklı 32bit
            decimal number6 = 10.4m;   //Uzun ondalıklı 64bit
            var number7 = 10;
            number7 = 'A';

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);

            Console.WriteLine("Character is : {0}", (int)character);
            Console.WriteLine(condition);
            Console.WriteLine((int)Days.Saturday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

}
