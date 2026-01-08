namespace learn_object_oriented_programming_in_c_sharp
{
  public class LearnArray
  {
    public void Run()
    {
      Console.WriteLine("======================================================= All About Arrays In C# =======================================================");
      // 1. Declare and initialize separately
      // Declare
      int[] numbers = new int[5]; // size 5
      // initialize
      numbers[0] = 10;
      numbers[1] = 20;
      numbers[2] = 30;
      numbers[3] = 40;
      numbers[4] = 50;

      // 2. Declare and initialize together
      int[] scores = { 90, 80, 70, 60, 50 };
      Console.WriteLine("======================================================= Accessing Array Elements =======================================================");
      Console.WriteLine("First element: " + scores[0]);
      Console.WriteLine("Third element: " + scores[2]);
      // 3. Loop Throug Array
      Console.WriteLine("======================================================= Loop Throug Array =======================================================");
      Console.WriteLine("All elements in scores array:");
      for (int i = 0; i < scores.Length; i++)
      {
        Console.Write(scores[i] + " ");
      }
      Console.WriteLine();
      Console.WriteLine("======================================================= Common Array Elements =======================================================");
      int[] nums = { 10, 5, 30, 20, 15 };

      // Length
      Console.WriteLine("Length: " + nums.Length);

      // Sorting
      Array.Sort(nums);
      Console.WriteLine("Sorted: " + string.Join(", ", nums));

      // Reverse
      Array.Reverse(nums);
      Console.WriteLine("Reversed: " + string.Join(", ", nums));

      // Find element index
      int index = Array.IndexOf(nums, 20);
      Console.WriteLine("Index of 20: " + index);

      // Clear
      Array.Clear(nums, 0, 2); // clear first 2 elements
      Console.WriteLine("After Clear: " + string.Join(", ", nums));

    }
  }
}
