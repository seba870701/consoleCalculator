using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculator.InputValidator;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Console calculator";
            Console.WriteLine("This is an arithmetic claculator for console commands");
            Console.WriteLine("Type 'HELP' to get the list of commands available");
            Console.WriteLine("Type 'START' to start the calculation");
            Console.WriteLine("To exit at any time type 'EXIT' command");
            string cmd;

            do
            {
                Console.Write(":>");
                cmd = Console.ReadLine().ToUpper();     //make input as case insensitive 

                switch (cmd)
                {
                    case "HELP":                        //help command case here 
                        PrintAvailableCommands();
                        break;
                    case "EXIT":                        //exit command case here 
                        Environment.Exit(0);
                        break;
                    case "START":                       //start command case here 
                    {
                        MathematicalDataContainer data = GetUserInput();    // get user input

                            if (data.CorrrectInput) 
                            {
                                if (data.MathOperation == "ADD")
                                {
                                    data.Result = Calculations.Add(data.FirstNumber, data.SecondNumber);
                                }
                                else if (data.MathOperation == "SUB")
                                {
                                    data.Result = Calculations.Subtract(data.FirstNumber, data.SecondNumber);
                                }
                                else if (data.MathOperation == "MUL")
                                {
                                    data.Result = Calculations.Multiply(data.FirstNumber, data.SecondNumber);
                                }
                                else if (data.MathOperation == "DIV")
                                {
                                    if (data.SecondNumber == 0)
                                    {
                                        PrintErrorMessage("Division by zero is not allowed!!");
                                        break;
                                    }
                                    else
                                    {
                                        data.Result = Calculations.Divide(data.FirstNumber, data.SecondNumber);
                                    }
                                }
                                Console.WriteLine($"The result of the operation is: {data.Result}.");        // print results of the calculation
                            }
                            else
                            {
                                PrintErrorMessage("Error!! Incorrect input!!");                           // error message for failed input validation 
                            }
                            break;
                        }
                    case "CLS":                                 //clear screen command case 
                        Console.Clear();
                        break;
                    default:
                        PrintErrorMessage("Bad command!!");      //default wrong command message 
                        break;
                }
            }
            while (cmd.ToUpper() != "EXIT");    //run the screen till exit command typed 
        }

        private static MathematicalDataContainer GetUserInput()
        {
            MathematicalDataContainer data = new MathematicalDataContainer();

            Console.WriteLine("Enter the first number:");
            Console.Write(":>");
            string n1 = Console.ReadLine();                     //input for the 1st number

            Console.WriteLine("Choose maths operation.");
            Console.Write(":>");
            string operation = Console.ReadLine().ToUpper();    //input for the maths operation

            Console.WriteLine("Enter the second number:");      
            Console.Write(":>");
            string n2 = Console.ReadLine();                     //input for the 2nd number

            if (IsInputValid(n1) && IsInputValid(n2) && IsOperationValid(operation))    // input validation
            {
                data.FirstNumber = double.Parse(n1);
                data.SecondNumber = double.Parse(n2);
                data.MathOperation = operation;
                data.CorrrectInput = true;
            }
            else
            {
                data.CorrrectInput = false;
            }
            return data;
        }

        private static MathematicalDataContainer GetUserInputInLoop()
        {
            MathematicalDataContainer data = new MathematicalDataContainer();
            bool end = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Theoperation will be performed on the following numbers: ");
                foreach (var number in data.Numbers)
                {
                    Console.Write(number + "   ");
                }
                Console.WriteLine("Enter the number to be used in calculations. If you want to perform the operation, type 'END'.");
                Console.Write(":>");
                string n = Console.ReadLine(); //input numbers
                if (n == "end")
                {
                    end = true;
                }
                else
                {
                    if (IsInputValid(n))                            // input validation
                    {
                        data.Numbers.Add(double.Parse(n));
                    }
                    else
                    {
                        data.CorrrectInput = false;
                    }
                }
            } while (end == false);

            Console.WriteLine("Choose maths operation.");
            Console.Write(":>");
            string operation = Console.ReadLine().ToUpper();        //input for the maths operation

            if (data.CorrrectInput && IsOperationValid(operation))    // input validation
            {
                data.MathOperation = operation;
                data.CorrrectInput = true;
            }
            else
            {
                data.CorrrectInput = false;
            }
            return data;
        }

        private static void PrintAvailableCommands()
        {
            Console.Clear();
            StringBuilder sb = new StringBuilder();
            sb.Append("Available commands:\n");
            sb.Append("start: \t Starts Calculator\n");
            sb.Append("exit: \t Exits Calculator\n");
            sb.Append("cls: \t Clears the Screen\n");

            sb.Append("add: \t Addition\n");
            sb.Append("sub: \t Subtraction\n");
            sb.Append("mul: \t Multiplication\n");
            sb.Append("div: \t Division\n");
            Console.WriteLine(sb.ToString());
        }

        private static void PrintErrorMessage(string errorMessage)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ForegroundColor = currentColor;
        }
    }
}
