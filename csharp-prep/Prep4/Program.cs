using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input numbers and type 0 to stop.");
        int realNumber;
        int sum  = 0;
        int max = 0;

        List<int> numbers =  new List<int>();
        do
        {
            Console.WriteLine("Enter a number: ");
            string number = Console.ReadLine();
            realNumber = int.Parse(number);
            numbers.Add(realNumber);
            if (realNumber > max) {
                max = realNumber;
            }
        } while (realNumber != 0);
        foreach (int addNumber in  numbers)
        {
            sum += addNumber;
        }
        float avg = sum/(numbers.Count-1);
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {avg}");
        Console.WriteLine($"The largest number is {max}");
    }
}