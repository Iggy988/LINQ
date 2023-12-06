
var numbers = new[] { 1, 2, 3, 4, 99, 256, 7 };

bool isAnyLargerThan100 = IsAnyLargerThan100(numbers);
Console.WriteLine($"Is any > 100?: {isAnyLargerThan100}");

bool isAnyEven = IsAnyEven(numbers);
Console.WriteLine($"Is any Even?: {isAnyEven}");

bool isAny = IsAny(numbers, IsAnyEven_Short);
Console.WriteLine(isAny);

bool isAnyLarger = IsAny(numbers, IsAnyLargerThan90);
Console.WriteLine(isAnyLarger);

bool isAny_Lambda = IsAny(numbers, number => number % 2== 0);
Console.WriteLine(isAny_Lambda);

bool isAnyLarger_Lambda = IsAny(numbers, number => number >100);
Console.WriteLine(isAnyLarger_Lambda);

bool isAnyLargerThan80 = IsAny(numbers, number =>
{
    const int max = 80;
    return number >= max;
});

var words = new[] { "aaa", "BBBB", "ccc" };

bool isAnyLenght4 = IsAnyT(words, word => word.Length == 4);
Console.WriteLine(isAnyLenght4);


Console.ReadKey();

//ne moze var (implicitly declared)
Func<int, bool> isAnyEvenFunc = number => number % 2 == 0;


static bool IsAnyLargerThan90(int number)
{
    return number > 100;
}

static bool IsAnyEven_Short(int number)
{
    return number % 2 == 0;
}

static bool IsAnyT<T>(IEnumerable<T> numbers, Func<T, bool> predicate)
{
    foreach (var number in numbers)
    {
        if (predicate(number))
        {
            return true;
        }
    }
    return false;
}

static bool IsAny(int[] numbers, Func<int, bool> predicate)
{
    foreach (int number in numbers)
    {
        if (predicate(number))
        {
            return true;
        }
    }
    return false;
}



static bool IsAnyLargerThan100(int[] numbers)
{
    foreach (int number in numbers)
    {
        if (number > 100) return true;
    }

    return false;
}

static bool IsAnyEven(int[] numbers)
{
    foreach (int number in numbers)
    {
        if (number % 2 == 0) return true;
    }

    return false;
}