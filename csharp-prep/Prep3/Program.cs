using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int numberGuess;
        do
        {
            Console.WriteLine("Guess a number between 1 and 10");
            string guess =  Console.ReadLine();
            numberGuess =  int.Parse(guess);
            if  (numberGuess < number)
            {
                Console.WriteLine("Too low");
            }  else if (numberGuess > number)
            {
                Console.WriteLine("Too high");
            } else 
            {
                Console.WriteLine("You guessed it!");
            }
        } while (numberGuess !=  number);

        // for (int i = 1; i <= 10; i++)
        // {
        //     Console.WriteLine($"The number is {i} and its square is {i * i}");
        // }
    }
}