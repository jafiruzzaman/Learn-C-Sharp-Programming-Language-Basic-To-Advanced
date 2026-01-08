namespace learn_object_oriented_programming_in_c_sharp
{
  public class Operators
  {
    public void Run()
    {
      Console.WriteLine("======================================= Operators In C# =======================================");
      
      Console.WriteLine("======================================= Arithmetic Operators In C# =======================================");
      
      // Arithmetic Operators are =>  +,-,*,/,%
      int a = 10, b = 5;
      Console.WriteLine("The Addition of 10 + 5 = "+(a+b));
      Console.WriteLine("The subtraction of 10 - 5 = "+(a-b));
      Console.WriteLine("The multiplication of 10 * 5 = "+(a*b));
      Console.WriteLine("The division of 10 / 5 = "+(a/b));
      Console.WriteLine("The modulo of 10 % 5 = "+(a%b));
      
      // Assignment Operators => =,+=,-=,*=,/=,%=
      Console.WriteLine("======================================= Assignment Operators In C# =======================================");
      // equals (=)
      a = 50;
      Console.WriteLine("After Reassigning the value is = "+a);
      // plusequals(+=)
      Console.WriteLine("The value of 50 += 20 is = "+ (a += 20));
      // minus-equals(-=)
      Console.WriteLine("The value of 50 -= 20 is = "+ (a -= 20));
      // multiplication-equals(*=)
      Console.WriteLine("The value of 50 *= 20 is = "+ (a *= 20));
      // divide-equals(/=)
      Console.WriteLine("The value of 50 /= 20 is = "+ (a /= 20));
      // divide-equals(%=)
      Console.WriteLine("The value of 50 %= 20 is = "+ (a %= 20));
      
      // Comparison Operators => ==, !=, >, <, >=, <=
      Console.WriteLine("======================================= Comparison Operators In C# =======================================");
      int x = 10, y = 20;

      Console.WriteLine("10 == 20 : " + (x == y));
      Console.WriteLine("10 != 20 : " + (x != y));
      Console.WriteLine("10 > 20  : " + (x > y));
      Console.WriteLine("10 < 20  : " + (x < y));
      Console.WriteLine("10 >= 20 : " + (x >= y));
      Console.WriteLine("10 <= 20 : " + (x <= y));
      
      Console.WriteLine("======================================= Logical Operators In C# =======================================");

      // Logical Operators => &&, ||, !
      bool isAdult = true;
      bool hasID = false;

      Console.WriteLine("isAdult && hasID : " + (isAdult && hasID));
      Console.WriteLine("isAdult || hasID : " + (isAdult || hasID));
      Console.WriteLine("!isAdult         : " + (!isAdult));

      Console.WriteLine("======================================= Bitwise Operators In C# =======================================");

      // Bitwise Operators => &, |, ^, ~, <<, >>
      int p = 5;   // 0101
      int q = 3;   // 0011

      Console.WriteLine("p & q  : " + (p & q));
      Console.WriteLine("p | q  : " + (p | q));
      Console.WriteLine("p ^ q  : " + (p ^ q));
      Console.WriteLine("~p     : " + (~p));
      Console.WriteLine("p << 1 : " + (p << 1));
      Console.WriteLine("p >> 1 : " + (p >> 1));

      
      Console.WriteLine("======================================= Ternary Operator In C# =======================================");

      // Ternary Operator => condition ? trueValue : falseValue
      int age = 18;
      string result = (age >= 18) ? "Eligible to vote" : "Not eligible to vote";

      Console.WriteLine(result);

      
      Console.WriteLine("======================================= Type Operators In C# =======================================");

      Console.WriteLine("Type of int: " + typeof(int));
      Console.WriteLine("Size of int: " + sizeof(int));

    }
  }
}
