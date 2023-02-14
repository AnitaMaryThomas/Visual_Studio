// string s = "Hello World";
// Console.WriteLine(s);

//string firstName = "Anita";
//string lastName = "Thomas";
//Console.WriteLine(firstName + " " + lastName);

//string firstName = Console.ReadLine();
//string lastName = Console.ReadLine();
//Console.WriteLine(firstName + " " + lastName);


//Console.WriteLine("Enter the firstname");
//string firstName = Console.ReadLine();
//Console.WriteLine("Enter the secondname");
//string lastName = Console.ReadLine();
//Console.WriteLine(firstName + " " + lastName);


//int i = 10;
//int j = 20;
//string s = "red";
//string? s = null;

//int i;
//i = 10;
//Console.WriteLine(i);

// constant the value doesn't change....
//const int c = 10;
//Console.WriteLine(c);

// find the length.....
//string s = "Hello world";
//Console.WriteLine(s.Length);

//Console.Beep();
//Console.BackgroundColor = ConsoleColor.Magenta;
//Console.ForegroundColor = ConsoleColor.Yellow;

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//    Thread.Sleep(1000);// See the Delay.....
//}

//string data = "Hello World";
//for (int i = 0; i < data.Length; i++)
//{
//    Console.WriteLine(data[i]);
//}
//// foreach................................
//foreach (var item in data)
//{
//    Console.WriteLine(item);
//}

//Type conversion.............................
//string ns = "50";
//int i = int.Parse(ns);
//Console.WriteLine(i);
//Console.WriteLine(i.GetType());

//string ns = null;
//int i = Convert.ToInt32(ns);
//Console.WriteLine(i);
//Console.WriteLine(i.GetType());

//Trim(),TrimEnd()........................
//string s = "###This is a message***";
//Console.WriteLine(s.Trim('#','*'));
//Console.WriteLine(s.TrimEnd());

//print the space in the string
//string s = "Hello World";
//int count = 0;
//foreach (char c in s)
//{
//    if (c == ' ')
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

//string s = "This is a text";
//var res = s.Contains("Text", StringComparison.CurrentCultureIgnoreCase);
//if (res)
//    Console.WriteLine("Yes");
//else
//    Console.WriteLine("No");

//int j = 10;
//int i = -10;
//uint is unsigned only stores the +ve values...
//uint ui = 10;
//uint uj = -10;

//..........................................................................................
//using System.Diagnostics;
//string data = "Hello World";


// var watch = new Stopwatch();
//watch.Start();
//foreach (char c in data)
//Console.Write(char.ToUpper(c));
// Thread.Sleep(1000);
//watch.Stop();
//Console.WriteLine();
//Console.WriteLine(watch.Elapsed);

//var watch = new Stopwatch();
//watch.Start();
//Parallel ForEach(data, (i) ⇒
//{
//Console.Write(char.ToUpper(i)); 
//Thread.Sleep(1000);
//});
//watch.Stop();
//Console.WriteLine();
//Console.WriteLine(watch.Elapsed);





//using System;
//string[] array = new string[10];
//int i = 0;
//for (i = 0; i <= 5; i++)
//{
//    Console.WriteLine("Enter your name");
//    //string name = Console.ReadLine();
//    array[i] = Console.ReadLine();
//}
//foreach (string name in array)
//    Console.WriteLine(name);

//// Sorted array.

//Array.Sort(array);
//foreach (string name in array)
//    Console.WriteLine(name);




//// Reverse of the array.



//Array.Reverse(array);
//foreach (string name in array)
//    Console.WriteLine(name);



////find a name from array.
//Console.WriteLine("Enter the name to be find");
//string key = Console.ReadLine();
//Boolean flag = false;
//foreach (var item in array)
//{
//    if (key == item)
//    {
//        flag = true;
//        break;
//    }
//}
//if (flag == true)
//{
//    Console.WriteLine("item found");
//}
//else
//{
//    Console.WriteLine("No matches value ");
//}



// Length of each element .



//foreach (var item in array)
//{
//    Console.WriteLine("Length of " + item + ":" + item.Length);
//}

//// Find the duplicate of the array.b


