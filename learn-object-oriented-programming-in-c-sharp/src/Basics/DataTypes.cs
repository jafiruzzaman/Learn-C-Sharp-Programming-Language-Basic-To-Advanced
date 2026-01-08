namespace learn_object_oriented_programming_in_c_sharp
{
  public class DataTypes
  {
    public void Run()
    {
      Console.WriteLine("=========================================== Learn About Data-Types ===========================================");
      /* What is Variable ? */
      /* Variable: a named memory location to store data */
      
      // declare a variable --> Create a variable don't assign any value its called declare variable
      int a;
      // initialize a variable --> Create a variable and assign value
      int b = 10;
      Console.WriteLine("The value of b = "+b);
      
      /* There are 2 types of Data-Types in C# */
      /*
        *1. Value Types
       * 2. Reference Types
       */
      
      // *1. Value Types
      /*
       * int --> 4 bytes  | integer number | int age = 20;
       * float --> 4 bytes | floating-point number | float height = 5.7f;
       * double --> 8 bytes | double precision value | double price = 779.99;
       * decimal --> 16 bytes | High precision values | decimal salary = 250000.50m;
       * bool --> 1 byte | True/False | bool isPassed = true;
       * char --> 2 bytes | Single Character | char grade = 'a';
       * byte --> 1 byte | range 0 to 255 | byte b = 255;
       * sbyte --> 1 byte | range -128 to 127 | sbyte sb = 127;
       * short --> 2 bytes | range -32768 to 32767 | short
       * ushort --> 2 bytes | range 0 to 65535 | ushort us = 65535;
       * long --> 8 byte | Large Positive integers | long population = 78000000000000;
       * ulong --> 8 bytes | Large Positive integers | ulong distance = 1500000000000000;
       */
      
      /*
       * Reference Types
       * Definition: Store reference(address) of the actual data in memory.
       * Memory: Stored on Heap(slower Access)
       * string --> Sequence of Characters | string name = "Alice";
       * object --> base type of all types | object obj = 10;
       * dynamic --> type determined at runtime | dynamic value = 100; value = "Hello";
       * Arrays --> collection of similar elements in contiguous location | int[] arr = {10,5,75,98,120};
       * Class --> Custom Objects | Car newCar = new Car();
      */
      
      // int
      int num = 50;
      Console.WriteLine("The value of num = "+num);
      // float
      float weight = 75.68f;
      Console.WriteLine("The value of weight = "+weight);
      // double
      double price = 1500.99;
      Console.WriteLine("The value of price = "+price);
      // decimal
      decimal salary = 250000.50m;
      Console.WriteLine("The value of salary = "+salary);
      // char
      char c = 'c';
      Console.WriteLine("The value of c = "+c);
      // bool
      bool isPassed= true;
      Console.WriteLine("The value of isPassed = "+isPassed);
      // byte
      byte byteValue = 255;
      Console.WriteLine("The value of byteValue = "+byteValue);
      // sbyte
      sbyte sbyteValue = -128;
      Console.WriteLine("The value of sbyteValue = "+sbyteValue);
      // short
      short shortValue = -32768;
      Console.WriteLine("The value of shortValue = "+shortValue);
      // ushort
      ushort ushortValue = 65535;
      Console.WriteLine("The value of ushortValue = "+ushortValue);
      // long
      long population = 10000000;
      Console.WriteLine("The value of population = "+population);
      // ulong
      ulong distance = 15000000000000000000;
      Console.WriteLine("The value of distance = "+distance);
      
      // Reference Type
      Console.WriteLine("=========================  ================================");
      // dynamic 
      dynamic dynamicValue = 124;
      Console.WriteLine("The value of dynamicValue = "+dynamicValue);
      dynamicValue = "Hello C#";
      Console.WriteLine("Change the DataType of dynamicValue = "+dynamicValue);
      
      // Arrays
      int[] arr = [5, 7, 8, 9, 7, 10];
      Console.WriteLine("The 1st value of arr is "+arr[0]);
    }
  }
}
