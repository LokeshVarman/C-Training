using System;
class App
{
  static void Main(string [] args)
  {
    Console.WriteLine("Enter name:");
    string name=Console.ReadLine();
    Console. WriteLine("Enter Course:");
    string course=Console.ReadLine();
    Console.WriteLine("Enter Fees:");
    double fees=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Registered Date(mm/dd/yyy):");
    DateTime rd=Convert.ToDateTime(Console.ReadLine());

    Console.WriteLine("Details");
    Console.WriteLine("Name|Course|Fees|Registered Date");
    Console.WriteLine(String.Format("{1}|{0}|{2:C}|{3:D}", name,course,fees,rd));
    string name1 = "Mark";
    var date = DateTime.Now;
    Console.WriteLine($"Hello, {name1}! Today is {date.DayOfWeek,-10}, it's {date:HH:mm} now.");
    Console.WriteLine($"|{"Left",-7}|{"Right",7}|");

    string name2 = "Horace";
    int age = 34;
    Console.WriteLine($"He asked, \"Is your name {name2}?\", but didn't wait for a reply :-{{");
    Console.WriteLine($"{name2} is {age} year{(age == 1 ? "" : "s")} old.");
    ////verbatium String

    string[] @for = { "John", "James", "Joan", "Jamie" };
    for (int ctr = 0; ctr < @for.Length; ctr++)
    {
        Console.WriteLine($"Here is your gift, {@for[ctr]}!");
    }
  }
}