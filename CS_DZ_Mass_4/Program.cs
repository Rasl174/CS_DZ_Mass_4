using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_Mass_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[0];
            bool exit = false;

            Console.WriteLine("Для сложения введите sum. Для выхода введите exit.");

            while (!exit)
            {
                Console.Write("Введите числa которые нужно сложить , sum или exit: ");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "sum")
                {
                    int arraySum = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        arraySum += array[i];
                    }
                    Console.Clear();
                    Console.WriteLine("Сумма: " + arraySum);
                }

                else if (int.TryParse(userInput, out int number))
                {
                    int[] tempArray = new int[array.Length + 1];
                    tempArray[tempArray.Length - 1] = int.Parse(userInput);
                    for (int i = 0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                    }
                    array = tempArray;
                }

                else if (userInput.ToLower() == "exit")
                {
                    exit = true;
                }
            }
        }
    }    
}
