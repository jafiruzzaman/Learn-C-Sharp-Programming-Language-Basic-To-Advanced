class Animal
{
  public string name;
  public void Eat()
  {
    Console.WriteLine(name+" is Eating.");
  }
}

class Dog: Animal
{
  public void Bark()
  {
    Console.WriteLine($"{name} is Barking.");
  }
}