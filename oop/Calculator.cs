using System;
using System.Globalization;

//Abstraction :3
//Will share the TERMINATE function
abstract class Terminator {

    //Method
    public void Terminate()
    {
        Console.WriteLine("\nCalculator Terminated!");
        Environment.Exit(0);
    }

}

//Inheritance :3
//The following subclasses inherits the TERMINATE function
class Input1 : Terminator
{


}

class Input2 : Terminator
{


}

class Input3 : Terminator
{
   

}

class Input4 : Terminator
{
   

}


class Calcu {
    static void Main(string[] args) { 
        Input1 term1 = new Input1();
        Input2 term2 = new Input2();
        Input3 term3 = new Input3();
        Input4 term4 = new Input4();
        while (true)
        {
        //Phase 1:
        Console.Write("\nEnter a number                : ");
        string input1 = Console.ReadLine();

        if (!double.TryParse(input1, out _))
        {
            //Failed phase 1
            Console.Write("\nYou must enter a number ");
            term1.Terminate();
        }

        //Continue to phase 2
        else {
            Console.Write("Enter an operator (+,-,*,/)   : ");
        }

        //Phase 2:
        string input2 = Console.ReadLine();

        if (input2 != "+" && input2 != "-" && input2 != "*" && input2 != "/")
        {
            //Failed phase 2
            Console.Write("\nYou must enter one of the given operators ");
            term2.Terminate();
        }

        //Continue to phase 3
        else
        {
            char char1 = Convert.ToChar(input2);
        }
        
        Console.Write("Enter another number          : ");
        string input3 = Console.ReadLine();
         if (!double.TryParse(input3, out _))
        {
            //Failed phase 3
            Console.Write("\n\n\nYou must enter a number ");
            term1.Terminate();
        }

        //Continue to last phase
        else {
            Console.Write("\n\nResult                        : ");
        }

        //Last Phase
        //Calculation part
            switch(input2)
            {
                case "+":
                double num1 = Convert.ToDouble(input1);
                double num2 = Convert.ToDouble(input3);
                Console.WriteLine(num1 + num2);
                break;

                case "-":
                double num3 = Convert.ToDouble(input1);
                double num4 = Convert.ToDouble(input3);
                Console.WriteLine(num3 - num4);
                break;

                case "*":
                double num5 = Convert.ToDouble(input1);
                double num6 = Convert.ToDouble(input3);
                Console.WriteLine(num5 * num6);
                break;

                case "/":
                double num7 = Convert.ToDouble(input1);
                double num8 = Convert.ToDouble(input3);
                Console.WriteLine(num7 / num8);
                break;


            }
    
            //Start again phase
            Console.Write("\n\n\nDo you want to try again?: ");
            string choice = Console.ReadLine();

            if (choice.ToLower() != "yes" && choice.ToLower() != "Yes" && choice.ToLower() != "YES" && choice.ToLower() != "YEs" && choice.ToLower() != "YeS" && choice.ToLower() != "yES" && choice.ToLower() != "yeS")
                term4.Terminate();

            else {
                Console.WriteLine("\n\n\n");
            }
            }
        }
    }

        



    

