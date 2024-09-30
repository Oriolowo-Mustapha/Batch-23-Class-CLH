using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //areaOfTrapezium(1, 2, 3);

            //longestString("Hello", "World!");

            //degreeToFah(0);

            //var result = collectChar("ade");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //sumPrice(1,2,3);

            //Allname("Bola", "Opeyemi", "Fathia");
            //Substraction(1, 8);

            //int result = Addition();
            //Console.WriteLine(result);  
            //Personal();
            //GreatestNum();

            // Assignment
            //Console.WriteLine("Enter Word: ");
            //string word = Console.ReadLine();
            //bool check = checkPalindrome(word);
            //if (check)
            //{
            //    Console.WriteLine($"{word} is Palindrome");
            //}
            //else
            //{
            //    Console.WriteLine($"{word} is  not Palindrome");
            //}

            //sortArray();
            //GetCountWord();
            //GetArray();

            //int[] array1 = { 1, 2, 3 };
            //int[] array2 = { 4, 5, 6 };
            //joinArray(array1, array2); 
            //Console.WriteLine("Enter Number in string: ");
            //string number = Console.ReadLine();
            //ConvertString(number);
        }
        // Question 1
        //public static void areaOfTrapezium(double a, double b, double height) 
        //{
        //    double area = 0.5 * (a + b) * height;
        //    Console.WriteLine(area);
        //}

        // Question 2
        //public static void longestString(string firstString, string secondString) 
        //{
        //    int count1 = 0;
        //    int count2 = 0;
        //    for (int i = 1; i <= firstString.Length; i++)
        //    {
        //        count1 += 1;
        //    }
        //    for (int i = 1; i <= secondString.Length; i++)
        //    {
        //        count2 += 1;
        //    }
        //    if (count1 > count2)
        //    {
        //        Console.WriteLine($"{firstString} is the longest string.");
        //    }
        //    else if(count1 < count2)
        //    {
        //        Console.WriteLine($"{secondString} is the longest string.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("They of the same lenght.");
        //    }

        // Question 3
        //public static void degreeToFah(double degree)
        //{
        //    double conv = (1.8 * degree) + 32;
        //    Console.WriteLine($"{conv}F");
        //}

        //public static char[] collectChar(string myName)
        //{
        //    char[] array = new char[myName.Length];
        //    for (int i = 0; i < myName.Length; i++)
        //    {
        //        array[i] = myName[i];
        //    }
        //    return array;
        //}

        //public static void sumPrice(params double[] price)
        //{
        //    double totalPrice = 0;
        //    foreach (var item in price)
        //    {
        //        totalPrice += item;
        //    }
        //    Console.WriteLine($"The total price cost: {totalPrice}");
        //}

        //public static string Allname(params string[] names) 
        //{
        //    int count = 0;
        //    foreach (string name in names)
        //    {
        //        count++;
        //        Console.WriteLine(name);
        //    }
        //    return $"The Total Number Of Names Are: {count}";
        //}
        // public static void Substraction(int A, int B)
        //{
        //    int sub =  A -  B;
        //}
        //public static void Substraction(double A, double B)
        //{
        //    double sub = A - B;
        //}
        //public static void Substraction(int A, int B, int C)
        //{
        //    double sub = A - B;
        //}

        //public static int Addition(int a = 10, int b = 20)
        //{
        //    int c = a + b;
        //    return c;
        //}
        // Implement a method that takes in three optional parameter the m
        //public static void Personal(string name= "Opeyemi", int age = 16, string address= "No 6 Dowing Street", double height = 5.6)
        //{
        // Console.WriteLine($"Orewa {name}. \nI am {age}.\nI live in {address}.\nI am {height} tall.");
        //}

        //public static void GreatestNum() 
        //{
        //     int greatestNum = int.MinValue;
        //     int smallestNum = int.MaxValue;
        //     Console.WriteLine("Enter how many numbers you want enter:");
        //     int input = int.Parse(Console.ReadLine());

        //     for (int i = 1; i <= input; i++)
        //     {
        //         Console.WriteLine($"Enter {i} Number:");
        //         int num = int.Parse(Console.ReadLine());

        //         if (num > greatestNum)
        //         {
        //             greatestNum = num;
        //         }
        //         if (num < smallestNum)
        //         {
        //             smallestNum = num;
        //     Console.WriteLine($"Smallest Number is {smallestNum}");
        //         }
        //     }
        //     Console.WriteLine($"Greatest Number is {greatestNum}");
        // }

        // Assignment
        //public static bool IsPalindrome(string word)
        //{
        //    int length = word.Length;
        //    for (int i = 0; i < length / 2; i++)
        //    {
        //        if (word[i] != word[length - i - 1])
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //public static void sortArray()
        //{
        //    Console.Write("Enter The lenght of the array: ");
        //    int input = int.Parse(Console.ReadLine());
        //    int[] array = { input };

        //    for (int i = 0; i > input; i++)
        //    {
        //        Console.Write($"Enter {i} Number: ");
        //        int num = int.Parse(Console.ReadLine());

        //    }
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = 0; j < array.Length-i-1; j++)
        //        {
        //            if (array[j] > array[j + 1])
        //            {
        //                int temp = array[j];
        //                array[j] = array[j + 1];
        //                array[j + 1] = temp;
        //            }
        //        }
        //    }
        //    foreach (var item in array)
        //    {
        //        Console.WriteLine(array);
        //    }

        //public static void joinArray(int[] array1, int[] array2)
        //{
        //    int[] join = array1.Concat(array2).ToArray();

        //    foreach (var item in join)
        //    {
        //        Console.Write(item);
        //    }
        //}

        // Implement a method that get the total count of  word in a sentence
        public static void GetCountWord()
        {
            Console.WriteLine("Enter any sentence: ");
            string word = Console.ReadLine();
            var word2 = word.Split(" ");

            int count = 0;
            foreach (var item in word2)
            {
                count++;
            }
            Console.WriteLine(count);
        }

        // implement a method that takes in a 4x4 array naw put every thing in a single array
        //public static void GetArray()
        //{
        //    int[,] array = new int[4, 4];
        //    int[] singleArray = new int [array.GetLength(0) * array.GetLength(1)];
        //    int count = 0;

        //    for (int i = 0; i < array.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < array.GetLength(1); j++)
        //        {
        //            Console.Write($"Enter value for {i}, {j}: ");
        //            int input = int.Parse(Console.ReadLine());
        //            array[i, j] = input;
        //        }
        //    }

        //    for (int i = 0; i < array.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < array.GetLength(1); j++)
        //        {
        //            singleArray[count] = array[i, j];
        //            count++;    
        //        }
        //    }

        //    foreach (var item in singleArray)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        // implement a method that implement int.Parse
        // put the natural numbers in a char array

        //public static void joinArray(int[] array1, int[] array2)
        //{

        //    int[] joinArray = new int[array1.Length + array2.Length];



        //    for (int i = 0, j =0; i < joinArray.Length; i++)
        //    {
        //        if (i < array1.Length)
        //        {
        //            joinArray[i] = array1[i];
        //        }
        //        else
        //        {
        //            joinArray[i] = array2[j];
        //            j++;
        //        }
        //    }
        //    foreach (var item in joinArray)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //public static int ConvertString(string number)
        //{
        //    char[] numChar = { '0', '1','2','3','4','5','6','7','8','9','0'};
        //    char[] converter = number.ToCharArray();
        //    int answer = 0;
        //    for (int i = 0; i < numChar.Length; i++)
        //    {
        //        for (int j = 0; j < converter.Length; j++)
        //        {
        //            if (converter[i] == numChar[j])
        //            {
        //                answer = answer * 10 + j;
        //            }
        //        }
        //    }
        //    return answer;
        //}
    }
}
