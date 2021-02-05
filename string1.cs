using System;
class App
{
  static void Main(string [] args)
  {
    int n;
    Console.Write("Enter how many Strings:");
    n=Convert.ToInt32(Console.ReadLine());
    string [] liststring=new string[n];
    for(int i=0;i<n;)
    {
      Console.WriteLine("Enter Text:");
      string text=Console.ReadLine();
      if (String.IsNullOrWhiteSpace(text))
      {
        Console.WriteLine("Input Not received!!");
        continue;
      }
      liststring[i]=text;
    i++;
    }
    string joined=String.Join('|',liststring);
    Console.WriteLine(joined);
  }
}