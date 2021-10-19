using System;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------ 1 ------------------------");
            Console.WriteLine(" Write your word !");

            int a = 0, o = 0, i = 0, e = 0;

            string word = Console.ReadLine();

            for (int j = 0; j < word.Length; j++)
            {
                switch (word[j])
                {
                    case 'a':
                        a++;
                        break;

                    case 'o':
                        o++;
                        break;

                    case 'i':
                        i++;
                        break;

                    case 'e':
                        e++;
                        break;
                }
            }
            Console.WriteLine("A = " + a + ", O = " + o + ", I = " + i + ", E = " + e);

            Console.WriteLine("------------------------ 2 ------------------------");
            int numbOfMonth;
            do
            {
                 Console.WriteLine(" Enter your number of Month !");
                 numbOfMonth = int.Parse(Console.ReadLine());

                switch (numbOfMonth)
                {
                    case 1:
                        Console.WriteLine(" January 31");
                        break;

                    case 2:
                        Console.WriteLine(" February 29");
                        break;

                    case 3:
                        Console.WriteLine(" March 31");
                        break;

                    case 4:
                        Console.WriteLine(" April 30");
                        break;

                    case 5:
                        Console.WriteLine(" May 31");
                        break;
                    case 6:
                        Console.WriteLine(" June 30");
                        break;

                    case 7:
                        Console.WriteLine(" July 31");
                        break;

                    case 8:
                        Console.WriteLine(" August 31");
                        break;

                    case 9:
                        Console.WriteLine(" September 30");
                        break;

                    case 10:
                        Console.WriteLine(" October 31");
                        break;

                    case 11:
                        Console.WriteLine(" November 30");
                        break;

                    case 12:
                        Console.WriteLine(" December 31");
                        break;
                }

            } while (numbOfMonth < 1 || numbOfMonth > 12);

            Console.WriteLine("------------------------ 3 ------------------------");

            int[] myArray = new int[10];
            int sum = 0;
            int product = 1;

            for (int ind = 0; ind < myArray.Length; ind++)
            {
                Console.WriteLine($"\n Input element {ind}:\t");
                myArray[ind] = int.Parse(Console.ReadLine());
            }
            for (int k = 0; k < myArray.Length /2; k++)
            {
                if (myArray[k] > 0)
                {
                   sum += myArray[k];
                }
                else
                {
                    sum = 0;
                    Console.WriteLine("  First 5 elements aren`t positive ");
                    break;
                }
            }
            if (sum == 0 )
            {
                for (int l = myArray.Length /2; l < myArray.Length; l++)
                {
                    product *= myArray[l];
                }
            }
            if (sum == 0)
            {
                Console.WriteLine(" Product = " + product);
            }
            else
            {
                Console.WriteLine(" Sum = " + sum);
            }
           
            Console.ReadKey();
        }
    }
}
