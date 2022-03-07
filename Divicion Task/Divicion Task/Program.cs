using System;

namespace Divicion_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 7 == 0)
            {
                Console.WriteLine("7 ye bolunur");

            }
            else
            {
                Console.WriteLine(DivProsess(number));
            }
           
        }
        public static int DivProsess(int num)
        {
            int little = 0, big = 0;
            int count1 = 0, count2 = 0;

                big = findBigNum(num, big);
                little = findLittleNum(num, little);


                for (int i = little; i < num; i++)
                {
                    count1++;
                }
                for (int i = big; i > num; i--)
                {
                    count2++;
                }
                 if (count1 < count2)
                 {
                     return little;
                 }
                 else
                 {
                     return big;
                 }

        }





        public static int findLittleNum(int num ,int Lnum)
        {
            for (int i = num; i > 0; i--)
            {
                if (i % 7 == 0)
                {
                    Lnum = i;
                    break;
                }
            }
            return Lnum;
        }
        public static int findBigNum(int num, int Bnum)
        {
            for (int i = num; i < num * i; i++)
            {
                if (i % 7 == 0)
                {
                    Bnum = i;
                    break;
                }
            }
            return Bnum;
        }
    }
}
