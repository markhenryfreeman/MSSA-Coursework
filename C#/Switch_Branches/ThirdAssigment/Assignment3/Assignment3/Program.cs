using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Choose an Option: ");
                Console.WriteLine(" ");
                Console.WriteLine("1: Get the cube of a number.");
                Console.WriteLine("2: Calculate the average of two numbers.");
                Console.WriteLine("3: Multiplication Table.");
                Console.WriteLine("4: Determine if in alphabetical order.");
                Console.WriteLine("5: Exit.");

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("You are running program {0}", option);
                        int i, ctr;
                        Console.Write("\n\n");
                        Console.Write("Display the cube of the number:\n");
                        Console.Write("---------------------------------");
                        Console.Write("\n\n");

                        Console.Write("Input number of terms : ");
                        ctr = Convert.ToInt32(Console.ReadLine());
                        for (i = 1; i <= ctr; i++)
                        {
                            Console.Write("Number is : {0} and cube of the {1} is :{2} \n", i, i, (i * i * i));
                        }

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("You are running program {0}", option);
                        int number1;
                        int number2;

                        Console.Write("Input first number: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Input second number: ");
                        number2 = Convert.ToInt32(Console.ReadLine());


                        decimal result = (number1 + number2) / 2;
                        Console.WriteLine(result);


                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("You are running program {0}", option);

                        int table = 9;
                        int length = 10;

                        //Console.WriteLine("Input reference number for multiplication table");
                        //table = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Multiplication table: " + table);
                        for (i = 1; i <= length; i++)
                            Console.WriteLine("{0, 2} * {1, 2} = {2}", i, table, i * table);

                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("You are running program {0}", option);
                        char temp;
                        string myString; //user input
                        Console.WriteLine("Enter String : ");
                        myString = Convert.ToString(Console.ReadLine());
                        string str = myString.ToLower();
                        char[] charstr = str.ToCharArray();

                        for (int x = 1; x < charstr.Length; x++)
                        {
                            for (int j = 0; j < charstr.Length - 1; j++) //0
                            {
                                if (charstr[j] > charstr[j + 1])
                                {
                                    temp = charstr[j];
                                    charstr[j] = charstr[j + 1];
                                    charstr[j + 1] = temp;
                                }
                            }
                        }
                        Console.WriteLine(charstr);
                        Console.ReadLine();

                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("There is no such program.");
                        break;
                }
            } while (flag);

        }
    }
}
