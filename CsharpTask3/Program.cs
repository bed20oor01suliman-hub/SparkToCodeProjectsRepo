using System.Reflection.Metadata;

namespace CsharpTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Absolute Difference
            /*Console.WriteLine("Enter first number: ");
            float firstNo = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            float secondNo = float.Parse(Console.ReadLine());

            float subtractionResult = Math.Abs(secondNo - firstNo);

            Console.WriteLine("Subtraction Result: " + subtractionResult);*/
            ////////////////////////////////////////////////////
            //Task 2 - Power & Root Explorer
            /*Console.WriteLine("Enter a number: ");
            double num = double.Parse(Console.ReadLine());
            double square = Math.Pow(num,2);
            double squareRoot = Math.Sqrt(num);

            Console.WriteLine("Square Result: " + square);
            Console.WriteLine("Square Power of 2 Result: " + squareRoot);*/
            ////////////////////////////////////////////////////

            //Task 3 - Name Formatter
            /*Console.WriteLine("Enter your full name: ");
            string fullName = Console.ReadLine();
            string fullNameUpper = fullName.ToUpper();
            string fullNameLower = fullName.ToLower();
            int fullNameLength = fullName.Length;

            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("Full Name In Upper: " + fullNameUpper);
            Console.WriteLine("Full Name In Lower: " + fullNameLower);
            Console.WriteLine("Full Name Length : " + fullNameLength);*/
            ////////////////////////////////////////////////////

            //Task 4 - Subscription End Date
            /*Console.WriteLine("Enter number of days of a free trial: ");
            int dFreeTrial = int.Parse(Console.ReadLine());
            DateTime todayDate = DateTime.Today;
            DateTime calEndDate = todayDate.AddDays(dFreeTrial);
            Console.WriteLine("End Date : " + calEndDate.ToString("yyyy-MM-dd")); */


            ////////////////////////////////////////////////////

            //Task 5 - Grade Rounding System
            /*Console.WriteLine("Enter raw exam score as a decimal number ");
            double decimalNumScore = double.Parse(Console.ReadLine());
            double roundNumScore = Math.Round(decimalNumScore);
            Console.WriteLine("Rounded Number Score : " + roundNumScore);
            if (roundNumScore >= 60)
            {
                Console.WriteLine("Result: Pass");
            }
            else
            {
                Console.WriteLine("Result: Fail");
            }
            */

            ////////////////////////////////////////////////////

            //Task 6 - Password Strength Checker
            /*Console.WriteLine("Enter Password : ");
            string password = Console.ReadLine();
            int passwordLength= password.Length;
            bool passwordContain = password.ToLower().Contains("password");
            if (passwordLength >= 8 && !passwordContain)
            {
                Console.WriteLine("Strong");
                Console.WriteLine("Password Length is more than or equal to 8 characters & not contains password word");
            }
            else
            {
                Console.WriteLine("Weak!");
                if(passwordLength < 8)
                {
                    Console.WriteLine("Password length less than 8 Characters");
                }
                else if(passwordContain == true)
                {
                    Console.WriteLine("Password contains password word");
                }

            }*/


            ////////////////////////////////////////////////////

            //Task 7 - Clean Name Comparator
            /*Console.WriteLine("Enter name : ");
            string name = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("Enter the same name : ");
            string sameName = Console.ReadLine().Trim().ToLower();
            if (name == sameName)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }*/

            ////////////////////////////////////////////////////

            //Task 8 - Membership Expiry Checker
            /*DateTime todayDate = DateTime.Today;
        
            Console.WriteLine("Enter membership start date as text (e.g. 2026-01-10)");
            DateTime startMembershipDate = DateTime.Parse(Console.ReadLine());
   
            Console.WriteLine("Enter valid membership days ");
            int validMembershipDays = int.Parse(Console.ReadLine());
            
            DateTime calExpireDate = startMembershipDate.AddDays(validMembershipDays);
            if (calExpireDate >= todayDate)
            {
                Console.WriteLine("Membership : Active");
            }
            else
            {
                Console.WriteLine("Membership : Expired at " + calExpireDate.ToString("yyyy-MM-dd"));
            }*/


            ////////////////////////////////////////////////////
            
            //Task 9 - Round Up / Round Down Explorer
            /*Console.WriteLine("Enter a decimal number ");
            double decimalNum = double.Parse(Console.ReadLine());
            double roundToNearstNum = Math.Round(decimalNum);
            double roundToUP = Math.Ceiling(decimalNum);
            double roundToDown = Math.Floor(decimalNum);
            Console.WriteLine("Rounded to the nearest whole\r\nnumber : " + roundToNearstNum);
            Console.WriteLine("Always rounded up : " + roundToUP);
            Console.WriteLine("Always rounded Down : " + roundToDown);*/

            ////////////////////////////////////////////////////
            
            //Task 10 - Word Position Finder



            ////////////////////////////////////////////////////
            //Task 11 - One-Time Password (OTP) Generator
            ////////////////////////////////////////////////////
            //Task 12 - Birthday Insights
            ////////////////////////////////////////////////////

        }
    }
}

