using System.ComponentModel.Design;
using System.Net.Security;

namespace Leigh_Gladeau_Benjamin_A1_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tried my best to make the second choice work, but i didnt have much time at home to perfect it.
            string S1 = "Loyalty to Gang";
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
                    Console.WriteLine("Trying to turn over a new leaf, you leave your old life behind and help the law by helping them arrest your old gang.\nHaving your sentence shortened, you get out months later able to start a new life\nThe End."); 


                    if  (choiceTwo == "Escape")
                    {
                        Console.WriteLine("You take your chance when getting to your hideout, and while the Sheriff and his men\nare busy busting the door down, you take that opportunity to leave, take a horse and run.\nAfter a while you believe you got away, you are safe now.\nThe End");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                //second option for the first choice, and that should have had its own choices, but it didnt work, and went straight to else when i input it in correctly.
                if (pathOne == S1)
                {
                    Console.WriteLine($"sheriff - \"well {name}, I can't say that was the choice i would have gone with.\nBut we are all free to make our own decisions.\"");
                    Console.WriteLine("The sheriff walks out of sight and you are left with your own thoughts.");
                    Console.WriteLine("\nNow we are going to fast foward to the court date.");
                    Console.WriteLine("\nSheriff - \"We are here to lay the law down on this criminal that played a roll in the robbery that occured last week.\"");
                    Console.WriteLine("During that moment. You see your gang wearing masks coming to your rescue. They make quick work\nof the area and take the bindings off of you.");
                    Console.WriteLine("You are now left with another choice, what do you plan on doing with the Sheriff and his men?");

                    Console.WriteLine("- Type (Spare) for choice one. - Type (Kill) for choice two.");
                    string paththree = Console.ReadLine();
                    if (paththree == "Spare")
                    {
                        Console.WriteLine("Your gang holds choice as an important rule. Feeling it would do more harm than good\nYou put your gun down and decide to leave the Sheriff and his men, and leave peacefully with your gang.\nThe End");

                    if (paththree == "Kill")
                        {
                            Console.WriteLine("After everything that happened to you, you decide that they cannot live.\nSo being back with your gang again you choose to end the sheriff and his men.\nThe End");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not taking any action, the Sheriff pulls out a gun and shoots you\nThe End");
                    }

                }
            }
            //If you input a choice incorrectly they will assume you dont want either.
            else
            {
                Console.WriteLine($"unfortunately for you {name}, no one will know of your disapearance here.\nYou were never heard from again.");
            }
        }
    }
}
