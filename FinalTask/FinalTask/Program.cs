using System;

namespace FinalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Cities = new string[5] { "Bonn", "Moscow", "NY", "LA", "Rom" };
            string[] CitiesShort = new string[Cities.Length];

            ShortCitiesArray(Cities, CitiesShort);
            PrintArray(CitiesShort);

        }

        static void ShortCitiesArray(string[] array1, string[] array2)
        {
            int count = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i].Length <= 3)
                {
                    array2[count] = array1[i];
                    count++;
                }
            }
        }
        static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}