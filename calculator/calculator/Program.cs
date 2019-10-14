using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // While variable menu equals true, the menu is displayed until something changes
            bool menu = true;
            while (menu)
            {
                menu = displayMenu();
            }

            // This function displays the menu and has a return type of bool
            static bool displayMenu()
            {
                // This clears the terminal screen when every time the menu is displayed
                Console.Clear();
                Console.WriteLine("This is a calculator to ADD, SUBTRACT, MULTIPLY, and DIVIDE 2 numbers.");
                Console.WriteLine("Enter 2 numbers that you want to calculate separate with a comma. (e.g. 1,2)");
                // Take user inputs of 2 numbers
                string input = Console.ReadLine();
                // Separate the 2 numbers by "," and store them into two variables 
                var numberData = input.Split(",");
                // Convert the number from string type to decimal type
                decimal num1 = decimal.Parse(numberData[0]);
                decimal num2 = decimal.Parse(numberData[1]);

                // Add some space between the number inputs from the menu
                Console.WriteLine("\n");
                // Here are the calculation options the users can choose
                Console.WriteLine("Now select what you want to do.");
                Console.WriteLine("1 Add");
                Console.WriteLine("2 Subtract");
                Console.WriteLine("3 Multiply");
                Console.WriteLine("4 Divide");
                // This terminates the program
                Console.WriteLine("0 Close the calculator");
                // Store the users selection of the calculation 
                var choose = Console.ReadLine();
                
                // Based on the option chosen, run the function accordingly
                if (choose == "1")
                {
                    Add(num1, num2);
                    return true;
                }
                else if (choose == "2")
                {
                    Subtract(num1, num2);
                    return true;
                }
                else if (choose == "3")
                {
                    Multiply(num1, num2);
                    return true;
                }
                else if (choose == "4")
                {
                    Divide(num1, num2);
                    return true;
                }
                // The users want to terminate the program, return false so the menu will not be displayed anymore
                else if (choose == "0")
                {
                    return false;
                }
                else
                {
                    // If the user types something other than what's available on the menu, this asks the user to reselect and goes back to the menu.
                    Console.WriteLine("Please select from one the of options available. Press Enter to go back to menu.");
                    Console.ReadLine();
                    return true;
                }
            }
        }
        // Here are all the calculation functions.
        private static void Add(decimal number1, decimal number2)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Add {0} and {1} together.", number1, number2);
            decimal result = number1 + number2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        private static void Subtract(decimal number1, decimal number2)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Subtract {0} from {1}.", number2, number1);
            decimal result = number1 - number2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        private static void Multiply(decimal number1, decimal number2)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Multiply {0} and {1}.", number1, number2);
            decimal result = number1 * number2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        private static void Divide(decimal number1, decimal number2)
        {
            Console.WriteLine("\n");
            Console.WriteLine("{0} divided by {1}.", number1, number2);
            decimal result = number1 / number2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
