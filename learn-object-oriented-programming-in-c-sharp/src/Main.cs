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
    dataTypes.Run();
    // Operators In C#
    Operators operators = new Operators();
    operators.Run();
    // Conditionals In C#
    Conditionals conditionals = new Conditionals();
    // conditionals.Run();
    // Calculator Using Switch In C#
    Calculator calculator = new Calculator();
    calculator.Run();
  }
}
