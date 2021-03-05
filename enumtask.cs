using System;

namespace MyApplication
{
  class Program
  {
    //string inp=Console.ReadLine();
    enum Level
    {
      Low,
      Medium,
      High
    }
    static void Main(string[] args)
    {
      Level myVar = Level.Low;
      switch(myVar) 
      {
        case Level.Low:
          Console.WriteLine("Low level");
          break;
        case Level.Medium:
          Console.WriteLine("Medium level");
          break;
        case Level.High:
          Console.WriteLine("High level");
          break;
      }    
    }
  }
}
