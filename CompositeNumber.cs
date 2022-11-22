namespace CSharp11Features;

public static class CompositeNumber
{
    //Check if a Number is Composite 
    public static bool IsComposite(this int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return true;
        }

        return false;
    }
}