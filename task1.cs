using System;
class MainClass {
  public static void Main (string[] args) {
  bool status = true;
  while(status)
  {
    Console.WriteLine("Enter your name: ");
    string name = Console.ReadLine();
    if (name == "stop")
    status = false;
  }

 

  Console.ReadLine();
   
  }
}