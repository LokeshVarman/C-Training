using System;

struct rectangle
{
  public int length{get; set;}
  public int breadth{get; set;}

  public rectangle(int l, int b)
  {
    length=l;
    breadth=b;
  }

}

class Program{
static void fun1(rectangle r1)
{
  Console.WriteLine("Received in fun1 Rectangle:length {0}, Breadth {1}",r1.length, r1.breadth);
  r1.length=90;
  r1.breadth=80;
}

static void fun2(ref rectangle r1)
{
Console.WriteLine("Received in fun2 Rectangle:length {0}, Breadth {1}",r1.length, r1.breadth);
  r1.length=60;
  r1.breadth=30;
}
public static void Main(String [] args)
{
  rectangle r;
  r.length=9;
  r.breadth=10;
  Console.WriteLine("From Main: length {0}, breadth {1}", r.length, r.breadth);
  fun1(r);
  Console.WriteLine("From Main after fun1: length {0}, breadth {1}", r.length, r.breadth);
  fun2(ref r);
  Console.WriteLine("From Main after fun2: length {0}, breadth {1}", r.length, r.breadth);

}
}
