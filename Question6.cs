namespace Chapter_22._Lambda_Expressions_and_LINQ;

public class Question6
{
    public static void Linq()
    {
        List<int> list = new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 21,28 };

        Console.WriteLine("Question 6");
        //LINQ
        var result = from numbers in list where (numbers % 3 == 0) && (numbers % 7 == 0) select numbers;
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        
        //Method Query
        Console.WriteLine("Second method");
        var getResult = list.Where(x => (x % 3 == 0) && (x % 7 == 0));
        foreach (var item in getResult)
        {
            Console.WriteLine(item);
        }
    }
}