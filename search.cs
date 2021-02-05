using System;
class App
{
  static void Main(string [] args)
  { 
    string [] brand = new string[4]{"Audi","BMW","Mahindra","Lambo"};
    Console.Write("Enter the brand name to check it's availability");
    string text=Console.ReadLine();
    if (String.IsNullOrWhiteSpace(text))
    {
      Console.WriteLine("Input Not received!!");
    }
    else
    {
    
    foreach (string x in brand){
      if(text.Contains(x)){
        Console.WriteLine("available");
      }
    }
    }
  }
}