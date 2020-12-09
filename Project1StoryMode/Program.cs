using System;
using System.Threading;
namespace Project1StoryMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;


            //lets the user know that the program is starting and any instructions
            Console.WriteLine("The story is starting,once ready press enter and fill in some prompts to make the story interesting");

        //instructions to the user
        Console.Write("Enter a title for the story "); 

            //creating a string variable to hold any values
            string title = Console.ReadLine();

            Console.WriteLine(title);


            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            string adj1 = Console.ReadLine();
            Console.Write("Enter an adjective: ");
            string adj2 = Console.ReadLine();
            Console.Write("Enter an adjective: ");
            string adj3 = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine(adj1);
            Console.WriteLine(adj2);
            Console.WriteLine(adj3);


            Console.Write("Enter an verb: ");
            string verb = Console.ReadLine();

            Console.Write("Enter an Noun: ");
            string noun1 = Console.ReadLine();
            Console.Write("Enter an Noun: ");
            string noun2 = Console.ReadLine();


            Console.Write("Enter an animal: ");
            string animal = Console.ReadLine();
            Console.Write("Enter a food: ");
            string food = Console.ReadLine();
            Console.Write("Enter a fruit: ");
            string fruit = Console.ReadLine();
            Console.Write("Enter a superhero: ");
            string superhero = Console.ReadLine();
            Console.Write("Enter a country: ");
            string country = Console.ReadLine();
            Console.Write("Enter a dessert: ");
            string dessert = Console.ReadLine();
            Console.Write("Enter a year: ");
            string year = Console.ReadLine();


            // The template for the story:

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' In the news, an army of {animal}s were protesting to keep {food} in farms. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);


            Thread.Sleep(1000);
            Console.WriteLine($"Thank you for reading the story. Bye {name}");
            Thread.Sleep(10000);
        }
    }
}
