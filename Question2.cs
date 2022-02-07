namespace Chapter_22._Lambda_Expressions_and_LINQ;

public static class Question2
{
    public static decimal Sum<T>(this IEnumerable<T> number)
    {
        if (number.Count() == 0)
        {
            throw new ArgumentException("List must have at least one element!");
        }

        decimal result = 0;

        foreach (var item in number)
        {
            result += Convert.ToDecimal(item);
        }

        return result;
    }
    public static decimal Average<T>(this IEnumerable<T> nums)
    {
        if (nums.Count() == 0)
        {
            throw new ArgumentException("List must have at least one element!");
        }

        decimal result = 0;
        foreach (var item in nums)
        {
            result += Convert.ToDecimal(item);
        }
        return result / nums.Count();
    }
    
    public static decimal Min<T>(this IEnumerable<T> num)where T : IComparable<T>
    {
        if (num.Count() == 0)
        {
            throw new ArgumentException("List must have at least one element!");
        }

        decimal min = decimal.MaxValue;
        foreach (var item in num)
        {
            if (Convert.ToDecimal(item) < min)
            {
                min = Convert.ToDecimal(item);
            }
        }
        return min;
    }

    public static decimal Max<T>(this IEnumerable<T> num)where T : IComparable<T>
    {
        if (num.Count() == 0)
        {
            throw new ArgumentException("List must have at least one element!");
        }

        decimal max = decimal.MinValue;
        foreach (var item in num)
        {
            if (Convert.ToDecimal(item) > max)
            {
                max = Convert.ToDecimal(item);
            }
        }
        return max;
    }

}