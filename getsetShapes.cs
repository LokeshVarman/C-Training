
class Shape
{​​
private int dim;
private string shapeType;
public int Dimension => dim;
public string ShapeType {​​ get
{​​
return shapeType;
}​​
set
{​​
if(value.ToUpper()=="RECTANGLE"||value.ToUpper()=="CIRCLE"||value.ToUpper()=="CUBE")
{​​
shapeType = value;
}​​
else
{​​
shapeType = "UserDefined shape";
}​​
}​​
}​​ public Shape()
{​​
dim = 0;
//shapeType = "UserDefined shape";
ShapeType = "";
}​​
public Shape(int dimension, string shapetype)
{​​
dim = dimension;
ShapeType = shapetype;
}​​ public override string ToString()
{​​
return $"Dimension: {​​Dimension}​​, Type: {​​ShapeType}​​";
}​​
}​​

