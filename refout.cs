using System;
class singleDarry
{
  public static int add(int a, int b)
  {
    return a+b;
  }

  static int updateValue(int v, ref int r , out int o)
  {
      o=r-v;
      r=r+v;
      return o+r+v;
  }

  public static void Main(string [] args)
  {
   int a=10, b=20;
    int c=90,d;
    d=updateValue(a, ref b, out c);
    Console.WriteLine("a: " + a +"b: "+b+"c: "+c+"d: "+ d);
 
  }
}