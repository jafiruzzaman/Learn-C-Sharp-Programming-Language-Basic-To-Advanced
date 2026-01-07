namespace learn_object_oriented_programming_in_c_sharp
{
  public class LearnString
  {
    public void Run()
    {
      Console.WriteLine("======================================================= All About Arrays In C# =======================================================");
      // String Creation
      string name = "Mohammad Jafiruzzaman Tuhin";
      string grettings = "Hello world";
      Console.WriteLine(name);
      Console.WriteLine(grettings);
      // string methods
      Console.WriteLine("======================================================= All About Strings In C# =======================================================");
      string text = "   Hello C# World!   ";
      
      // length
      Console.WriteLine(text.Length);
      
      // ToUpper() --> convert all character into 
      Console.WriteLine(text.ToUpper());
      
      // ToLower() --> convert all character into lower-case
      Console.WriteLine(text.ToLower());
      
      // replace --> replace a text to another text
      Console.WriteLine(text.Replace("World","universe"));
      
      // trim --> remove all the white spaces from left and right
      Console.WriteLine(text.Trim());
      
      // split --> divide according to condition
      string[] words = text.Trim().Split(' ');
      Console.WriteLine("Split words : "+string.Join(", ", words));
      
      // Contains() --> take input as string and return boolean
      Console.WriteLine("Contains 'C#': "+text.Contains("C#"));
      
      // IndexOf --> take input as string and return the index
      Console.WriteLine("Contains 'C#': "+text.IndexOf("C#"));
      
      // convert string to Char-Array
      Console.WriteLine("======================================================= All About Strings In C# =======================================================");
      char[] chars = text.ToCharArray();
      Console.WriteLine("Characters in Text is : " + string.Join(", ", chars));
      foreach (var c in chars)
      {
        Console.Write(c+" ");
      }
    }
  }
}
