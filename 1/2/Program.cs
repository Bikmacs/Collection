using System;
using System.Linq;

class Program
{
    static string ProcessText(string text)
    {
        var result = text.Aggregate("", (acc, c) => c == '#' ? (acc.Length > 0 ? acc.Substring(0, acc.Length - 1) : acc) : acc + c);
        return result;
    }

    static void Main(string[] args)
    {
        string text = "abc#d##c";
        string result = ProcessText(text);
        Console.WriteLine(result); 
    }
}
