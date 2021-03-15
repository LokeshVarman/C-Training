using System;
namespace Overloading
{
public class Calculatesum
{
public void addnumbers(int a,int b) //method overloading
{
Console.WriteLine("a+b={0}",a+b);
}
public void addnumbers(int a,int b,int c)
{
Console.WriteLine("a+b+c={0}{1}",a+b+c,a); //same method name with different parameteters
}
public void addnumbers(double a,int b,int c)
{
Console.WriteLine("a+b+c={0}",a+b+c);
}
}
class program
{
static void Main(string[] args)
{
Calculatesum c=new Calculatesum();
c.addnumbers(1,2); //method call
c.addnumbers(1,5,2);
c.addnumbers(4.0,3,1);
}
}
}
