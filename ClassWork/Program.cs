using ClassWork.Models;
using System;

namespace ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = GetInputInt("Nece eded notebook daxil edeceksizin?", 0);

            Notebook[] notebooks = new Notebook[length];

            for (int i = 0; i < length; i++)
            {
                double price = GetInputDouble($"{i + 1}.ci notebookun qiymeti daxil edin: ", 200);

                int count = GetInputInt($"{i + 1}.ci notebookun count: ", 1);

                string brandName = GetInputStr($"{i + 1}.ci notebookun brand: ", 2, 30);

                string model = GetInputStr($"{i + 1}.ci notebookun model: ", 2, 30);

                int ram = GetInputInt($"{i + 1}.ci notebookun RAM: ", 4);

                int storage = GetInputInt($"{i + 1}.ci notebookun Storage", 128);

                notebooks[i] = new Notebook(brandName, price, count)
                {
                    model = model,
                    ram = ram,
                    storage = storage
                };
            }

            foreach (Notebook notebook in notebooks)
            {
                Console.WriteLine(notebook.GetInfo());
            }

        }

        static int GetInputInt(string name, int min, int max = int.MaxValue) 
        {
            int input;
            do
            {
                Console.WriteLine(name);
                input = Convert.ToInt32(Console.ReadLine());
            } while (input < min || input > max);

            return input;
        }

        static double GetInputDouble(string name, double min, double max = double.MaxValue)
        {
            double input;
            do
            {
                Console.WriteLine(name);
                input = Convert.ToDouble(Console.ReadLine());
            } while (input < min || input > max);

            return input;
        }

        static string GetInputStr(string name, int min, int max = int.MaxValue)
        {
            string input;
            do
            {
                Console.WriteLine(name);
                input = Console.ReadLine();
            } while (input.Length < min || input.Length > max);

            return input;
        }
    }
}
