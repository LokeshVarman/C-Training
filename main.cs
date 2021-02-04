
using System;
class singleDarry
{
  static int factorial(int n){
    int res;
    if(n==0){
      res=1;
    }
    else{
      res=n*factorial(n-1);
    }
  return res;
    

  }

  public static void Main(string [] args)
  {
   Console.WriteLine(factorial(5));
  }
}
/** mcs -out:main.exe main.cs
 mono main.exe **/



/**  Console.WriteLine(Convert.ToDouble(1==1)); for converting true to 1 and false to 0 ;

  ** Ternary operator
   Console.WriteLine("Enter the number");
   int num=Convert.ToInt32(Console.ReadLine());
   Console.WriteLine((num%2==0)? "Even":"Odd");

**/