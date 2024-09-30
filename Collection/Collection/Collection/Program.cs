using System.Collections;

// Array List
//ArrayList arrayList = new ArrayList();
//arrayList.Add("Fukurojuro");
//arrayList.Add("Fukurojuro");
//arrayList.Add(1010);
//arrayList.Add(90.3);

//foreach (var item in arrayList)
//{
//    Console.Write(item + " ");
//}

// Queue
//Queue firstQueue = new Queue();
//firstQueue.Enqueue("Neptune");
//firstQueue.Enqueue(3998);
//firstQueue.Enqueue(true);

//firstQueue.Dequeue();
//int c = firstQueue.Count;
//Console.Write(c);

//Stack stack = new Stack();
//stack.Push("Hello");
//stack.Push(93748684);
//stack.Push(false);
//stack.Push(3337.37373);

////stack.Clear();
////stack.Peek();
////Console.WriteLine(stack.Pop());
//stack.Clone();
//Console.WriteLine();
////foreach (var item in stack)
////{
////    Console.WriteLine(item);
////}

// HashTable
//Hashtable hashtable = new Hashtable();
//hashtable.Add("Name", "John");
//hashtable.Add("Country", "USA");
//hashtable.Add("Age", 23);
//hashtable.Add("Size", 2733.22);

//foreach (DictionaryEntry item in hashtable)
//{
//    Console.WriteLine($"Key: {item.Key}, Value:{item.Value}");
//}

// Sorted List

// Generic
//Stack
//Stack<int> st  = new Stack<int>();
//st.Push(0);
//st.Push(1);
//st.Push(2);
//Console.WriteLine(st.Pop());
//Console.WriteLine(st.Peek());

//Dictionary<int, string> DC = new Dictionary<int, string>();
//DC.Add(1, "Ade");
//DC.Add(2, "Fola");
//foreach (var item in DC)
//{
//    Console.WriteLine($"KEY: {item.Key} VALUE: {item.Value}");
//}

var list = new List<string>()
{
    "Milk", 
    "Honey",
    "Burger",
    "Garri"
};
Console.WriteLine(list.Capacity);    
list.Add("1");
list.Add(null);
list.Remove("1");
list.RemoveAt(1);
list.Insert(0, "Hello");