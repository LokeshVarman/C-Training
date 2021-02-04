using System;
namespace //Hello{


class MainClass {
  public static void Main (string[] args) {

    

Console.WriteLine ("Enter your name:");
    string name=Console.ReadLine();
    Console.WriteLine("Enter your Age:");
    int age=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Father's Age:");
    int fage=Convert.ToInt32(Console.ReadLine());
    int diff=fage-age;
    Console.WriteLine("your father is "+ diff + " older than you!!");
}
}}