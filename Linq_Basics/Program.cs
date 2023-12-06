
var wordsNoUpperCase = new[]
{
    "quick", "run", "walk"
};

var wordsUpperCase = new[]
{
    "quick", "RUN", "walk"
};

Console.WriteLine(IsAnyWordUperCase(wordsNoUpperCase));
Console.WriteLine(IsAnyWordUperCase(wordsUpperCase));

var orderedWords = wordsNoUpperCase.OrderBy(word => word);   

Console.ReadKey();

//Linq method
static bool IsAnyWordUpperCase_Linq(IEnumerable<string> words)
{
    return words.Any(word => word.All(letter => char.IsUpper(letter)));
}

static bool IsAnyWordUperCase(IEnumerable<string> words)
{
    foreach (var word in words)
    {
        bool areAllUpperCase = true;
        foreach (var letter in word)
        {
            if (char.IsLower(letter))
            {
                areAllUpperCase = false;
            }
        }
        if (areAllUpperCase)
        {
            return true;
        }
    }
    return false;
}
