namespace CSharp11Features;

public class ListPatterns
{
    public void IntPattern()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine(numbers is [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
            ? "The array contains 1 to 10"
            : "The array does not contain 1 to 10");

        if (numbers is [var first, .. var rest])
        {
            Console.WriteLine($"The first element is {first}");
            Console.WriteLine($"The rest of the elements are {string.Join(", ", rest)}");
        }
    }
}