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
            bool canExit = false;

            Console.WriteLine("Для сложения введите sum. Для выхода введите exit.");

            while (!canExit)
            {
                Console.Write("Введите числa которые нужно сложить , sum или exit: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "sum":

                        int arraySum = 0;
                        for (int i = 0; i < array.Length; i++)
                        {
                            arraySum += array[i];
                        }
                        Console.Clear();
                        Console.WriteLine("Сумма: " + arraySum);
                        break;

                    case "exit":

                        canExit = true;
                        break;

                }

                if (int.TryParse(userInput, out int numbers))
                {
                    int[] tempArray = new int[array.Length + 1];
                    tempArray[tempArray.Length - 1] = int.Parse(userInput);
                    for (int i = 0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                    }
                    array = tempArray;
                }
            }
        }
    }
}