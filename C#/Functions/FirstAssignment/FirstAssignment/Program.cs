using System;
using System.Diagnostics;

namespace FirstAssignment
{
    class Program
    {

        static void Main(string[] args)
        {
            Exception notAPositiveValue = new Exception("Custom exception");

            try
            {
                int bad = int.Parse(Console.ReadLine());
                if(bad < 0)
                {
                    throw notAPositiveValue;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            bool flag = true;
            do
            {

                Console.WriteLine("Choose an Option: ");
                Console.WriteLine("1: Calculation the income of an employee with an annual salary.");
                Console.WriteLine("2: Calculate if a student passes or fails a course.");
                Console.WriteLine("3: Multiply two numbers.");
                Console.WriteLine("4: Divide two numbers.");
                Console.WriteLine("5: Compare two numbers.");
                Console.WriteLine("6: Determine if a number is odd or even.");
                Console.WriteLine("7: Extra Functionality.");
                Console.WriteLine("8: Exit.\n");
                int option = 0;
                try
                {
                    option = int.Parse(Console.ReadLine());
                } catch (FormatException e)
                {
                    Trace.WriteLine(e);
                }

                //custom
                //int option = 0;
                //try
                //{
                //    option = int.Parse(Console.ReadLine());
                //    if(option < 1 && > 8){
                //var ex = new IndexOutOfRangeException("There's no option for that number.");
                //throw ex;
                //}
                //catch (IndexOutOfRangeException e)
                //{
                //    Trace.WriteLine(e);
                //}





                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Calculator incomeCal = new Calculator();
                        incomeCal.employeeIncome();
                        break;
                    case 2:
                        Console.Clear();
                        Calculator studentGrade = new Calculator();
                        studentGrade.courseGrade();
                        break;
                    case 3:
                        Console.Clear();
                        Math multiplyNumbers = new Math();
                        multiplyNumbers.multiply();
                        break;
                    case 4:
                        Console.Clear();
                        Math divideNumbers = new Math();
                        divideNumbers.divide();
                        break;
                    case 5:
                        Console.Clear();
                        Math compareNumbers = new Math();
                        compareNumbers.compare();
                        break;
                    case 6:
                        Console.Clear();
                        Game oddEven = new Game();
                        oddEven.whatIsIt();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("You are running program {0}", option);
                        bool submenu = true;
                        do
                        {
                            Console.WriteLine("Choose an Option: ");
                            Console.WriteLine("1: Guess a number.");
                            Console.WriteLine("2: Is it a prime number.");
                            Console.WriteLine("3: Determine the factorial.");
                            Console.WriteLine("4: Rock-Paper-Scissors.");
                            Console.WriteLine("5: Determine the season.");
                            Console.WriteLine("6: Go back.\n");
                            int newOption = int.Parse(Console.ReadLine());
                            switch (newOption)
                            {

                                case 1:
                                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Clear();
                                    Game letsPlay = new Game();
                                    letsPlay.guess();
                                    break;
                                case 2:
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Clear();
                                    Game whatPrime = new Game();
                                    whatPrime.prime();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Game funMath = new Game();
                                    funMath.factorial();
                                    break;
                                case 4:
                                    Console.Clear();
                                    Game rpc = new Game();
                                    rpc.rockPaper();
                                    break;
                                case 5:
                                    Console.Clear();
                                    Game season = new Game();
                                    season.findSeason();
                                    break;
                                case 6:
                                    submenu = false;
                                    break;
                                default:
                                    Console.WriteLine("There's no such program.\n");
                                    break;
                            }


                        } while (submenu);
                        break;

                    case 8:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("There is no such program.\n");
                        break;
                }
            } while (flag);

            //Console.ReadKey();
        }
    }
}