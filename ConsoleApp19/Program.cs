using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {//Task1();
            Task2();
            //Task3();
            //Task4();
            //Task5();
            ReadLine();
        }
        private static void Task5()
        {
            char[] mas = new char[125];
            string main_number = "";
            Write(" ");
            main_number = ReadLine();
            //main_number.
            WriteLine(main_number);
            mas = main_number.ToCharArray();
            Array.Reverse(mas);
            WriteLine(mas);

        }

        private static void Task4()
        {
            int number_A = 0, number_B = 0; bool isnotCompleted = true;
            while (isnotCompleted)
            {

                WriteLine("Введите первое число.");
                while (!int.TryParse(ReadLine(), out number_A))
                {
                    Clear();
                    Write("Ошибка, введите целое число: ");
                }
                WriteLine("Введите второе число которое больше первого.");
                while (!int.TryParse(ReadLine(), out number_B))
                {
                    Clear();
                    Write("Ошибка, введите целое число: ");
                }
                if (number_A < number_B)
                {
                    for (int i = number_A; i <= number_B; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            WriteLine(i);
                        }

                    }
                    isnotCompleted = false;
                }
                else
                {
                    WriteLine("Я сказал ввести число больше чем первое. ");
                }
            }

        }

        private static void Task3()
        {
            int symbol;
            char new_symbol;
            while (true)
            {
                WriteLine("Введите символ");
                symbol = Read();

                if (symbol >= 65 && symbol <= 90)
                {
                    symbol = symbol + 32;
                    new_symbol = (char)symbol;
                    WriteLine(new_symbol);

                }
                else if (symbol >= 97 && symbol <= 122)
                {
                    symbol = symbol - 32;
                    new_symbol = (char)symbol;
                    WriteLine(new_symbol);
                }
                else if (symbol == 46)
                {
                    break;
                }
                else
                {
                    new_symbol = (char)symbol;
                    WriteLine(new_symbol);
                }

            }

            ReadLine();
        }




        private static void Task2()
        {
            int ticket;
            int first_number;
            int hundred_thousand = 100000;
            int second_number;
            int ten_thousnad = 10000;
            int third_number;
            int thousand = 1000;
            int fourth_number;
            int hundread = 100;
            int fifth_number;
            int ten = 10;
            int sixth_number;
            WriteLine("Enter the number of ticket(Example(123455,223345)->");
            while (!int.TryParse(ReadLine(), out ticket))
            {
                Clear();
                Write("Ошибка, введите целое число: ");
            }
            first_number = ticket / hundred_thousand;
            ticket = ticket - (first_number * hundred_thousand);
            second_number = ticket / ten_thousnad;
            ticket = ticket - (second_number * ten_thousnad);
            third_number = ticket / thousand;
            ticket = ticket - (third_number * thousand);
            fourth_number = ticket / hundread;
            ticket = ticket - (fourth_number * hundread);
            fifth_number = ticket / ten;
            sixth_number = ticket % ten;
            if (first_number + second_number + third_number == fourth_number + fifth_number + sixth_number)
            {
                Write("You have happy ticket.");
            }
            else
            {
                Write("Your have no happy ticket");
            }
        }
        private static void Task1()
        {
            string symbol;
            string dot = ".";
            while (true)
            {
                Write("Enter the symbol->");
                symbol = ReadLine();
                WriteLine(symbol);
                if (symbol == dot)
                {
                    break;
                }
            }
            ReadLine();
        }


    }
}



