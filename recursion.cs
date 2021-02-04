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