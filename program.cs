class Program
{
    static void Main(string[] args)
    {
        try
               {
                  result = Calculator.add(5,7);
                  if (int.IsNaN(result))
                  {
                     Console.WriteLine("This operation will result in a mathematical error.\n");
                  }
                  else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                   Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }
        return;
    }
}