//Boolean f = false;
//string a =" ";
//for (i = 0; i < 5; i++)
//{
//    for (int j = i + 1; j <= 5; j++)
//    {
//        if (array[i] == array[j])
//        {
//            f = true;
//            a = array[i];
//            break;

//        }
//    }
//}
//if (f == true)
//{
//    Console.WriteLine("Duplicate element:" + a);
//}
//else
//{
//    Console.WriteLine("No duplicate element");
//}



//int[] arr1 = new int[5];//imp.....
//var arr2 = new int[5];

//int[] arr3 = { 4, 5, 6, 7, 8 };
//int[] arr4= new int[] { 4, 5, 6, 7, 8 };//imp.....
//int[] arr5 = new int[5] { 4, 5, 6, 7, 8 };




//string s = "This is a string";
//Console.WriteLine(s.IndexOf('i'));
//Console.WriteLine(s.IndexOf('i'));

//Console.WriteLine(s.LastIndexOf('i'));

//Contains.....................................
//if(s.Contains("is"))
//{
//    Console.WriteLine("This word exists");
//}

//Replace function.....................................
//s = s.Replace(" ", "_");
//Console.WriteLine(s);

//Remove function..............................................
//s = s.Remove(0, 5);
//Console.WriteLine(s);


//char[]  chars = "a,b,y,u,b,t,z".ToCharArray();
//string s = string.Empty;
//foreach (var c in chars)
//{
//    if (!s.Contains(c))
//        s += c;
//}
//Console.WriteLine(s);

//string firstName = "John";
//string lastName = "Thomas";
//int age = 22;

//string res1 = firstName+" "+ lastName;
//string res2 = firstName + " " + lastName + " " + age + " years old";
//string res3 = $"{firstName} {lastName} is {age} years old";
//string res4 = string.Format("{0} {1} is {2} years old", firstName, lastName, age);

//string res = string.Join(" ", firstName,lastName);
//Console.WriteLine(res);

//string s = "thIS IS a String";
//for (int i = 0; i < s.Length; i++)
//{
//    char ch = s[i];
//    if (Char.IsLower(ch))
//        Console.Write(Char.ToUpper(ch));
//    else
//        Console.Write(Char.ToLower(ch));
//}

//object o = "Hello";
//string s = (string)o;
//Console.WriteLine(s.ToUpper());

//dynamic o = "Hello";
//Console.WriteLine(o.ToUpper());

//object[] data = { 1, 2, 3, "four", "five" };
//int sum = 0;
//foreach (object item in data)
//{
//    var type = item.GetType();
//    if (type == typeof(int))
//    {
//        sum += (int)item;
//    }
//}
//Console.WriteLine(sum);

//List.....................................................
//var lst = new List<int>() { 20, 60 };  //{ 20, 60 } add this elements at the time of declaration.........
//lst.Add(1);
//lst.Add(2);
//Console.WriteLine(lst[1]);
//Console.WriteLine(lst.Count); //To count the elements..................
// Add() is used to add an element to a list.........................
//foreach (var item in lst)
//{
//    Console.WriteLine(item);
//}


//var lst1 = new List<int> { 1, 2, 3};
//var lst2 = new List<int> { 4, 5, 6 };
//lst1.AddRange(lst2);// Merge two lists.............
//foreach (var item in lst1)
//{
//    Console.WriteLine(item);
//}

//merge an array and list.......................................
//var lst1 = new List<int> { 1, 2, 3 };
//var lst2 = new int[] { 4, 5, 6 };
//lst1.AddRange(lst2);// Merge 
//foreach (var item in lst1)
//{
//    Console.WriteLine(item);
//}


//Remove an element.........................
//var lst1 = new List<int> { 1, 2, 3,2 };
//lst1.Remove(2);
//foreach (var item in lst1)
//{
//    Console.WriteLine(item);
//}


//Remove an element using RemoveAt() by index.........................
//var lst1 = new List<int> { 1, 2, 3, 2 };
//lst1.RemoveAt(2);
//foreach (var item in lst1)
//{
//    Console.WriteLine(item);
//}

//Remove elements in a range......................
//var lst1 = new List<int> { 1, 2, 3, 2 };
//lst1.RemoveRange(0,2);
//foreach (var item in lst1)
//{
//    Console.WriteLine(item);
//}


