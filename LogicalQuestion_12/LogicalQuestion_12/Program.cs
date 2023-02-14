string[] Name = new string[3];
string[] Destination = new string[3];
string[] array3 = new string[6];
int j = 0;
int k = 1;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Enter the name");
    Name[i] = Console.ReadLine();
    Console.WriteLine("Enter the destination");
    Destination[i] = Console.ReadLine();
}
for (int i = 0;i < 3; i++)
{
    array3[j] = Name[i];
    j += 2;
    array3[k] = Destination[i];
    k += 2;
}
Console.WriteLine("The merged array is: ");
foreach (string s in array3)
{
    Console.WriteLine(s);
}
