class Rectangle : Shape
{
  public int length;
  public int width;
  public Rectangle(int length,int width)
  {
    this.length = length;
    this.width = width;
  }
  public override double Area()
  {
    return width * length;
  }
}