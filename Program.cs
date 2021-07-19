using System;
using System.Collections.Generic;

namespace myList
{
    internal class Program
    {
        public static void Main()
        {
            bool isExit =false;
            string userInput;
            List<int> numbers = new List<int>();
            
            do
            {
                Console.Write("Введите число или Команду sum для вычисления суммы " +
                              "всех чисел либо exit для выхода из программы :");
                userInput = Console.ReadLine();
                int result;
                if (int.TryParse(userInput, out result))
                    numbers.Add(result);
                else
                {
                    if (userInput == "exit")
                        isExit=true;
                    else if (userInput == "sum")
                    {
                        int sum = 0;
                        foreach (var number in numbers)
                            sum += number;
                        Console.WriteLine("Сумма = " + sum);
                    }
                }
            } 
            while (isExit==false);
        }
    }
}