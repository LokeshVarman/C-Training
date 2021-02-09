class Shape
{​​​​
public int Dimension {​​​​ get; set; }​​​​
public string ShapeType {​​​​ get; set; }​​​​ public Shape()
{​​​​
Dimension = 0;
ShapeType = "undefined";
}​​​​
public Shape(int dimension, string shapetype)
{​​​​
Dimension = dimension;
ShapeType = shapetype;
}​​​​ public override string ToString()
{​​​​
return $"Dimension: {​​​​Dimension}​​​​, Type: {​​​​ShapeType}​​​​";
}​​​​
}​​​​

