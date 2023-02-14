using System;
string[] array = new string[10];
int i = 0;
for (i = 0; i <= 5; i++)
{
    Console.WriteLine("Enter your name");
    string name = Console.ReadLine();
    array[i] = name;
}
foreach (string name in array)
    Console.WriteLine(name);

// Sorted array.

Array.Sort(array);
foreach (string name in array)
    Console.WriteLine(name);




// Reverse of the array.



Array.Reverse(array);
foreach (string name in array)
    Console.WriteLine(name);



//Find a name from array.

Console.WriteLine("Enter the name to be find");
string key = Console.ReadLine();
Boolean flag = false;
foreach (var item in array)
{
    if (key == item)
    {
        flag = true;
        break;
    }
}
if (flag == true)
{
    Console.WriteLine("item found");
}
else
{
    Console.WriteLine("No matches value ");
}


foreach (var item in array)
{
    Console.WriteLine("Length of " + item + ":" + item.Length);
}

// Find the duplicate of the array.b


Boolean f = false;
string a = " ";
for (i = 0; i < 5; i++)
{
    for (int j = i + 1; j <= 5; j++)
    {
        if (array[i] == array[j])
        {
            f = true;
            a = array[i];
            break;

        }
    }
}
if (f == true)
{
    Console.WriteLine("Duplicate element:" + a);
}
else
{
    Console.WriteLine("No duplicate element");
}