public class Calculator
{
    public static int add(int a, int b)
    {
        return a+b;
    }

    public static int subtract(int a, int b)
    {
        if(a > b)
        {
            return a-b;
        }
        else
        {
            return 0;
        }

    }

    public static int multiply(int a, int b)
    {
        return a*b;
    }

    public static int divide(int a, int b)
    {
        if (a != 0 || b != 0)
        return a/b;
    }
}