using System;

namespace switchCLS
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Console.Write("Enter number to print day of the week: ");
            //int dayNo = int.Parse(Console.ReadLine());  
            //switch (dayNo)
            //{
            //    case 1:
            //        Console.WriteLine("Sunday."); goto case 2;

            //    case 2:
            //        Console.WriteLine("Monday."); goto case 3;

            //    case 3:
            //        Console.WriteLine("Tuesday."); goto case 4;

            //    case 4:
            //        Console.WriteLine("Wednesday."); goto case 5;

            //    case 5:
            //        Console.WriteLine("Thursday."); goto case 6;

            //    case 6:
            //        Console.WriteLine("Friday.");
            //        goto case 7;

            //    case 7:
            //        Console.WriteLine("Saturday.");
            //        break;

            //    default: 
            //        Console.WriteLine("Invalid Input.");
            //        break;
            //}

            Console.Write("Enter character (a or b) --> ");
            char character = char.Parse(Console.ReadLine());
            character = char.ToLower(character);    
            int count = 0;

            switch(character) 
            {
                case 'a':
                    Console.WriteLine("You have entered A");
                    break;
                case 'b':
                    Console.WriteLine("You have entered B");
                    break;
                default: 
                    Console.WriteLine("Invalid Input.");

                    if (count == 3)
                    {
                        Environment.Exit(0);
                    }

                    Console.Write("Enter character (a or b) --> ");
                    character = char.Parse(Console.ReadLine());
                    character = char.ToLower(character);
                    count++;

                    if (character == 'a')
                    {
                        goto case 'a';
                    }
                    if (character == 'b')
                    {
                        goto case 'b';
                    }
                    else
                    {
                        goto default;

                    }

            }
        }
    }
}