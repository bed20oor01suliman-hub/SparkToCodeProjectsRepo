//name of project
namespace CsharoSession1
{
    internal class Program 
    {
        //main entry point 
        static void Main(string[] args) 
        {
            /*Console.WriteLine("Hello, SparkToCode");

            Console.WriteLine("Please Enter Your Name:");
            string userName = Console.ReadLine();
           
            Console.WriteLine("Please Enter Your Age:");
            int userAge = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please Enter Your CGPA:");
            float userCGPA = float.Parse(Console.ReadLine());


            Console.WriteLine("User Name: " + userName + "Age: " +userAge + "CGPA: " + userCGPA);*/
            /////////////////////////////////////////////////

            /*
             //The addition process
            
            Console.WriteLine("Enter first number: ");
            float firstNo = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter second number: ");
            float secondNo = float.Parse(Console.ReadLine());

            float additionResult = firstNo + secondNo;
            float subtractionResult = firstNo - secondNo;
            float multiplicationResult = firstNo * secondNo;
            float divitionResult = firstNo / secondNo;
            bool comparazim = firstNo == secondNo;

            Console.WriteLine("Addition Result: " + additionResult);
            Console.WriteLine(" Subtraction Result: " + subtractionResult);
            Console.WriteLine(" Multiplication Result: " + multiplicationResult);
            Console.WriteLine(" Divition Result: " + divitionResult);
            Console.WriteLine(" Comparazim: " + comparazim);
            */
            /////////////////////////////////////////////////
            //if else statment
            //Console.WriteLine("Enter Your Degree");
            //float degree = float.Parse(Console.ReadLine());
            //if(degree >=0 && degree < 50)
            //{
            //    Console.WriteLine("You Failed");
            //}
            //else if(degree >=50 && degree<60)
            //{
            //    Console.WriteLine("Passed with Grade: D");
            //}
            //else if(degree>=60 && degree < 70)
            //{
            //    Console.WriteLine("Passed with Grade: C");
            //}
            //else if(degree>=70 && degree < 80)
            //{
            //    Console.WriteLine("Passed with Grade: B");
            //}
            //else if (degree > 80)
            //{
            //    Console.WriteLine("Passed with Grade: A");
            //}
            //else
            //{
            //    Console.WriteLine("Wronge Number");
            //}
            /////////////////////////////////////////////////
            //Create switch case 
            Console.WriteLine("Welcome to main menue: ");
            Console.WriteLine("1.Deposite");
            Console.WriteLine("2.Withdraw");
            Console.WriteLine("3.Balance check");

            Console.WriteLine("Please choose an option: ");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Deposited");
                    break;

                case 2:
                    Console.WriteLine("Withdrawed");
                    break;

                case 3:
                    Console.WriteLine("Your balance = ");
                    break;

                default:
                    Console.WriteLine("Please choose a correct option");
                    break;
            }

        }
    }
}
