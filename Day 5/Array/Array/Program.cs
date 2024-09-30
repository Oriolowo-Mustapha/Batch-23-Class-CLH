//int[] score= new int[5];
//string[] name = new string[5];

//for (int i = 0; i <= name.Length-1; i++)
//{
//    Console.Write($"Enter Student {i+1} name: ");
//    name[i] = Console.ReadLine();


//    Console.Write($"Enter Student {name[i]} score: ");
//    score[i] = int.Parse(Console.ReadLine());


//}
//// after entering all the values immediately u entered the score u should print the highest score
//int maxScore = score[0];
//string maxName = name[0];
//for (int i = 0; i < score.Length-1; i++)
//{
//    if (score[i] > maxScore)
//    {
//        maxScore = score[i];
//        maxName = name[i];
//    }
//}

//Console.WriteLine($"\nThe highest Student = {maxName}");
//Console.WriteLine($" with highest score = {maxScore}");

//int lowScore = score[0];
//string lowName = name[0];
//for (int i = 0; i < score.Length - 1; i++)
//{
//    if (score[i] < lowScore)
//    {
//        lowScore = score[i];
//        lowName = name[i];
//    }
//}
//Console.WriteLine($"The lowest student = {lowName}");
//Console.Write($" with lowest score = {lowScore}");

//int[] nums = new int[8];
//int sum = 0;
//for (int i = 1; i <= 6; i++)
//{
//    Console.Write($"Enter {i} Number: ");
//    int num = int.Parse(Console.ReadLine());
//    nums[i] = num;
//    sum += nums[i];
//}
//Console.WriteLine($"Sum = {sum}");


//int[] num = new int[8];
//int sum = 0;
//for (int i = 0; i <=  num.Length-1; i++)
//{
//    Console.Write($"Enter {i+1} Number: ");
//    int input = int.Parse(Console.ReadLine());
//    num[i] = input;

//    if (num[i] % 2 == 0 )
//    {
//        sum+= num[i];
//    }
//}
//Console.WriteLine(sum);

//int[] array1 = new int[3];
//int[] array2 = new int[3];
//int[] array3 = new int[3];
//for (int i = 0; i <= array1.Length-1; i++)
//{
//    Console.Write($"Enter First Array value {i + 1}: ");
//    array1[i] = int.Parse(Console.ReadLine());
//    for (int j = 0; j < 1; j++)
//    {
//        Console.Write($"Enter  Second Array value {j + 1}: ");
//        array2[j] = int.Parse(Console.ReadLine());

//        array3[i] = array1[i] + array2[j];
//    }
//}
//Console.WriteLine($"The Sum of the two array is {array3[0]}, {array3[1]}, {array3[2]}");


int[] array1 = new int[3];
int[] array2 = new int[3];
int sum1  = 0;
int sum2 = 0;
for (int i = 0; i < array1.Length-1; i++)
{
    Console.Write($"Enter num {i + 1} for array 1: ");
    array1[i] = int.Parse(Console.ReadLine());
    sum1 += array1[i];
    for (int j = 0; j < 1; j++)
    {
        Console.Write($"Enter num {j + 1} for array 2: ");
        array2[j] = int.Parse(Console.ReadLine());
        sum2 += array2[j];
    }
}
if (sum1 > sum2)
{
    Console.WriteLine("Array 1 has the highest value");
}
else if (sum1 < sum2)
{
    Console.WriteLine("Array 2 has the highest value");
}
else
{
    Console.WriteLine("Array 1 and 2 are equal");
}
