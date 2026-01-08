class Animal
{
  public string Name;
  public void Eat()
  {
    Console.WriteLine(Name+" is Eating.");
  }
}

class Dog: Animal
{
  public void Bark()
  {
    Console.WriteLine($"{Name} is Barking.");
  }
}