namespace learn_object_oriented_programming_in_c_sharp
{
  public class Loops
  {
    public void Run()
    {
      Console.WriteLine("======================================= Loops In C# =======================================");
      // Loop: Loop is used to avoid repetitive works
      /*
        * There are 3 Types Of Loop
          1. For Loop
          2. While Loop
          3. Do-While Loop
       */
      Console.WriteLine("======================================= For Loop In C# =======================================");
      // 1. For Loop
      /*
        for(initialization,condition,updation){
          
       */
      for (int i = 1; i < 5; i++)
      {
        Console.Write(i+" ");
      }

      Console.WriteLine();
      // 2. while loop
      Console.WriteLine("======================================= while Loop In C# =======================================");
      int j = 1;
      while (j<5)
      {
        Console.Write(j+" ");
        j++; // if we don't update value the loop will be infinite 
      }
      Console.WriteLine();
      // 3. do-while loop
      Console.WriteLine("======================================= do-while Loop In C# =======================================");
      j = 15;
      do
      {
        Console.WriteLine(j + " ");
        j++;
      } while (j<14);
    }
  }
}
