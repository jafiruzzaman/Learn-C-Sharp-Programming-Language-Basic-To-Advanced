class Person
{
  public string Name;
  public int Age;

  public Person()
  {
    Name = "Unknown";
    Age = 0;
  }
  public Person(string Name)
  {
    this.Name = Name;
  }
  public Person(string Name,int Age)
  {
    this.Name = Name;
    this.Age = Age;
  }
  // 
  public void Display() => Console.WriteLine($"Name : {Name} And Age : {Age}");
}