using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    int a=10;
    int b=++a;
    ++a;
    int c=a++;
    a++;
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
  }
}