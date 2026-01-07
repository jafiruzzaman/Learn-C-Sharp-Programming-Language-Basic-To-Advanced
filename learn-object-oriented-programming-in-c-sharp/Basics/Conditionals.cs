namespace learn_object_oriented_programming_in_c_sharp
{
  public class Conditionals
  {
    public void Run()
    {
      Console.WriteLine("======================================= Conditionals In C# =======================================");

      // ========================= 1. IF STATEMENT =========================
      Console.WriteLine("\n--- IF Statement ---");
      Console.Write("Enter your age: ");
      int age = int.Parse(Console.ReadLine());

      if (age >= 18)
      {
        Console.WriteLine("You are an adult.");
      }

      // ========================= 2. IF - ELSE STATEMENT =========================
      Console.WriteLine("\n--- IF - ELSE Statement ---");
      Console.Write("Enter your marks: ");
      int marks = int.Parse(Console.ReadLine());

      if (marks >= 40)
      {
        Console.WriteLine("You passed the exam.");
      }
      else
      {
        Console.WriteLine("You failed the exam.");
      }

      // ========================= 3. IF - ELSE IF - ELSE STATEMENT =========================
      Console.WriteLine("\n--- IF - ELSE IF - ELSE Statement ---");
      Console.Write("Enter your score: ");
      int score = int.Parse(Console.ReadLine());

      if (score >= 80)
      {
        Console.WriteLine("Grade: A");
      }
      else if (score >= 70)
      {
        Console.WriteLine("Grade: B");
      }
      else if (score >= 60)
      {
        Console.WriteLine("Grade: C");
      }
      else if (score >= 40)
      {
        Console.WriteLine("Grade: D");
      }
      else
      {
        Console.WriteLine("Grade: F");
      }

      // ========================= 4. NESTED IF STATEMENT =========================
      Console.WriteLine("\n--- Nested IF Statement ---");
      Console.Write("Enter your age: ");
      int userAge = int.Parse(Console.ReadLine());

      Console.Write("Do you have a voter ID? (true/false): ");
      bool hasVoterId = bool.Parse(Console.ReadLine());

      if (userAge >= 18)
      {
        if (hasVoterId)
        {
          Console.WriteLine("You are eligible to vote.");
        }
        else
        {
          Console.WriteLine("You need a voter ID.");
        }
      }
      else
      {
        Console.WriteLine("You are not eligible to vote.");
      }

      // ========================= 5. SWITCH STATEMENT =========================
      Console.WriteLine("\n--- SWITCH Statement ---");
      Console.Write("Enter a number (1-5): ");
      int choice = int.Parse(Console.ReadLine());

      switch (choice)
      {
        case 1:
          Console.WriteLine("You selected One.");
          break;

        case 2:
          Console.WriteLine("You selected Two.");
          break;

        case 3:
          Console.WriteLine("You selected Three.");
          break;

        case 4:
          Console.WriteLine("You selected Four.");
          break;

        case 5:
          Console.WriteLine("You selected Five.");
          break;

        default:
          Console.WriteLine("Invalid choice!");
          break;
      }
    }
  }
}
