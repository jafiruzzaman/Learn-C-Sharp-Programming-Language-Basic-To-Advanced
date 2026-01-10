using learn_object_oriented_programming_in_c_sharp;

class Program
{
  public static void Main(string[] args)
  {
    ProgramStructure programStructure = new ProgramStructure();
    programStructure.Run();
    // Data-Types
    DataTypes dataTypes = new DataTypes();
    // dataTypes.Run();
    // Operators In C#
    Operators operators = new Operators();
    // operators.Run();
    // Conditionals In C#
    Conditionals conditionals = new Conditionals();
    // conditionals.Run();
    // Calculator Using Switch In C#
    Calculator calculator = new Calculator();
    // calculator.Run();
    Loops loops = new Loops();
    loops.Run();
    // Arrays
    LearnArray learnArray = new LearnArray();
    learnArray.Run();
    // Strings
    LearnString learnString = new LearnString();
    learnString.Run();
    // 2D Array or Matrix
    LearnMatrix learnMatrix = new LearnMatrix();
    learnMatrix.Run();
    // learn about classes and Objects

    // Create Object with the instance Of Class
    Car car = new Car();
    // Access Properties
    car.brand = "BMW";
    car.model = "M5 Competition";
    car.year = 2020;
    Console.WriteLine(car.brand + " " + car.model + " " + car.year);

    // Inheritance
    Dog dog = new Dog();
    dog.name = "Bob"; 
    dog.Eat(); // 🐕 inherit from Animal class
    dog.Bark(); // own property
    // Compile Time Polymorphism
    Console.WriteLine("====================================================== Compile Time Polymorphism ======================================================");
    // default constructor
    Person person = new Person();
    person.Display();
    // overloaded constructor 1 value
    Person person1 = new Person("Mohammad");
    person1.Display();
    // overloaded constructor 2 values
    Person person2 = new Person("Mohammad Jafiruzzaman",22);
    person2.Display();

    // Run Time Polymorphism
    Console.WriteLine("====================================================== Runtime Time Polymorphism ======================================================");
    Cat cat = new Cat("Tubla"); // 🗒️ we can write also like this 🫳 Cat cat = new("Tubla");
    cat.MakeSound();
    // Abstraction
    Console.WriteLine("====================================================== Abstraction In C# ======================================================");
    Shape circle = new Circle("Circle",7.67);
    circle.displayInfo();
  }
}
