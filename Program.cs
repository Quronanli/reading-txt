using System;

using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "data.txt";
        int[] numbers;

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            numbers = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                numbers[i] = int.Parse(lines[i]);
            }
        }
        
        catch (Exception ex)
        {
            Console.WriteLine("Помилка при зчитуванні файлу: " + ex.Message);
            return;
        }
        int min = numbers[0];
        int max = numbers[0];
        
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        Console.WriteLine("Мінімальне значення: " + min);
        Console.WriteLine("Максимальне значення: " + max);
    }
}