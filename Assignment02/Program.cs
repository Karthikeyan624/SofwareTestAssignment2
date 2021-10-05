// Author : Karthikeyan Shanmugam
// Student Number : 8740880
// Class : Cad Section1
using System;

namespace Assignment02
{
    class Program
    {
        // Method for showing the menu options
        public static int ValidateMenuSelection()
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)
            {
                Console.WriteLine("1 = Enter Rectangle length");
                Console.WriteLine("2 = Change Rectangle length");
                Console.WriteLine("3 = Enter Rectangle width");
                Console.WriteLine("4 = Change Rectangle width");
                Console.WriteLine("5 = Enter Rectangle height");
                Console.WriteLine("6 = Change Rectangle height");
                Console.WriteLine("7 = Calculate Rectangle volume");
                Console.WriteLine("8 = Exit\n");

                Console.WriteLine("Please select the number from above menu to enter or calculate rectangle volume\n");
                userInput = Console.ReadLine();

                if (userInput != "1" &&
                    userInput != "2" &&
                    userInput != "3" &&
                    userInput != "4" &&
                    userInput != "5" &&
                    userInput != "6" &&
                    userInput != "7" &&
                    userInput != "8")
                {
                    Console.WriteLine("Not a valid menu option, please try again:\n");
                }
                else
                {
                    validMenuSelect = true;
                }
            }
            Console.WriteLine();
            return int.Parse(userInput);
        }

        // Validating the user input
        public static int ValidateUserInput(string chosenNumber)
        {
            int aNumber = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {chosenNumber}:");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out aNumber);

                if (result == false)
                {
                    Console.WriteLine("Not a valid input please, please try again.\n");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"Your {chosenNumber} has been changed to: {aNumber}.\n");
                }
            }

            return aNumber;
        }

        // Main method for getting user inputs and calculating volume of rectangle
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            bool validRectSelect = false;
            string rectSelection;
            int selection;

            while (validRectSelect == false)
            {
                Console.WriteLine("Press 1 and then enter to continue to application");
                rectSelection = Console.ReadLine();
                Console.WriteLine();
                ValidateMenuSelection();

                if (rectSelection != "1")
                {
                    Console.WriteLine("Not a valid selection, please try again.\n");
                }

                else if (int.Parse(rectSelection) == 1)
                {
                    validRectSelect = true;

                    int length;
                    int width;
                    int height;

                    length = ValidateUserInput("length");
                    width = ValidateUserInput("width");
                    height = ValidateUserInput("height");

                    Console.WriteLine($"Your attributes are length = {length} , width = {width} and height = {height}.\n");
                    Rectangle customRect = new Rectangle(length, width, height); // creating object for the class
                    r = customRect;
                }
            }

            selection = ValidateMenuSelection();

            while (selection != 8)
            {
                int result;

                switch (selection)
                {
                    case 1:
                        Console.WriteLine($"Length is: {r.GetLength()}\n");
                        break;
                    case 2:
                        result = ValidateUserInput("length");
                        r.SetLength(result);
                        break;
                    case 3:
                        Console.WriteLine($"Width is: {r.GetWidth()}\n");
                        break;
                    case 4:
                        result = ValidateUserInput("width");
                        r.SetWidth(result);
                        break;
                    case 5:
                        Console.WriteLine($"Height is: {r.GetHeight()}\n");
                        break;
                    case 6:
                        result = ValidateUserInput("height");
                        r.SetHeight(result);
                        break;
                    case 7:
                        Console.WriteLine($"The Volume of Rectangle is: {r.GetVolume()}\n");
                        break;
                    default:
                        break;
                }

                selection = ValidateMenuSelection();

            }
        }
    }
}
