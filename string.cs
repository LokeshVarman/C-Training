using System;
class App
{
  static void Main(string [] args)
  {
    Console.WriteLine("Enter Text:");
    string text=Console.ReadLine();
    if (String.IsNullOrWhiteSpace(text))
    {
      Console.WriteLine("Input Not received!!");
    }
    else
    {
      Console.WriteLine("Is StarsWith C#: "+text.StartsWith("C#"));
      Console.WriteLine("Is endsiwth steps:"+text.EndsWith("steps"));
      Console.WriteLine("Is contains easy:"+text.Contains("easy"));
      Console.WriteLine("In upper: "+text.ToUpper());
      Console.WriteLine("In Lower:"+text.ToLower());
      Console.WriteLine("PadLeft #"+text.PadLeft(40,'*'));
      Console.WriteLine("PadRight #"+text.PadRight(40,'*'));
      Console.WriteLine("Padleft and right:"+ text.PadLeft(10,'*').PadRight(15,'-'));
    }
  }
}