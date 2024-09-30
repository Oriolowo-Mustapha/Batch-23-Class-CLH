// using dictionary check for duplicate alphabets in a word
// static void CheckDuplicate()
//{
//    Console.WriteLine("Enter Word: ");
//    string word = Console.ReadLine();

//    Dictionary<char, int> dic = new Dictionary<char, int>();
//    foreach (char item in word)
//    {
//        if (dic.ContainsKey(item))
//        {
//            dic[item]++;
//        }
//        else
//        {
//            dic.Add(item, 1);
//        }
//    }

//    foreach (var item in dic)
//    {
        
//       Console.WriteLine($"KEY: {item.Key} VALUE: {item.Value}");
     
//    }
//}
//CheckDuplicate();
// Implement a method that check if the curly braces is completed to run a project
static void CheckCurlyBraces(string code)
{
    Console.WriteLine("How many curly bracket do you want implement in the program");
    int curly = int.Parse(Console.ReadLine());
    int balanced1 = 0;
    int balanced2 = 0;

    
    foreach (char item in code)
    {
        if(item == '{')
        {
            balanced1++;
        }
        else if (item == '}')
        {
            balanced2++;
        }
    }
    int totalNeed = balanced2 + balanced1;
    if (balanced1 == balanced2)
    {
        if (totalNeed == curly)
        {
            Console.WriteLine("Its Enough.");
        }
        else
        {
            Console.WriteLine("Its not Enough.");
        }
    }
    else
    {
        Console.WriteLine("The opening braces is not equal to the closing braces.");
    }

    
}
//bool checkSequence(string curly)
//{
//    var stack = new Stack<char>();
//    foreach (var item in stack)
//    {
//        if (item == '{')
//        {
//            stack.Push(item);
//        }
//        else if (item == '}' && stack.Count == 0)
//        {
//            return false;
//        }else if (item == '}' && stack.Count == 1)
//        {
//            stack.Pop();
//        }
//    }
//    if (stack.Count > 0)
//    {
//        return false;
//    }
//}
///using generic stack reverse the word inside a sentence
//static void RevWord()
//{
//    Console.Write("Enter Word: ");
//    string word = Console.ReadLine();
//    Stack<char> rev = new Stack<char>();

//    foreach (char item in word)
//    {
//        rev.Push(item);
//    }
//    foreach (char item in rev)
//    {
//        Console.Write(item);
//    }
//}
//RevWord();
///implement a method that register student taken the name of the student and the number of subject the list the of subject
static void RegStud()
{
    Console.Write("How many student do you want to register: ");
    int no = int.Parse(Console.ReadLine());

    Dictionary<string, string> Dic = new Dictionary<string, string>();

    for (int i = 0; i < no; i++)
    {
        Console.Write($"Enter {i + 1} Student Name: ");
        string Name = Console.ReadLine();
        
        Console.Write("Enter no subjects: ");
        int noSub = int.Parse(Console.ReadLine());
        string[] array = new string[noSub];
        for(int j = 0; j<array.Length; j++)
        {
            Console.Write($"Enter {j+1} subject: ");
            string Sub = Console.ReadLine();
            array[j] = Sub;
        }
        string newString = array.ToString();
        Dic.Add(Name, newString);
        Console.WriteLine();
    }
    foreach (var item in Dic)
    {
        Console.WriteLine($"Name: {item.Key} Subjects offered: {item.Value}");
    }

}
RegStud();
