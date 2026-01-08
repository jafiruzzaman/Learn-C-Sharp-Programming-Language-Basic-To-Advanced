class Animals
{
  public string name;
  // Virtual method can be overridden
  public virtual void MakeSound()
  {
    Console.WriteLine($"Name: {name} make sound.");
  }
}

class Cat : Animals
{
  public Cat(string name)
  {
    this.name = name;
  }
  // override the Animals makeSound method
  public override void MakeSound()
  {
    Console.WriteLine($"{name} MakeSound like 🐈 Meow");
  }
}