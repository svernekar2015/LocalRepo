public class Calculator
{
    public int add(int a, int b)
    {
        return a+b;
    }

    public int subtract(int a, int b)
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
}