//clear the elements..............
//var lst1 = new List<int> { 1, 2, 3, 2 };
//lst1.Clear();
//foreach (var item in lst1)
//{
//    Console.WriteLine(item);
//}

//var person = new Dictionary<string, string>();
//person.Add("Name", "Anita");
//person.Add("Age", "24");
//person["FullName"] = "Thomas";//Another method to add a new element..............................
//Console.WriteLine(person["Name"]);// To print the name.......................

// Give the values at the time of declaration and initialization.........................
//var person = new Dictionary<string, string>()
//{
//    {"Name","Anita" },
//    {"Age","21" }

//};
//Console.WriteLine(person["Name"]);



//...................................................................................
//var person = new Dictionary<string, string>()
//{
//    {"Name","Anita" },
//    {"Age","21" }
//};
//foreach (var item in person)
//{
//    Console.WriteLine(item.Key + ":" + item.Value);
//}


//var person = new List<Dictionary<string, string>>();
//while(true)
//{
//    Console.WriteLine("1. Add Students");
//    Console.WriteLine("1. View Students");
//    var input = Console.ReadLine();
//    switch (input)
//    {
//        case "1":
//            Console.WriteLine("Enter the student name");
//            var name = Console.ReadLine();

//            Console.WriteLine("Enter the student mark1");
//            var mark1 = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter the student mark2");
//            var mark2 = int.Parse(Console.ReadLine());

//      var student = new Dictionary<string, object>()
//            {

//                { "name",name },
//                { "mark1",mark1 },
//                { "mark2",mark2}

//            };
//            students.Add(student);
//            break;
//            case "2":
//            foreach (var item in students)
//            {
//                int m1 = (int)item["mark1"];
//                int m2 = (int)item["mark2"];
//                int total = m1 + m2;
//                Console.WriteLine($"Name: {item["Name]} | Total: {total}");
//                    }
//                    break;
//                    default:
//                    break;
//    }


//}



//var students = new List<Dictionary<string, object>>();

//students.Add(new Dictionary<string, object>()
//    {
//    { "Name", "John"},
//    { "Age", 18},
//    { "GPA",3.5}
//});


//Generic collections are list,dictionary.
//Console.WriteLine("Enter the key and value");
//string key = Console.ReadLine();
//string value = Console.ReadLine();

//var d = new Dictionary<string, string>();
//d.Add(key, value); // or
//d[key] = value;

//var person = new Dictionary<string, string>()
//{

//       {"key1","Anita"},
//       {"key2","24"}
//    };
//Console.WriteLine("Enter the key to search");
//var key = Console.ReadLine();
//foreach(var item in person)
//{
//    if (item.Value==key)
//    {
//        Console.WriteLine("Found: " + item.Value);
//        break;
//    }
//}


//Console.WriteLine("Enter any text");
//string text = Console.ReadLine();
//int numbers;
//int count = 0;
//foreach(var item in text)
//{
//    if (item>= '0' && item <= '9')
//    {
//        count++;
//    }
//}
//numbers = new int[count];
//int index = 0;
//foreach (var item in text)
//{
//    if (item >= '0' && item <= '9')
//    {
//        numbers[index++] = int.Parse(item.ToString());
//    }
//}
//Console.WriteLine(String.Join(",", numbers);




// Interface...............................
// Interface is a contract

//Constants are call by class name not using objects because constants are not changed so we called classname.constantname............

//using ConsoleAppCore;
//using ConsoleAppCore.Entities;

//var s = new schoolstudent("asdfg");
//s.Name = "A name";

//Console.WriteLine(s.Name);
////Console.WriteLine(s.Age);
////Console.WriteLine(s.registerNumber);
//Console.WriteLine(schoolstudent.schoolname);

//23/01/2023..........................................................................
string ConvertCasting(string text, Options option)
{
	switch (option)
	{
		case Options.UpperCase:
			return text.ToUpper();
		case Options.LowerCase:
            return text.ToLower();

        default:
			return text;
	}
}
var res = ConvertCasting("helloworld", Options.UpperCase);
enum Options
{
	UpperCase,
	LowerCase,
}


