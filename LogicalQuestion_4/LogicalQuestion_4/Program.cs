using System;
Console.WriteLine("Enter the DOB: ");
var dob = DateTime.Parse(Console.ReadLine());
var today = DateTime.Today;
Console.WriteLine(today);
TimeSpan interval = dob - today;
Console.WriteLine("Age in hours: " + interval.Hours);
Console.WriteLine("Age in days: " + interval.Days);
Console.WriteLine("Age in weeks: " + (interval.Days / 7));
Console.WriteLine("Age in months: " + ((interval.Days / 365) * 12));
Console.WriteLine("Age in years: " + (interval.Days / 365));
var year = dob.Year;
if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
{
    Console.WriteLine("Leap year");
}
else
{
    Console.WriteLine("Not a leap year");
}
