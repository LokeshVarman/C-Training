using System;
//program to accept user details.
class MainClass {
public static void Main (string[] args) {
  Console.WriteLine("Enter Date(yyyy, mm,dd) format:");
  int y=Convert.ToInt32(Console.ReadLine());
  int m=Convert.ToInt32(Console.ReadLine());
  int d=Convert.ToInt32(Console.ReadLine());
  DateTime date=new DateTime(y,m,d);
  Console.WriteLine("{0:D}",date);
}
}