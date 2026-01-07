class Student
{
  // attributes
  public string name;
  public string surname;
  public int age;
  public string gender;

  // What is Constructor ?
  // Constructor is Special Method to Initialize Object
  public Student(string name, string surname, int age, string gender)
  {
    this.name = name;
    this.surname = surname;
    this.age = age;
    this.gender = gender;
  }

  public void sayHello()
  {
    Console.WriteLine("Hello. ");
  }
}