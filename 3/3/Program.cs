using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "1.txt"; 
        List<string> capitalWords = new List<string>();
        List<string> lowercaseWords = new List<string>();
        try
        {
            // Считываем текст из файла
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                // Разбиваем строку на слова
                string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (char.IsUpper(word[0]))
                        capitalWords.Add(word);
                    else
                        lowercaseWords.Add(word);
                }
            }
            capitalWords.ForEach(Console.WriteLine);
            lowercaseWords.ForEach(Console.WriteLine);
        }
        catch (IOException e)
        {
            Console.WriteLine("Ошибка при чтении файла: " + e.Message);
        }
    }
}
