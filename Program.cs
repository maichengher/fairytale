using System;

namespace storyTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string character, name, anwser, choice, town, person;

            Console.WriteLine("boy or girl?");
            character = Console.ReadLine();

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            if (character == "boy")
            {
                Console.WriteLine("Welcome, Prince " + name + "." + " You have been choose out of all the kingdom to find your once true love. If you fail, you can never return home.");
            } else if( character == "girl")
            {
                Console.WriteLine("Welcome, Princess " + name + "." + " You have been choose out of all the kingdom to find your once true love. If you fail, you can never return home.");
            };

         
           
            Console.WriteLine("Pack your bags? 'yes' or 'no'");
            anwser = Console.ReadLine();
            
            if (anwser == "yes")
            {
                Console.WriteLine("Go on your way young one.");
            } else if ( anwser == "no")
            {
                Console.WriteLine("You have doomed your kingdom.");
            };

            

            Console.WriteLine("Day 1: Upon leaving the kingdom gates, you are greeted by a young slave that works in the kitchen. What do you do?");
            Console.WriteLine("'talk' or 'ignore'");
            choice = Console.ReadLine();
            if (choice == "talk")
            {
                Console.WriteLine("You made a new friend and they will accompany you on this journey.");
            }
            else if (choice == "ignore")
            {
                Console.WriteLine("You go on your own way.");
            };

            

            Console.WriteLine("As you arrive to town, your bag gets stolen by a bunch of bandits.");
            Console.WriteLine("Do you 'follow' the thieves or 'go' to town?");
            town = Console.ReadLine();

            if (town == "follow")
            {
                Console.WriteLine("The bandits attacks you, but a charming stranger on a horse saves you.");
            } else if ( town == "go")
            {
                Console.WriteLine("You made it to town and are greeted by a charming stranger.");
            };

            

            Console.WriteLine("If you did not know by now, you have met two people. The slave who admires and respects you to want to go protect you, or the person you meet along the way.");
            Console.WriteLine("Choose who do you want to fall in love with.");
            Console.WriteLine("'person 1;' or 'person 2'?");
            person = Console.ReadLine();

            if (person == "man 1")
            {
                Console.WriteLine("You go back to your castle and fall in love with the person who wants to protect you.");
            } else if (person == "man 2")
            {
                Console.WriteLine("You stay in town and fall in love with the man that greets you. Then return home to your castle.");

            }

           
            Console.WriteLine("You live a happy life because you found the love of your life");
          
            Console.WriteLine("THE END");
        }
    }
}
