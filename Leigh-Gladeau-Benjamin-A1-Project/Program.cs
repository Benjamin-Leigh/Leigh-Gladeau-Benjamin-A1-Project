using System.Net.Security;

namespace Leigh_Gladeau_Benjamin_A1_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Waking up
            Console.WriteLine("You wake up, sun shining through bars within the window.");
            Console.WriteLine("You sit up and look towards the wooden door with a metal window.");
            Console.WriteLine("Your mind is foggy, but you can tell you are in a holding cell.");
            //Remembering the past day
            Console.WriteLine("\nThinking back to the day before, you and your gang were doing a heist.");
            Console.WriteLine("Being the lookout for the heist you were in charge of making sure your men know of upcoming issues.\nWhile outside you see the sheriff and his men on horseback over the hill top coming at a fast pace.");
            Console.WriteLine("You remember going to your men to warn them of incoming law enforcement and they have only a couple minutes to finish.");
            Console.WriteLine("Taking the initiative you stand by and distract law enforcement, giving your men time to escape with wha they can.");
            Console.WriteLine("Putting your gun on the ground you try and reason with law enforcement, you hear the movement of horses in the distance.\nNow sure of their depature, you feel better.");
            Console.WriteLine("You are arrested on sight and are taken to the front of the sheriffs office, but before entering, things go dark.");
            Console.WriteLine("\nNow remembering how events went and knowing I was knocked out by law enforcement, you realize your situation now.\nDuring that realization you hear footsteps outside the door and moments later see someones face at the door.\nYou recognize him as the sheriff.");
            //Sheriff gives you your choices
            Console.WriteLine("\nSheriff - \"Well well well, was wondering when you were gonna wake up after that \"Tumble\" you took earlier.");
            Console.WriteLine("You got us good there, had us fooled just long enough that my deputy lost track of the other members of your gang.");
            Console.WriteLine("Now you know about me, but i dont recognize you. Who are you? What is your name?\"");

            //Getting Readline to remember name, to make it easier to pull it later on.
            string name = Console.ReadLine();
            Console.Write($"Sheriff - \"Well i wish i could say it's nice to meet you {name}, But we have an issue.");
            Console.WriteLine("\nWe have been following your group for a while now, and if it weren't for an annonimous tip,\nwe would not have been catch you on time. And by all account we still didn't.");
            Console.WriteLine("I'm not gonna sugar coat this for you. You have two choices on what \"you\" can do right now");
            Console.WriteLine("First thing you can do, and this is the smart choice. You can aid us by telling us where your gang is.");
            Console.WriteLine("Secondly, and this will be a poor choice on your part. You recieve the firm hand of the law and take all charges.\nChoice is yours amigo.\"");

            //Added something you can see in game so you know exactly how to write a choice.
            Console.WriteLine("\n-Type (Help the Law) for choice one. - Type (Loyalty to Gang) for choice two");

            //Separate ReadLine that makes it easier to acknowledge particular choices. 
            string pathOne = Console.ReadLine();
            if (pathOne == "Help the Law")
            {
                Console.WriteLine($"Sheriff - \"You made the right choice {name}, we should get right to business then,\nafterall time is limited.\"");
                Console.WriteLine("After a bit of time of talking the sheriff mentions a plan to catch your group and bring them all into jail.");
                Console.WriteLine("Not wanting a long sentence, you agree that helping them will get you out of this mess and that way of life.");
                Console.WriteLine("You go along with them, and tell them where your hideout is, but now you are left with a moral choice.");
                Console.WriteLine("Do you go along with them to help with their arrest? or do you try and escape when you get the chance?");

                Console.WriteLine("\n- Type (Commit) for choice one. - Type (Escape) for choice two.");
                string choiceTwo = Console.ReadLine();
                if (choiceTwo == "Commit")
                {
                    Console.WriteLine();

                    if (choiceTwo == "Escape") 
                    { 
                        Console.WriteLine(); 
                    }
                   else
                    {
                        Console.WriteLine();
                    }

                    if (pathOne == "Loyalty to Gang")
                    {
                        Console.WriteLine($"sheriff - \"well {name}, I can't say that was the choice i would have gone with.\nBut we are all free to make our own decisions.\"");
                        Console.WriteLine("The sheriff walks out of sight and you are left with your own thoughts.");
                        Console.WriteLine("\nNow we are going to fast foward to the court date.");
                        Console.WriteLine("\nSheriff - \"We are here to lay the law down on this criminal that played a roll in the robbery that occured last week.\"");
                        Console.WriteLine("");

                        Console.WriteLine("- Type (Spare) for choice one. - Type (Kill) for choice two.");
                        string paththree = Console.ReadLine();
                        if (paththree == "Spare")
                        {
                            Console.WriteLine();

                            if (paththree =="Kill")
                            {
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                        }
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
