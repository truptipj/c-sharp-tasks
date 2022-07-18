using System;

namespace Assignment_one
{
    class Program
    {
        static void Main(string[] args)
        {
            //if statement
            if (20 > 10)
            {
                Console.WriteLine("if statement:- 20 is greater than 10" + "\n");
            }

            //if else statement
            int num = 10;
            if (num > 20)
            {
                Console.WriteLine("if else statement:- 10 is greater" + "\n");
            }
            else
            {
                Console.WriteLine("if else statement:- 20 is greater" + "\n");
            }

            //if else if statement
            int a = 10;
            int b = 20;
            int c = 30;
            if (a > b && a > c)
            {
                Console.WriteLine("if else if statement:- a is greater" + "\n");
            } 
            else if (b > a && b > c)
            {
                Console.WriteLine("if else if statement:- b is greater" + "\n");
            } 
            else if (c > a && c > b)
            {
                Console.WriteLine("if else if statement:- c is greater" + "\n");
            }

            //switch statement
            string month = "three";
            switch (month)
            {
                case "one":
                    Console.WriteLine("switch statement:- It is Jan" + "\n");
                        break;
                case "two":
                    Console.WriteLine("switch statement:- It is Feb" + "\n");
                    break;
                case "three":
                    Console.WriteLine("switch statement:- It is March" + "\n");
                    break;
                case "four":
                    Console.WriteLine("switch statement:- It is April" + "\n");
                    break;
            }

            //switch (default) statement
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("switch (default) statement:- It is Monday" + "\n");
                    break;
                case 2:
                    Console.WriteLine("switch (default) statement:- It is Tuesday" + "\n");
                    break;
                default:
                    Console.WriteLine("switch (default) statement:- Another Day" + "\n");
                    break;
            }

            //while loop
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("while loop:-" + i + "\n");
                i++;
            }

            //do while 
            int j = 0;
            do
            {
                Console.WriteLine("do while:-" + i + "\n");
                j++;
            }
            while (j < 5);

            //for loop
            for (int x = 0; x < 5; x += 2)
            {
                Console.WriteLine("for loop:-" + x + "\n");
            }
            //for each loop
            string[] fruits = { "grapes", "mango", "banana" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine("for each loop:-" + fruit + "\n");
            }
                //break statement
                for (int y = 0; y < 7; y++)
            {
                if (y == 4)
                {
                    break;
                }
                Console.WriteLine("break statement:-" + y + "\n");
            }
            //continue statement
            for (int w = 0; w < 7; w++)
            {
                if (w == 4)
                {
                    continue;
                }
                Console.WriteLine("continue statement:-" + w + "\n");
            }

          
        }
    }
}
