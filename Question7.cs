using System.Globalization;

namespace Chapter_22._Lambda_Expressions_and_LINQ;

public static class QuestionExtension
{
    public static string Question6(this string word)
    {
        var  capitalise = new CultureInfo("en-US", false).TextInfo.ToTitleCase(word);
        return capitalise;
    }
}