//string filePath = ".\\helloyoppy.txt";
//string path = "C:\\Users\\ORIOLOWts\\O\\DocumenBatch e\\newFi23 Class\\Filtl.xt";
//string path2 = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\File\\File\\Bacth23File\\mustapha.txt";
//if (!File.Exists(filePath))
//{
//    File.Create(filePath);
//    Console.WriteLine("File Created Successfully.");

//}"
//if (!File.Exists(path2))
//{
//    FileStream fs = File.Create(path2);
//    Console.WriteLine("File Created Successfully.");
//    fs.Flush();
//    fs.Close();
//}
//if (File.Exists(path2))
//{
//    Console.WriteLine("File Exist.");
//    StreamWriter sr = new StreamWriter(path2 );
//    sr.WriteLine("Konichiwa File desu");

//    sr.Flush();
//    sr.Close();
//}

//string path3 = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\File\\File\\classwork.txt";
//if (!File.Exists(path3))
//{
//    StreamWriter st = new StreamWriter(path3);
//    st.WriteLine("Hello!");
//    st.Flush();
//    st.Close();
//}

//if (File.Exists(path3))
//{
//    StreamReader sr = new StreamReader(path3);
//    string content = sr.ReadLine();
//    Console.WriteLine(content); 
//    sr.Close();
//}

//if (File.Exists(path3))
//{
//    using (StreamWriter writer = new StreamWriter(path3, true))
//    {
//        writer.WriteLine("Holla22");
//    }
//}

//if (File.Exists(path3))
//{
//    using (StreamReader writer = new StreamReader(path3))
//    {
//        string content = writer.ReadToEnd();
//        Console.WriteLine(content);
//    }
//}

//if (File.Exists(path3))
//{
//    File.Delete(path3);
//    Console.WriteLine("File Deleted Successfully.");
//}
//else
//{
//    Console.WriteLine("File doesnt exist.");
//}

//if (!File.Exists(path3))
//{
//    using (StreamWriter writer = new StreamWriter(path3))
//    {
//        writer.WriteLine("This is a file");
//    }
//}
//if (File.Exists(path3))
//{
//    using (StreamWriter writer = new StreamWriter(path3, true))
//    {
//        writer.WriteLine("Filaaaa");
//    }
//}
//if (File.Exists(path3))
//{
//    using (StreamReader writer = new StreamReader(path3))
//    {
//        string content = writer.ReadToEnd();
//        Console.WriteLine(content);
//    }
//}
//if (File.Exists(path3))
//{
//    File.Delete(path3);
//    Console.WriteLine("File Deleted Successfully.");
//}
//else
//{
//    Console.WriteLine("File doesnt exist.");
//}

string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\File\\File\\Foldernew\\file.txt";


if (!File.Exists(path))
{
    using (StreamWriter writer = new StreamWriter(path))
    {
        writer.WriteLine("This is a file");
    }
}
