using System;

namespace Calculator
{
    public static class Calculator_
    {
        static void old(string[] args)
        //variable declarations
        {
            char op;
            bool runCalc = true;
            double num1, num2;

            while (runCalc)
            {
                Console.WriteLine("Enter the Operator( +,-,*,/ )");
                op = Console.ReadLine()[0];

                Console.WriteLine("Enter the two numbers one by one");
                num1 = Convert.ToDouble(Console.ReadLine());
                num2 = Convert.ToDouble(Console.ReadLine());

                switch (op)
                {
                    case '+':
                        add(num1, num2);
                        break;

                    case '-':
                        sub(num1, num2);
                        break;

                    case '*':
                        mult(num1, num2);
                        break;

                    case '/':
                        div(num1, num2);
                        break;

                }
                runCalc = run();
            }
        }

        //Addition
        public static double add(double num1, double num2)
        {
            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
            return (num1 + num2);
        }

        //Subtraction
        public static double sub(double num1, double num2)
        {
            Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
            return (num1 - num2);
        }
        //Multiplication
        public static double mult(double num1, double num2)
        {
            Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1 * num2));
            return (num1 * num2);
        }
        //Division
        public static double div(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Divide by zero not possible");
                return 0;
            }
            else
            {
                Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));
                return (num1 / num2);
            }
        }

        //continue?
        static bool run()
        {
            Console.WriteLine("press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("do you wish to perform a new calculation? (yes/no)");
            string input = Console.ReadLine().ToLower();
            while (input != "yes" && input != "no")
            {
                Console.WriteLine("What you had input was not a yes or a no, please input an accepted answer.");
                input = Console.ReadLine().ToLower();
            }
            if (input == "yes") return true;
            return false;
        }

    }
}