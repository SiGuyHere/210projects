using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string stringGrade = Console.ReadLine();
        int grade = int.Parse(stringGrade);
        string letterGrade = "X";
        if (grade >= 90) {
            letterGrade = "A";
        } else if (grade >= 80) {
            letterGrade = "B";
        } else if (grade >= 70) {
            letterGrade = "C";
        } else if (grade >= 60) {
            letterGrade = "D";
        } else {
            letterGrade = "F";
        }
        Console.WriteLine($"Your letter grade was {letterGrade}");
        if (grade >= 70) {
            Console.WriteLine("You passed");
        } else {
            Console.WriteLine("Try harder next time.");
        }
    }
}