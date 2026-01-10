abstract class Shape
{
  public string name;
  // abstract method (must be implemented by child)
  public abstract double Area();
  public void displayInfo()
  {
    Console.WriteLine($"Shape : {name} and it's area is {Area()}");
  }
}