namespace learn_object_oriented_programming_in_c_sharp
{
  public class LearnMatrix
  {
    public void Run()
    {
      Console.WriteLine("======================================================= All About 2D Arrays Or Matrix In C# =======================================================");
      int[,] matrix = new int[2, 3]
      {
        { 1, 2, 3 },
        { 4, 5, 6 },
      };
      // Accessing Array Elements
      Console.WriteLine("======================================================= Accessing 2D Array Elements In C# =======================================================");
      Console.WriteLine(matrix[1,2] + " ");
      Console.WriteLine("======================================================= Iterate On 2D Array/ Matrix In C# =======================================================");
      // Console.WriteLine(matrix); // return the type of matrix System.Int32[,]
      
      for (int i = 0; i < 2; i++)
      {
        for (int j = 0; j < 3; j++)
        {
          Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
      }
    }
  }
}
