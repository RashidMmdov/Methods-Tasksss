using System;

namespace CalcTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Operator: ");
            char opperatorr = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n-----------------------\n");
            Console.Write("Result: ");

            calcProsses(firstNum, secondNum, opperatorr);
        }
        public static void calcProsses(double num1,double num2,char opp)
        {
            double total = 0;
            if(opp == '+')
            {
                total = num1 + num2;
                Console.WriteLine(total);

            }else if(opp == '-')
            {
                total = num1 - num2;
                Console.WriteLine(total);

            }else if (opp == '*')
            {
                total = num1 * num2;
                Console.WriteLine(total);

            }
            else if (opp == '/')
            {
                total = num1 / num2;
                Console.WriteLine(total);
            }
        }
    }   
}
