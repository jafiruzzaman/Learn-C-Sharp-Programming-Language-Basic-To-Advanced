class Circle : Shape
{
  public double radius;
  public Circle(string name,double radius)
  {
    this.name = name;
    this.radius = radius;
  }
  public override double Area()
  {
    return Math.PI * radius * radius;
  }
}