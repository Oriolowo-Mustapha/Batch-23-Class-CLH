using System;
using System.Transactions;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 2

            // 1.
            //ushort value1 = 52130;
            //sbyte value2 = -115;
            //int value3 = 4825932;
            //byte value4 = 97;
            //short value5 = -10000;
            //short value6 = 20000;
            //byte value7 = 224;
            //int value8 = 970700000;
            //byte value9 = 112;
            //sbyte value10 = -44;
            //int value11 = -1000000;
            //short value12 = 1990;
            //ulong value13 = 123456789123456789;

            // 2.
            //float num1 = 5;
            //double num2 = -5.01;
            //double num3 = 12.345;
            //double num4 = 34.567839023;
            //double num5 = 8923.1234857;
            //double num6 = 3456.091124875956542151256683467;

            // 4.
            //Int16 num1 = 100;
            //Console.WriteLine(num1);

            // 6.
            //bool isMale = true;

            //string hello = "Hello";
            //string wrld = "World.";

            //object helWrld = hello + " " + wrld;
            //Console.WriteLine(helWrld); 

            // 7.
            //string hello = "Hello";
            //string wrld = "World.";

            //object helWrld = hello + " " + wrld;
            //Console.WriteLine(helWrld);

            //string thirdVariable = hello + " " + wrld;
            //Console.WriteLine(thirdVariable);

            // 10.
            //Console.WriteLine("  oooooo   oooooo");
            //Console.WriteLine("  o      o      o");
            //Console.WriteLine(" o               o");
            //Console.WriteLine("  o             o");
            //Console.WriteLine("   o           o");
            //Console.WriteLine("    o         o");
            //Console.WriteLine("     o       o");
            //Console.WriteLine("      o     o");
            //Console.WriteLine("       o   o");
            //Console.WriteLine("        o o");

            // 11.
            //Console.WriteLine("©©©");
            //Console.WriteLine("©  ©");
            //Console.WriteLine("©   ©");
            //Console.WriteLine("©    ©");
            //Console.WriteLine("©     ©");
            //Console.WriteLine("©      ©");
            //Console.WriteLine("©       ©");
            //Console.WriteLine("©        ©");
            //Console.WriteLine("©         ©");
            //Console.WriteLine("©          ©");
            //Console.WriteLine("©           ©");
            //Console.WriteLine("©            ©");
            //Console.WriteLine("©©©©©©©©©©©©©©©");

            // 12.
            //string firstName = "Employee First Name";
            //string lastName = "Employee Last Name";
            //int age = 23;
            //string gender = "Male or Female";
            //int employeeNumber = 27774774;

            // 13.
            //int num1 = 5;
            //int num2 = 10;

            //num1 = num1 + num2;
            //num2 = num1 - num2;
            //num1 = num1 - num2;

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            // Chapter 3
            //1.
            //int num = 5;
            //Console.WriteLine(num == 0 ? "The number is 0": num % 2 == 0 ? "Its Even." : "Its Odd.");

            //2. 
            //int num = 35;
            //int check1 = num % 7;
            //int check2 = num % 5;

            //Console.WriteLine(check1 == check2);  

            //3.
            //int num = 447;
            //int thirdDigit = num % 10; 
            //Console.WriteLine(thirdDigit == 7 ? "It is seven" : "It is not");

            //5. 
            //double a = 4;
            //double b = 5;
            //double h = 6;

            //double area  = 0.5 * (a + b) * h;
            //Console.WriteLine(area);

            //6. 
            //int l = 2;
            //int b = 3;

            //int area = l * b;
            //int perimeter = 2 *(l  + b);

            //Console.WriteLine("Area: " + area);
            //Console.WriteLine("Perimeter: " + perimeter);

            // 8.
            //Console.Write("Enter Weight: ");
            //double weight = double.Parse(Console.ReadLine()); // weight  = mass * acceleration due to gravity

            //double weightOnEarth = weight * 9.8;
            //double weightOnMoon = 0.17 * weightOnEarth;

            //Console.WriteLine($"Weight Of Man On Moon: {weightOnMoon}");

            // 10.
            //Console.Write("Enter Number: ");
            //int number = int.Parse(Console.ReadLine());

            //int holder1 = number % 1000;
            //int holder2 = holder1 % 100;
            //int firstDigit = number / 1000;
            //int secondDigit = holder1 / 100;
            //int thirdDigit = holder2 / 10;
            //int lastDigit = number % 10;

            //int addDigit = firstDigit + secondDigit + thirdDigit + lastDigit;
            //Console.Write(addDigit);



            // Chapter 4
            // 1.
            //Console.Write("Enter First Number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter Second Number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter Third Number: ");
            //int num3 = int.Parse(Console.ReadLine());

            //int sum = num1 + num2 + num3;
            //Console.WriteLine($"Sum of the three numbers provided is: {sum}");

            // 2.
            //Console.Write("Radius: ");
            //double radius = double.Parse(Console.ReadLine());   

            //double perimeter  = 2 * 3.19 * radius;
            //double area = 3.12 * radius * radius;

            //Console.WriteLine($"Perimeter: {perimeter}");
            //Console.WriteLine($"Area: {area}");

            // 3.
            //Console.Write("Enter Company name: ");
            //string compName = Console.ReadLine();

            //Console.Write("Enter Company Address: ");
            //string compAddress = Console.ReadLine();

            //Console.Write("Enter Company Phone Number: ");
            //int compPhone = int.Parse(Console.ReadLine());

            //Console.Write("Enter Company Fax Number: ");
            //int compFax = int.Parse(Console.ReadLine());

            //Console.Write("Enter Company Web Address: ");
            //string compWebdress = Console.ReadLine();

            //Console.Write("Enter Manager Surname: ");
            //string manSurname = Console.ReadLine();

            //Console.Write("Enter Manager name: ");
            //string manName = Console.ReadLine();

            //Console.Write("Enter Manager Phone Number: ");
            //int manPhone = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Company Name: {compName}");
            //Console.WriteLine($"Company Address: {compAddress}");
            //Console.WriteLine($"Company Phone Number: {compPhone}");
            //Console.WriteLine($"Company Fax Number: {compFax}");
            //Console.WriteLine($"Company Web Address: {compWebdress}");
            //Console.WriteLine($"Manager Surname: {manSurname}");    
            //Console.WriteLine($"Manager name: {manName}");
            //Console.WriteLine($"Manager Phone Number {manPhone}");


            // 4.
            //Int16 num1 = 32;
            //int num2 = 5 / 7;
            //double num3 = -2.34;

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);    
            //Console.WriteLine(num3);    

            // 5. 
            //Console.Write("Enter integer 1: ");
            //int integer1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter integer 2: ");
            //int integer2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(integer1 == integer2 ? "They are equal.": integer1 > integer2 ? $"{integer1} is the greatest": $"{integer2} is the greatest.");

            // 7.
            //Console.Write("Enter integer 1: ");
            //int integer1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter integer 2: ");
            //int integer2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter integer 3: ");
            //int integer3 = int.Parse(Console.ReadLine());
            //Console.Write("Enter integer 4: ");
            //int integer4 = int.Parse(Console.ReadLine());
            //Console.Write("Enter integer 5: ");
            //int integer5 = int.Parse(Console.ReadLine());

            //int sum = integer1 + integer2 + integer3 + integer4 + integer5;
            //Console.WriteLine($"Sum of the five integer = {sum}");

            // 8.
            //Console.Write("Enter integer 1: ");
            //int integer1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter integer 2: ");
            //int integer2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter integer 3: ");
            //int integer3 = int.Parse(Console.ReadLine());
            //Console.Write("Enter integer 4: ");
            //int integer4 = int.Parse(Console.ReadLine());
            //Console.Write("Enter integer 5: ");
            //int integer5 = int.Parse(Console.ReadLine());

            //int greatest = Math.Max(integer1, Math.Max(integer2, Math.Max(integer3, Math.Max(integer4,integer5))));
            //Console.WriteLine($"Greatest Number among the  you av provided is: {greatest}");

            // 9.
            //Console.Write("Enter Number: ");
            //int num = int.Parse(Console.ReadLine());

            //int sum = num + num;
            //Console.WriteLine($"Sum = {sum}");

            // Chapter 5
            // 1.
            //Console.Write("Enter First Number: ");
            //int variable1  = int.Parse(Console.ReadLine());

            //Console.Write("Enter Second Number: ");
            //int variable2 = int.Parse(Console.ReadLine());

            //if (variable1 > variable2) 
            //{
            //    variable1 = variable1 + variable2;
            //    variable2 = variable1 - variable2;
            //    variable1 = variable1 - variable2;

            //    Console.WriteLine($"First Variable = {variable1}");
            //    Console.WriteLine($"Second Variable = {variable2}");
            //}

            // 3.
            //Console.Write("Enter First Number: ");
            //int variable1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter Second Number: ");
            //int variable2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter Third Number: ");
            //int variable3 = int.Parse(Console.ReadLine());

            //if (variable1 > variable2 && variable1 > variable3)
            //{
            //    Console.WriteLine($"{variable1} is the greatest.");
            //}
            //else if (variable2 > variable1 && variable2 > variable3)
            //{
            //    Console.WriteLine($"{variable2} is the greatest.");
            //}
            //else if (variable3 > variable1 && variable3 > variable2)
            //{
            //    Console.WriteLine($"{variable3} is the greatest.");
            //}
            //else if(variable1 ==  variable2 || variable1 == variable3)
            //{
            //    Console.WriteLine("Two of them are equal.");
            //}
            //else if (variable2 == variable1 || variable2 == variable3)
            //{
            //    Console.WriteLine("Two of them are equal.");
            //}
            //else if (variable1 == variable1 || variable3 == variable2)
            //{
            //    Console.WriteLine("Two of them are equal.");
            //}
            //else
            //{
            //    Console.WriteLine("They are all equal.");
            //}

            //4.
            //Console.Write("Enter First Number: ");
            //int firstNum = int.Parse(Console.ReadLine());

            //Console.Write("Enter Second Number: ");
            //int secondNum = int.Parse(Console.ReadLine());

            //Console.Write("Enter Third Number: ");
            //int thirdNum = int.Parse(Console.ReadLine());

            //int greatest, mid, lowest;

            //if (firstNum > secondNum && firstNum > thirdNum)
            //{
            //    greatest = firstNum;
            //    if (secondNum < thirdNum)
            //    {
            //        mid = secondNum;
            //    }
            //    else
            //    {
            //        lowest = thirdNum;
            //    }
            //}
            //else if (secondNum > firstNum && secondNum > thirdNum)
            //{
            //    greatest = secondNum;
            //    if (firstNum < thirdNum)
            //    {
            //        mid = firstNum;
            //    }
            //    else
            //    {
            //        lowest = thirdNum;
            //    }
            //}
            //else if (thirdNum > firstNum && thirdNum > secondNum)
            //{
            //    if (firstNum < secondNum)
            //    {
            //        mid = firstNum;
            //    }
            //    else
            //    {
            //        lowest = secondNum;
            //    }
            //}
            //Console.WriteLine(lowest);
            //Console.WriteLine(mid);
            //Console.WriteLine(greatest);

            // 5.
            //Console.Write("Enter Number: ");
            //int num = int.Parse(Console.ReadLine());    

            //switch (num) 
            //{
            //    case 0:
            //        Console.WriteLine("Zero.");
            //        break;
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
            //    case 7:
            //        Console.WriteLine("Seven.");
            //        break;
            //    case 8:
            //        Console.WriteLine("Eight.");
            //        break;
            //    case 9:
            //        Console.WriteLine("Nine.");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Input.");
            //        break;

            //}

            // 6.
            //Console.Write("Enter Coefficient a: ");
            //double a = int.Parse(Console.ReadLine());

            //Console.Write("Enter Coefficient b: ");
            //double b = int.Parse(Console.ReadLine());

            //Console.Write("Enter Coefficient c: ");
            //double c = int.Parse(Console.ReadLine());

            //double sqrt = Math.Sqrt((b*b)-(4*a*c));
            //double quadraticForm = (-b + -sqrt) / 2 * a;
            //Console.WriteLine($"Roots of the quadrative equation are {quadraticForm}");

            // 7.
            //Console.Write("Enter integer 1: ");
            //int integer1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter integer 2: ");
            //int integer2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter integer 3: ");
            //int integer3 = int.Parse(Console.ReadLine());
            //Console.Write("Enter integer 4: ");
            //int integer4 = int.Parse(Console.ReadLine());
            //Console.Write("Enter integer 5: ");
            //int integer5 = int.Parse(Console.ReadLine());

            //if (integer1 >  integer2 && integer1 > integer3 && integer1 > integer4 && integer1 > integer5)
            //{
            //    Console.WriteLine($"{integer1} is the greatest.");
            //}
            //else if (integer2 > integer1 && integer2 > integer3 && integer2 > integer4 && integer2 > integer5)
            //{
            //    Console.WriteLine($"{integer2} is the greatest.");
            //}
            //else if (integer3 > integer1 && integer3 > integer2 && integer3 > integer4 && integer3 > integer5)
            //{
            //    Console.WriteLine($"{integer3} is the greatest.");
            //}
            //else if (integer4 > integer1 && integer4 > integer3 && integer4 > integer2 && integer4 > integer5)
            //{
            //    Console.WriteLine($"{integer4} is the greatest.");
            //}
            //else if (integer5 > integer1 && integer5 > integer3 && integer5 > integer4 && integer5 > integer2)
            //{
            //    Console.WriteLine($"{integer5} is the greatest.");
            //}
            //int[] array = new int[5];
            //int[] subset = new int[5];


            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Enter {i + 1} Number: ");
            //    int Num = int.Parse(Console.ReadLine());
            //    array[i] = Num;
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if ((array[i] + array[i+1]) == 0)
            //    {
            //        subset[i] = array[i];
            //        subset[i+1] = array[i+1];
            //    }
            //    if ((array[i] + array[i +2]) == 0)
            //    {
            //        subset[i] = array[i];
            //        subset[i+1] = array[i + 2];
            //    }
            //    if ((array[i] + array[i + 3]) == 0)
            //    {
            //        subset[i] = array[i];
            //        subset[i + 1] = array[i + 3];
            //    }
            //    if ((array[i] + array[i + 4]) == 0)
            //    {
            //        subset[i] = array[i];
            //        subset[i + 1] = array[i+4];
            //    }
            //    if ((array[i+1] + array[i]) == 0)
            //    {
            //        subset[i] = array[i+1];
            //        subset[i + 1] = array[i];
            //    }
            //    if ((array[i+1] + array[i + 2]) == 0)
            //    {
            //        subset[i] = array[i+1];
            //        subset[i + 1] = array[i + 2];
            //    }
            //    if ((array[i+1] + array[i + 3]) == 0)
            //    {
            //        subset[i] = array[i+1];
            //        subset[i + 1] = array[i + 3];
            //    }
            //    if ((array[i+1] + array[i + 4]) == 0)
            //    {
            //        subset[i] = array[i+1];
            //        subset[i + 1] = array[i + 4];
            //    }
            //    if ((array[i + 2] + array[i]) == 0)
            //    {
            //        subset[i] = array[i+2];
            //        subset[i + 1] = array[i];
            //    }
            //    if ((array[i + 2] + array[i + 3]) == 0)
            //    {
            //        subset[i] = array[i + 2];
            //        subset[i + 1] = array[i + 3];
            //    }
            //    if ((array[i + 2] + array[i + 4]) == 0)
            //    {
            //        subset[i] = array[i + 2];
            //        subset[i + 1] = array[i + 3];
            //    }
            //    if ((array[i + 2] + array[i + 1]) == 0)
            //    {
            //        subset[i] = array[i + 1];
            //        subset[i + 1] = array[i + 1];
            //    }
            //    if ((array[i + 3] + array[i]) == 0)
            //    {
            //        subset[i] = array[i + 3];
            //        subset[i + 1] = array[i];
            //    }
            //    if ((array[i + 3] + array[i + 1]) == 0)
            //    {
            //        subset[i] = array[i + 3];
            //        subset[i + 1] = array[i + 1];
            //    }
            //    if ((array[i + 3] + array[i + 2]) == 0)
            //    {
            //        subset[i] = array[i + 3];
            //        subset[i + 1] = array[i + 2];
            //    }
            //    if ((array[i + 3] + array[i + 4]) == 0)
            //    {
            //        subset[i] = array[i + 3];
            //        subset[i + 1] = array[i + 4];
            //    }
            //    if ((array[i + 4] + array[i]) == 0)
            //    {
            //        subset[i] = array[i + 4];
            //        subset[i + 1] = array[i];
            //    }
            //    if ((array[i + 4] + array[i + 1]) == 0)
            //    {
            //        subset[i] = array[i + 4];
            //        subset[i + 1] = array[i + 1];
            //    }
            //    if ((array[i + 4] + array[i + 2]) == 0)
            //    {
            //        subset[i] = array[i + 4];
            //        subset[i + 1] = array[i + 2];
            //    }
            //    if ((array[i + 4] + array[i]) == 0)
            //    {
            //        subset[i] = array[i + 3];
            //        subset[i + 1] = array[i];
            //    }
            //    if ((array[i + 3] + array[i] + array[i + 2]) == 0)
            //    {
            //        subset[i] = array[i + 3];
            //        subset[i + 1] = array[i];
            //        subset[i + 2] = array[i + 2];
            //    }
            //    if ((array[i + 3] + array[i + 1] + array[i + 2]) == 0)
            //    {
            //        subset[i] = array[i + 3];
            //        subset[i + 1] = array[i + 1];
            //        subset[i + 2] = array[i + 2];
            //    }
            //    if ((array[i + 3] + array[i + 2]) == 0)
            //    {
            //        subset[i] = array[i + 3];
            //        subset[i + 1] = array[i + 2];
            //    }
            //    if ((array[i + 3] + array[i + 4]) == 0)
            //    {
            //        subset[i] = array[i + 3];
            //        subset[i + 1] = array[i + 4];
            //    }
            //}



            // 10.
            //Console.Write("Enter Score: ");
            //int score = int.Parse(Console.ReadLine());

            //if (score >= 1 && score <= 3)
            //{
            //    score *= 10;
            //    Console.WriteLine($"Score: {score}");
            //}
            //else if (score > 3 && score <= 6)
            //{
            //    score *= 100;
            //    Console.WriteLine($"Score: {score}");
            //}
            //else if (score > 7 && score <= 9)
            //{
            //    score *= 1000;
            //    Console.WriteLine($"Score: {score}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input.");
            //}

            // Chapter 6.
            // 1.
            //Console.Write("Enter Number(N) = ");
            //int N = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= N; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // 2.
            //Console.Write("Enter Number(N) = ");
            //int N = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= N; i++)
            //{
            //    if (i % 3 > 0 && i % 7 > 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // 3.
            //Console.Write("Enter an Integer: ");
            //int integer = int.Parse(Console.ReadLine());

            //int biggestNumber = int.MinValue;
            //int smallestNumber = int.MaxValue;
            //for (int i = 1; i <= integer; i++)
            //{
            //    if (i > biggestNumber)
            //    {
            //        biggestNumber = i;
            //    }
            //    if (i < smallestNumber)
            //    {
            //        smallestNumber = i;
            //    }
            //}
            //Console.WriteLine($"The Biggest Number is {biggestNumber}");
            //Console.WriteLine($"The Smallest Number is {smallestNumber}");

            //6.
            //Console.Write("Enter First Number: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter Second Number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //double N = 1;
            //double K = 1;

            //for (int i = 1; i <= num1; i++)
            //{
            //    N *= i;
            //}
            //for (int i = 1; i <= num2; i++)
            //{
            //    K *= i;
            //}
            //double div = N / K;
            //Console.Write(div); 

            //7.
            //Console.Write("Enter First Number: ");
            //double No = double.Parse(Console.ReadLine());
            //Console.Write("Enter Second Number: ");
            //double No2 = double.Parse(Console.ReadLine());

            //double N = 1;
            //double K = 1;
            //double M = 1;
            //for (double i = 1; i <= No; i++)
            //{
            //    N *= i;
            //}
            //for (double i = 1; i <= No2; i++)
            //{
            //    K *= i;
            //}
            //double mul = N * K;
            //double min = No - No2;
            //for (int i = 1; i <= min; i++)
            //{
            //    M *= i;
            //}
            //double div = mul / M;
            //Console.WriteLine(div);

            // 8..
            //Console.WriteLine("Enter any number to check factorial: ");
            //int N = int.Parse(Console.ReadLine());
            //int nFactorial = 1;
            //int twoNfactorial = 1;
            //int nPlusOneFact = 1;
            //int M = 2 * N;
            //int P = N + 1;

            //for (int i = 1; i <= N; i++)
            //{
            //    nFactorial *= i;
            //}
            //for (int i = 1; i <= P; i++)
            //{
            //    nPlusOneFact *= i;
            //}
            //for (int i = 1; i <= M; i++)
            //{
            //    twoNfactorial *= i;
            //}
            //int catalanNumber = twoNfactorial / (nPlusOneFact * nFactorial);
            //Console.WriteLine($"The nth Catalan number is {catalanNumber}");

            // Chapter 7
            // Question 1
            //int[] array = new int[20];
            //for (int i = 0; i < array.Length-1; i++)
            //{
            //    int mul = i * 5;
            //    Console.WriteLine(mul); 
            //}

            // Question 2
            //Console.Write("Enter The Lenght Of First Array: ");
            //int lenght = int.Parse(Console.ReadLine());

            //Console.Write("Enter The Lenght Of Second Array: ");
            //int lenght1 = int.Parse(Console.ReadLine());

            //int[] array1 = new int[lenght];
            //int[] array2 = new int[lenght1];

            //if (lenght == lenght1)
            //{
            //    for (int i = 0; i < array1.Length; i++)
            //    {
            //        Console.Write($"Enter {i + 1} value for First Array: ");
            //        int.Parse(Console.ReadLine());
            //    }

            //    for (int i = 0; i < array2.Length; i++)
            //    {
            //        Console.Write($"Enter {i + 1} value for Second Array: ");
            //        int.Parse(Console.ReadLine());
            //    }

            //    for (int i = 0; i < array1.Length; i++)
            //    {
            //        if (array1[i] == array2[i])
            //        {
            //            Console.WriteLine("They Are Equal.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("They Are Not Equal.");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("They Are Not Equal.");
            //}

            // Question 4
            //int[] numArray = { 1, 1, 2, 3, 2, 2, 2, 1 };
            //int count = 0;
            //int[] maximal = new int[numArray.Length];
            //for (int i = 0; i < numArray.Length-1; i++)
            //{
            //    if (numArray[i] == numArray[i+1])
            //    {
            //        count++;
            //        maximal[i] = numArray[i];
            //    }
            //}
            //foreach (var item in maximal)
            //{
            //    Console.WriteLine(item);
            //}

            // Question 5
            //int[] array = { 3, 2, 3, 4, 2, 2, 4 };
            //int[] secArray = new int[7];
            //int count = 0;
            //for (int i = 0; i < array.Length-1; i++)
            //{
            //    if ((array[i+1]- array[i])== 1)
            //    {
            //        if (array[i+1] == secArray[count])
            //        {
            //            secArray[count + 1] = array[i+1];
            //            count++;
            //        }
            //        else
            //        {
            //            secArray[count] = array[i];
            //            secArray[count+1] = array[i +1];
            //            count++;
            //        }
            //    }
            //}

            //foreach (var item in secArray)
            //{
            //    Console.Write(item);
            //}

            // Question 12
            //Console.Write("Rows: ");
            //int rows  = int.Parse(Console.ReadLine());

            //Console.Write("Column: ");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] values = new int[rows, cols];

            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        Console.Write($"Enter value for {row},{col}: ");
            //        values[row,col] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < values.GetLength(0); i++)
            //{
            //    for (int j = 0; j < values.GetLength(1); j++)
            //    {
            //        Console.Write(values[i, j]+ " ");
            //    }
            //    Console.WriteLine();
            //}

            // Chapter  9
            //Question 1
            //Console.Write("Enter Your Name: ");
            //string name = Console.ReadLine();
            //PrintNum(name);

            // Question 2
            //Console.Write("Enter The First Number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter The Second Number: ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter The Third Number: ");
            //int num3 = int.Parse(Console.ReadLine());
            //GetMax(num1, num2, num3);

            // Question 3
            //Console.Write("Enter Number: ");
            //int number = int.Parse(Console.ReadLine());
            //GetLast(number);

            // Question 4
            Howmany();
        }
        static void PrintNum(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
        static void GetMax(int num1, int num2, int num3)
        {
            int max = Math.Max(num1, Math.Max(num2, num3));
            Console.WriteLine($"The Biggest of the three number is => {max}");
        }

        static void GetLast(int num)
        {
            string num1 = num.ToString();
            for (int i = 0; i < num1.Length-1; i++)
            {
                switch (num1[num1.Length - 1])
                {
                    case '1':
                        Console.WriteLine("One");
                        break;
                    case '2':
                        Console.WriteLine("Two");
                        break;
                    case '3':
                        Console.WriteLine("Three");
                        break;
                    case '4':
                        Console.WriteLine("Four");
                        break;
                    case '5':
                        Console.WriteLine("Five");
                        break;
                    case '6':
                        Console.WriteLine("Six");
                        break;
                    case '7':
                        Console.WriteLine("Seven");
                        break;
                    case '8':
                        Console.WriteLine("Eight");
                        break;
                    case '9':
                        Console.WriteLine("Nine");
                        break;
                    case '0':
                        Console.WriteLine("Zero");
                        break;
                }
            }
        }

        static void Howmany()
        {
            int[] array = { 1, 1, 2, 3, 2, 1, 3, 3, 4, 2, 4, 4, 5, 3, 5, 5, 5, 2, 2, 4, 5, 3, 2, 5, 5, 4, 6, 7, 5, 5, 7, 6, 8, 8, 9, 0,0,0,0,0};
            Console.Write("Enter Number: ");
            int number = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < array.Length-1; i++)
            {
                if (number == array[i])
                {
                    count++;
                }
            }
            Console.WriteLine($"{number} appeared {count} times in the array.");
        }
    }
}