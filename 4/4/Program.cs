using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "1.txt";
        if (File.Exists(filePath))
        {
            string formula = File.ReadAllText(filePath);
            Console.WriteLine($"Результат вычисления формулы из файла: {Primer(formula)}");
        }
        else
        {
            Console.WriteLine("Файл с формулой не найден.");
        }
    }

    static int Primer(string formula)
    {
        Stack<object> stack = new Stack<object>();

        foreach (char c in formula)
        {
            if (char.IsDigit(c))
            {
                stack.Push(int.Parse(c.ToString()));
            }
            else if (c == 'm' || c == 'p')
            {
                stack.Push(c);
            }
            else if (c == '(')
            {
                continue;
            }
            else if (c == ')')
            {
                int b = (int)stack.Pop();
                int a = (int)stack.Pop();
                char opera = (char)stack.Pop();
                int result;

                if (opera == 'm')
                {
                    result = (a - b) % 10;
                }
                else
                {
                    result = (a + b) % 10;
                }

                stack.Push(result);
            }
        }

        return (int)stack.Pop();
    }
}
