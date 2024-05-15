using System.Net.Security;

namespace Leigh_Gladeau_Benjamin_A1_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("You wake up, sun shining through bars within the window.");
            Console.WriteLine("You sit up and look towards the wooden door with a metal window.");
            Console.WriteLine("Your mind is foggy, but you can tell you are in a holding cell.");

            Console.WriteLine("\nThinking back to the day before, you and your gang were doing a heist.");
            Console.WriteLine("Being the lookout for the heist you were in charge of making sure your men know of upcoming issues.\nWhile outside you see the sheriff and his men on horseback over the hill top coming at a fast pace.");
            Console.WriteLine("You remember going to your men to warn them of incoming law enforcement and they have only a couple minutes to finish.");
            Console.WriteLine("Taking the initiative you stand by and distract law enforcement, giving your men time to escape with wha they can.");
            Console.WriteLine("Putting your gun on the ground you try and reason with law enforcement, you hear the movement of horses in the distance.\nNow sure of their depature, you feel better.");
            Console.WriteLine("You are arrested on sight and are taken to the front of the sheriffs office, but before entering, things go dark.");
            Console.WriteLine("\nNow remembering how events went and knowing I was knocked out by law enforcement, you realize your situation now.\nDuring that realization you hear footsteps outside the door and moments later see someones face at the door.\nYou recognize him as the sheriff.");

            Console.WriteLine("\nSheriff - \"Well well well, was wondering when you were gonna wake up after that \"Tumble\" you took earlier.");
            Console.WriteLine("You got us good there, had us fooled just long enough that my deputy lost track of the other members of your gang.");
            Console.WriteLine("Now you know about me, but i dont recognize you. Who are you? What is your name?\"");

            //Getting Readline to remember name, to make it easier to pull it later on.
            string name = Console.ReadLine();
            Console.Write($"Well i wish i could say it's nice to meet you {name}, But we have an issue.");
            Console.WriteLine("\nWe have been following your group for a while now, and it was an annonimous tip\nthat even allowed us to catch you on time.");
            Console.WriteLine("Im gonna say you have two choices on what you can do right now");
            Console.WriteLine("First is you can aid us, or you get the law served to you. Choice is yours");
            //Added something you can see in game so you know exactly how to write a choice.
            Console.WriteLine("\n-Type (Aid) for choice one. - Type (Not Help) for choice two");
            //Separate ReadLine that makes it easier to acknowledge particular choices. 
            string choice = Console.ReadLine();
            if (choice == "Aid")
            {
                Console.WriteLine($"You made the right choice {name}, we should get right to business then,\nafterall time is limited.");
                Console.WriteLine("");

                if (choice == "Not Help")
                {
                    Console.WriteLine($"well {name}, you are free to that choice.");
                    Console.WriteLine("");
                }
            }
            //If you input a choice incorrectly they will assume you dont want either.
            else
            {
                Console.WriteLine($"unfortunately for you {name}, no one will know of your disapearance here.\nYou were never heard from again.");
            }
            Console.WriteLine("");

        }
    }
}
