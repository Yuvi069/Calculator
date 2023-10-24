using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string displayMenu = "BackToFunctionMenu";
            while (displayMenu != "Exit")
            {
                if (displayMenu == "BackToFunctionMenu")
                {
                    displayMenu = FunctionMenu();
                }
                else if (displayMenu == "BackToAdditionMenu")
                {
                    displayMenu = Addition();
                }
                else if (displayMenu == "GoingBackToAddition")
                {
                    displayMenu = BackToAddition();
                }
                else if (displayMenu == "BackToSubtractionMenu")
                {
                    displayMenu = Subtraction();
                }
                else if (displayMenu == "GoingBackToSubtraction")
                {
                    displayMenu = BackToSubtraction();
                }
                else if (displayMenu == "GoingBackToMultiplication")
                {
                    displayMenu = BackToMultiplication();
                }
                else if (displayMenu == "BackToMultiplicationMenu")
                {
                    displayMenu = Multiplication();
                }
                else if (displayMenu == "GoingBackToDivision")
                {
                    displayMenu = BackToDivision();
                }
                else if (displayMenu == "BackToDivisionMenu")
                {
                    displayMenu = Division();
                }
                else if (displayMenu == "GoingBackToPercentage")
                {
                    displayMenu = BackToPercentage();
                }
                else if (displayMenu == "BackToPercentageMenu")
                {
                    displayMenu = Percentage();
                }


            }

            Console.WriteLine("Thanks for using my calculator");


        }

        public static string FunctionMenu()
        {
            Console.Clear();
            Console.WriteLine("Functions:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Percentage");
            Console.WriteLine("6. Powers");
            Console.WriteLine("0. Exit");
            Console.WriteLine("");
            Console.Write("Choose your function: ");
            string result = Console.ReadLine();

            if (result == "1")
            {
                Addition();
                return "GoingBackToAddition";
            }
            else if (result == "2")
            {
                Subtraction();
                return "GoingBackToSubtraction";
            }
            else if (result == "3")
            {
                Multiplication();
                return "GoingBackToMultiplication";
            }
            else if (result == "4")
            {
                Division();
                return "GoingBackToDivision";
            }
            else if (result == "5")
            {
                Percentage();
                return "GoingBackToPercentage";
            }
            else if (result == "0")
                return "Exit";
            else
            {
                Console.WriteLine("Please enter a valid input");
                Console.ReadLine();
                return "BackToFunctionMenu";
            }
        }

        public static string Subtraction()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Subtraction!!");
            Console.WriteLine("---------------------------------");

            Console.Write("Type your 1st number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Type your 2st number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 - num2;
            Console.WriteLine("Your sum is:" + sum);
            Console.ReadLine();

            return "GoingBackToSubtraction";

        }


        static string BackToSubtraction()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Functions:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Continue Subtracting");
            Console.WriteLine("2. Return to Main Menu");
            Console.Write("Choose your function:");
            string subtractionContinueJump = Console.ReadLine();
            if (subtractionContinueJump == "1")
                return "BackToSubtractionMenu";
            else if (subtractionContinueJump == "2")
                return "BackToFunctionMenu";
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                Console.ReadLine();
                return "GoingBackToSubtraction";
            }
        }



        public static string Addition()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Addition!!");
            Console.WriteLine("---------------------------------");

            Console.Write("Type your 1st number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Type your 2st number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            Console.WriteLine("Your sum is:" + sum);
            Console.ReadLine();

            return "GoingBackToAddition";

        }


        static string BackToAddition()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Functions:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Continue Adding");
            Console.WriteLine("2. Return to Main Menu");
            Console.Write("Choose your function:");
            string additionContinueJump = Console.ReadLine();
            if (additionContinueJump == "1")
                return "BackToAdditionMenu";
            else if (additionContinueJump == "2")
                return "BackToFunctionMenu";
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                Console.ReadLine();
                return "GoingBackToAddition";
            }
        }

        public static string Multiplication()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Multiplication!!");
            Console.WriteLine("---------------------------------");

            Console.Write("Type your 1st number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Type your 2st number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double mul = num1 * num2;
            Console.WriteLine("Your sum is:" + mul);
            Console.ReadLine();

            return "GoingBackToMultiplication";

        }


        static string BackToMultiplication()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Functions:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Continue Multiplying");
            Console.WriteLine("2. Return to Main Menu");
            Console.Write("Choose your function:");
            string multiplicationContinueJump = Console.ReadLine();
            if (multiplicationContinueJump == "1")
                return "BackToMultiplicationMenu";
            else if (multiplicationContinueJump == "2")
                return "BackToFunctionMenu";
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                Console.ReadLine();
                return "GoingBackToMultiplication";
            }
        }

        public static string Division()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Division!!");
            Console.WriteLine("---------------------------------");

            Console.Write("Type your numerator:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Type your denominator:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double div = num1 / num2;
            Console.WriteLine("Your sum is:" + div);
            Console.ReadLine();

            return "GoingBackToDivision";

        }


        static string BackToDivision()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Functions:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Continue Division");
            Console.WriteLine("2. Return to Main Menu");
            Console.Write("Choose your function:");
            string divisionContinueJump = Console.ReadLine();
            if (divisionContinueJump == "1")
                return "BackToDivisionMenu";
            else if (divisionContinueJump == "2")
                return "BackToFunctionMenu";
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                Console.ReadLine();
                return "GoingBackToDivision";
            }

        }

        public static string Percentage()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Percentage!!");
            Console.WriteLine("---------------------------------");

            Console.Write("Total:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Value:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double percen = num2/num1 * 100;
            Console.WriteLine("Your percentage is: " + percen +"%");
            Console.ReadLine();

            return "GoingBackToPercentage";

        }


        static string BackToPercentage()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Functions:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Continue Percentage");
            Console.WriteLine("2. Return to Main Menu");
            Console.Write("Choose your function:");
            string percentageContinueJump = Console.ReadLine();
            if (percentageContinueJump == "1")
                return "BackToPercentageMenu";
            else if (percentageContinueJump == "2")
                return "BackToFunctionMenu";
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                Console.ReadLine();
                return "GoingBackToPercentage";
            }

        }
    }
            
}

   