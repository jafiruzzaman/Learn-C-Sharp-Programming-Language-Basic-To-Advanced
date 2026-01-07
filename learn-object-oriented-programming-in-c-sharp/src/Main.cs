using System;
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
  }
}
