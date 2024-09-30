using System;
using System.ComponentModel;

namespace CLasswork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter Your Score: ");
            //int score = int.Parse(Console.ReadLine());

            //if (score <= 40 && score >=0)
            //{
            //    Console.WriteLine("Your Grade is: E.");
            //}
            //else if (score > 40 && score <= 49)
            //{
            //    Console.WriteLine("Your Grade is: D.");
            //}
            //else if (score >= 50 && score <= 59)
            //{
            //    Console.WriteLine("Your Grade is: C.");
            //}
            //else if (score > 60 && score <= 69)
            //{
            //    Console.WriteLine("Your Grade is: B.");
            //}
            //else if (score > 70)
            //{
            //    Console.WriteLine("Your Grade is: A.");
            //}
            //else if (score < 0)
            //{
            //    Console.WriteLine("Invalid Input.");
            //}

            //Console.Write("Enter Number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number < 0) 
            //{
            //    Console.WriteLine("The Number u av inputed is negative."); 
            //}
            //else if (number > 0)
            //{
            //    Console.WriteLine("The Number u av inputed is positive.");
            //}
            //else if (number == 0)
            //{
            //    Console.WriteLine("The Number u av inputed is Zero.");
            //}

            //Console.Write("Enter any number between 1 to 6: ");
            //int number = int.Parse(Console.ReadLine());

            //switch(number)
            //{
            //    case 1:
            //        Console.WriteLine("One.");
            //        break;
            //    case 2:
            //        Console.WriteLine("Two.");
            //        break;
            //    case 3:
            //        Console.WriteLine("Three.");
            //        break;
            //    case 4:
            //        Console.WriteLine("Four.");
            //        break;
            //    case 5:
            //        Console.WriteLine("Five.");
            //        break;
            //    case 6:
            //        Console.WriteLine("Six.");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Number.");
            //        break;

            //Console.Write("Enter number between 1 and 10: ");
            //int num = int.Parse(Console.ReadLine());    

            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("Its an odd number.");
            //        break;
            //    case 3:
            //        Console.WriteLine("Its an odd number.");
            //        break;
            //    case 5:
            //        Console.WriteLine("Its an odd number.");
            //        break;
            //    case 7:
            //        Console.WriteLine("Its an odd number.");
            //        break;
            //    case 9:
            //        Console.WriteLine("Its an odd number.");
            //        break;
            //    case 2:
            //        Console.WriteLine("Its an even number.");
            //        break;
            //    case 4:
            //        Console.WriteLine("Its an even number.");
            //        break;
            //    case 6:
            //        Console.WriteLine("Its an even number.");
            //        break;
            //    case 8:
            //        Console.WriteLine("Its an even number.");
            //        break;
            //    case 10:
            //        Console.WriteLine("Its an even number.");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Number.");
            //        break;

            //switch (num)
            //{
            //    case 2:
            //    case 4:
            //    case 6:
            //    case 8:
            //    case 10:
            //        Console.WriteLine("Its an even number.");
            //        break;
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 9:
            //    case 1:
            //        Console.WriteLine("Its an Odd number.");
            //        break;
            //}

            Console.Write("Enter Any Alphabet (A-Z): ");
            char alp = char.Parse(Console.ReadLine());

            alp = char.ToUpper(alp);

            switch(alp)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("Its a vowel alphabet.");
                    break;
                case 'Q':
                case 'W':
                case 'R':
                case 'T':
                case 'Y':
                case 'P':
                case 'S':
                case 'D':
                case 'F':
                case 'G':
                case 'H':
                case 'J':
                case 'K':
                case 'L':
                case 'Z':
                case 'X':
                case 'C':
                case 'V':
                case 'B':
                case 'N':
                case 'M':
                    Console.WriteLine("Its a consonant alphabet.");
                    break;
                default: 
                    Console.WriteLine("Invalid Input.");
                    break;

            }

            
            
        }
    }
}