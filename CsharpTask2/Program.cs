using System.Drawing;
using System.Timers;

namespace CsharpTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Countdown Timer
            /* Console.WriteLine("Enter starting number:");
            int startNo;
            for(startNo = int.Parse(Console.ReadLine()); startNo >= 1; startNo--)
            {
                Console.WriteLine(startNo);
            }
            Console.WriteLine("Liftoff!");
            */
            ////////////////////////////////////////////////////
            //Task 2 - Sum of Numbers 1 to N
            /*Console.WriteLine("Enter a positive Number:");
            int N = int.Parse(Console.ReadLine());
            int Sum = 0;
            int i;
            for (i = 0 ; i <= N; i++)
            {
                Sum += i;
            }
            Console.WriteLine("Sum = " + Sum);*/
            ////////////////////////////////////////////////////
            //Task 3 - Multiplication Table
            /*Console.WriteLine("Enter a Number:");
            int N = int.Parse(Console.ReadLine());
            int i;
            int M;
            for (i = 0; i <= 10; i++)
            {
                M = N * i;
                Console.WriteLine("Multiplication = "+ N + "*" + i + "=" + M);
            }*/
            ////////////////////////////////////////////////////
            //Task 4 - Password Retry
            /*bool exit = false;
            string userPassword;

            while (exit == false)
            {
                Console.WriteLine("Enter your password : ");
                userPassword = Console.ReadLine();

                if (userPassword == "Spark2026")
                {
                    Console.WriteLine("Correct");
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Incorrect password, try again!!!");
                }
            }*/
            ////////////////////////////////////////////////////
            //Task 5 - Number Guessing Game
            /*int N;
            int Counter = 0;
            bool exit = false;
            do
            {

                Console.WriteLine("Guesse the number : ");
                N = int.Parse(Console.ReadLine());
                Counter++;

                if (N == 42)
                {
                    Console.WriteLine("Correct Guessing, " + Counter + " Attempts " );
                    exit = true;
                }
                else if(N < 42)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("Too high");
                }

            } while (exit == false);*/
            ////////////////////////////////////////////////////
            //Task 6 - Safe Division Calculator
            //when the type of number is double it not see 0 in divition as error and it give an output with ivinity
            //but when the type is integer it use DivideByZeroException
            /*try
            {
                Console.WriteLine("Enter first number : ");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number : ");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Result = " + num1 / num2);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Divid by zero is not accepted try diffrent number");
            }*/
            ////////////////////////////////////////////////////
            //Task 7 - Repeating Menu with Exit Option
            /*bool exit = false;
            int hour = DateTime.Now.Hour;
            while (exit == false)
            {
                Console.WriteLine("Choose from the menue: ");
                Console.WriteLine("1) Say Hello");
                Console.WriteLine("2) Show Current Time - of - day Greeting");
                Console.WriteLine("3) Exit.");
                try {
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Hello");
                            break;

                        case 2:
                            if (hour < 12)
                            {
                                Console.WriteLine("Good Morning! at " + DateTime.Now.ToString("H:mm tt"));
                            }
                            else if (hour < 18)
                            {
                                Console.WriteLine("Good Afternoon! at" + hour);
                            }
                            else 
                            { 
                                Console.WriteLine("Good Evening! at" + hour); 
                            }
                            break;

                        case 3:
                            Console.WriteLine("exit...");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Please choose a correct option");
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
              
            }*/
            ////////////////////////////////////////////////////
            //Task 8 - Sum of Even Numbers Only
            Console.WriteLine("Enter a positive Number:");
            int N = int.Parse(Console.ReadLine());
            int Sum = 0;
            int i;
            for (i = 0; i <= N; i++)
            {
                if(i % 2 == 0)
                {
                    Sum += i;
                }
                
            }
            Console.WriteLine("Sum = " + Sum);
            ////////////////////////////////////////////////////
            //Task 9 - Validated Positive Number Input
            ////////////////////////////////////////////////////
            //Task 10 - Simple ATM Simulation
            ////////////////////////////////////////////////////

        }
    }
}
