using System;
using System.IO;

public class magic8Ball
{
    public static void Main(string[] args)
    {
        string[] answer = {
            "Learn the way of the force.",
            "Do or not do.",
            "I am your father",
            "It's a trap!",
            "Laugh it up, fuzzball!",
            "I find your lack of faith disturbing.",
            "These aren’t the droids you’re looking for.",
            "Chewie, we’re home.",


        };

        Console.WriteLine("Welcome to the MaGgIc 8 Ball!");
        Console.WriteLine("Ask a question and I shall reveal!");
        Console.WriteLine();

        bool keepAsking = true;
        while (keepAsking)
        {
            Console.WriteLine("Ask you question: ");
            string question = Console.ReadLine();
            Random random = new Random();


            int randomIndex = random.Next(answer.Length);
            string randomAnswer = answer[randomIndex];
        
            Console.WriteLine("The Magic 8 ball says: " + randomAnswer);
            Console.WriteLine();

        }



        //Console.Write("Enter your name: ");
        //string name = Console.ReadLine();


        //Console.Write("Enter your age: ");
        //string ageInput = Console.ReadLine();


        //Console.WriteLine("Hello, " + name + "!");


        //bool isStudent = true;
        //double height = 1.75;

        //Console.WriteLine("Is student: " + isStudent);
        //Console.WriteLine("Height: " + height);


        //Console.WriteLine($"Your name is {name} and you entered age: {ageInput}");


        //Console.WriteLine("\nPress any key to exit.");
        //Console.ReadKey();
    }
}