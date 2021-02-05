using System;
class App
{

static bool Calc(int a, int b, out int add, out int sub, out int multi, out int division)
{
   
bool result=False;
if (b!=0)
{
    
result=True;
add=a+b;
sub=a-b;
multi=a*b;
division=a/b;
}
return result;
}

static void Main(string [] args)
{
int add, sub, multi, div;
bool possible=Calc(10,30,out add, out sub, out multi, out division);
}
}