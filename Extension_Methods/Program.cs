

var words = new[]{"a", "bb", "ccc", "dddd"};
var wordsLongerThan2Letters = words.Where(word => word.Length > 2);
Console.WriteLine(string.Join(", ", wordsLongerThan2Letters));

var multilineString = @"Please give me ride on your back,
Said Duck to the Kengooroo:
Hey You, whu are you so sad,
Thats not your buissines,
Ok i will go now.";

var countOfLines = multilineString.GetCountOfLines();
Console.WriteLine(countOfLines);

Console.ReadKey();

public static class StringExtension
{
    public static int GetCountOfLines(this string input)
    {
        return input.Split("\n").Length;
    }
}
