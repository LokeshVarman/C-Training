class Program
{​​
static void Main(string[] args)
{​​
Shape r1 = new Shape(2, "Rectangle");
Shape c1 = new Shape(2, "Circle");
Shape cr1 = new Shape(3, "Cube"); Console.WriteLine("Shape 1: "+ r1);
Console.WriteLine("Shape 2: Dimension"+ c1.Dimension + "Type: "+ c1.ShapeType);
Console.WriteLine($"Shape 3 Dimension {​​cr1.Dimension}​​ Type: {​​cr1.ShapeType}​​");
}​​
}​​

