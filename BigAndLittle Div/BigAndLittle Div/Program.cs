using System;

namespace BigAndLittle_Div
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(searchDiv(number));
            
            
        }
        public static int searchDiv(int num)
        {
            int tempValue = 0;
            if (num < 50)
            {
                tempValue = 3;
                Searching(num, tempValue);
            }else if(num >= 50 && num < 100)
            {
                tempValue = 5;
                Searching(num, tempValue);
            }
            else if (num >= 100)
            {
                tempValue = 8;
                Searching(num, tempValue);

            }
            return Searching(num,tempValue);
            
        }
        public static int Searching(int num,int value)
        {
            
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % value == 0)
                {
                    
                    count++;
                }
            }
            return count;
        }
    }
}