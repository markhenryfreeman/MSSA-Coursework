using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    class Game
    {
        public void whatIsIt()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You are running program 6.");

            int myNumber = 0;
            int myResult = 0;
            Console.WriteLine("Enter a number:");
            myNumber = int.Parse(Console.ReadLine());

            myResult = myNumber % 2;

            if (myResult == 0)
            {
                Console.WriteLine("The number is even.\n");
            }
            else
            {
                Console.WriteLine("The number is odd.\n");
            }
        }


        public void guess()
        {
            Console.WriteLine("You are running program 1.");
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 100);
            //Console.WriteLine(randomNumber);
            Console.WriteLine("What is your first guess?");
            int guess1 = int.Parse(Console.ReadLine());

            if (guess1 == randomNumber)
            {
                Console.WriteLine("Congradulations, you are a winner!\n");
            }
            else
            {
                if (guess1 > randomNumber)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                else
                {
                    Console.WriteLine("Your guess is too low.");
                }
                Console.WriteLine("What is your second guess?");
            }
            int guess2 = int.Parse(Console.ReadLine());
            if (guess2 == randomNumber)
            {
                Console.WriteLine("Congradulations, you are a winner!\n");
            }
            else
            {
                if (guess2 > randomNumber)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                else
                {
                    Console.WriteLine("Your guess is too low.");
                }
                Console.WriteLine("What is your third guess?");
            }
            int guess3 = int.Parse(Console.ReadLine());
            if (guess3 == randomNumber)
            {
                Console.WriteLine("Congradulations, you are a winner!\n");
            }
            else
            {
                Console.WriteLine("Sorry, you lose. The number was {0}\n", randomNumber);
                Console.WriteLine("Select a new option.");
            }
        }


        public void prime()
        {
            Console.WriteLine("You are running program 2.");
            int numberPrime, i, m = 0, x = 0;

            Console.WriteLine("Enter a number to check if Prime.");
            numberPrime = int.Parse(Console.ReadLine());
            m = numberPrime / 2;
            for (i = 2; i <= m; i++)
            {
                if (numberPrime % i == 0)
                {
                    Console.WriteLine("This number is not Prime.\n");
                    x = 1;
                    break;
                }
            }
            if (x == 0)
                Console.WriteLine("This number is Prime.\n");
        }



        public void factorial()
        {
            Console.WriteLine("You are running program 3.");
            Console.WriteLine("Provide a number.");

            int number1 = int.Parse(Console.ReadLine()), fact = 1;
            for (int i = 1; i <= number1; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }


        public void rockPaper()
        {
            Console.WriteLine("You are running program 4.");
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 4);
            string computerPick;
            string userPick;
            string userEntry;

            if(randomNumber == 1)
            {
                computerPick = "rock";
            }
            else if(randomNumber == 2)
            {
                computerPick = "paper";
            }
            else
            {
                computerPick = "scissors";
            }

            Console.WriteLine("Do you chose rock, paper, or scissors!");
            userEntry = Console.ReadLine();
            userPick = userEntry.ToLower();


            if (userPick == "rock" && computerPick == "scissors")
            {
                Console.WriteLine("You win!! \n The computer chose {0} and you chose {1}", computerPick, userPick);
            }
            else if (userPick == "paper" && computerPick == "rock")
            {
                Console.WriteLine("You win!! \n The computer chose {0} and you chose {1}", computerPick, userPick);
            }
            else if (userPick == "scissors" && computerPick == "paper")
            {
                Console.WriteLine("You win!! \n The computer chose {0} and you chose {1}", computerPick, userPick);
            }
            else if (userPick == computerPick)
            {
                Console.WriteLine("You tied, but i mean if you aint first your last. \nThe computer chose {0} and you chose {1}", computerPick, userPick);
            }
            else
            {
                Console.WriteLine("you suck, and by that i mean you lost! \nThe computer chose {0} and you chose {1}", computerPick, userPick);
            }

            Console.WriteLine("Please press any key to continue");
            Console.ReadKey();
        }

        public void findSeason()
        {
            Console.WriteLine("You are running program 5.");
            Console.WriteLine("Please enter the date you'd like to search (format: MM/DD/YYYY)");
            string inputDate = Console.ReadLine();
            DateTime date = Convert.ToDateTime(inputDate);
            int currentDate = date.DayOfYear;
            if (currentDate >= 79 && currentDate < 171)
            {
                Console.WriteLine("It's spring!");
            }
            else if (currentDate >= 171 && currentDate < 265)
            {
                Console.WriteLine("It's summer!");
            }
            else if (currentDate >= 265 && currentDate < 355)
            {
                Console.WriteLine("It's fall!");
            }
            else
            {
                Console.WriteLine("It's Winter!");
            }
        }
    }
    }
