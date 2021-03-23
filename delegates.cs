using System;
class Program
{
static void add(int a, int b)
{
Console.WriteLine("Addition is {0}", a + b);
}
static void subtract(int a, int b)
{
Console.WriteLine("difference is {0}", a - b);
}
static void multiply(int a, int b)
{
Console.WriteLine("Multiplication is {0}", a * b);
}
static void divide(int a, int b)
{
Console.WriteLine("Division result is {0}", a / b);
}
public delegate void operation(int parm1, int parm2);
public static void perform(operation operate, int p1, int p2)
{
operate(p1, p2);
}

static void Main(string[] args)
{
operation operate = null;
//Console.WriteLine("calling function using delegate");
//operate += subtract;
//operate += multiply;
//operate += divide;
//operate(9, 3);



do
{
Console.WriteLine("Menu\n1. add \n2. add and subtract \n3. multiply and divide \n4. all above \n5. Raminder \n0. exit");
Console.WriteLine("Enter your Choice:");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
case 1:
operate = add;
break;
case 2:
operate = add;
operate += subtract;
break;
case 3:
operate = multiply;
operate += divide;
break;
case 4:
operate = add;
operate += subtract;
operate += multiply;
operate += divide;
break;
case 5:
//operate += delegate (int a, int b) { Console.WriteLine("Remainder is {0}", a % b); };//anynomous function
operate += (int a, int b) => { Console.WriteLine("Remainder is {0}", a % b); };//lambda expression
break;
case 0:
Console.WriteLine("Bye bye");
break;
default:
Console.WriteLine("Wrong Choice");
break;



}



if (choice == 0)
break;
else if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5)
{
Console.WriteLine("Enter two numbers");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
perform(operate, a, b);
}
} while (true);




}
}
}