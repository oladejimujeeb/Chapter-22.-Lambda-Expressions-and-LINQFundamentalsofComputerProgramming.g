using System.Text;

namespace Chapter_22._Lambda_Expressions_and_LINQ;
public static class StringExtensions
{
    public static string Question1(this string word, int index, int length)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = index; i <length+index; i++)
        {
            sb.Append(word[i]);
        }
        
        return sb.ToString();
    }
}