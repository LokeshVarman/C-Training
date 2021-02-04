using System;
namespace ConsoleApplication{
  //make an enumerator month
  enum month {
    jan,
    feb,
    mar,
    apr,
    may,
    june
  }
 
  class enumuse{
    //Main method 
    static void Main(string[] args){
      var daysType= typeof(month);
      Console.WriteLine(daysType);
      //getting the integer values of data members
      Console.WriteLine("Value of jan : "+(int)month.jan);
      Console.WriteLine("Value of feb : "+(int)month.feb);
      Console.WriteLine("Value of apr : "+(int)month.apr);
      Console.WriteLine("Value of june : "+(int)month.june);

    //additional Part 
      string name = Enum.GetName( daysType , 1 ) ;
      Console.WriteLine( "\n2nd Index: " + name ) ;
      bool flag = Enum.IsDefined( daysType , "Mon" ) ;
      Console.WriteLine( "Contains Mon?: " + flag ) ;
    }
  }
}