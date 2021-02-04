using System;
class Test
{
  static void setUsertoVote(string name, int age=18)
  {
    if (age<18)
    {
      Console.WriteLine(name + " not eligible for vote in india as per age criteria");
    }
    else{
      Console.WriteLine(name + "is eligible for vote as you are "+ age + "years old!");
    }
  }
  public static void Main(string [] args)
  {
    setUsertoVote("Danny",6);
    setUsertoVote("Jhon");
    setUsertoVote("hennary",34);
  }
}