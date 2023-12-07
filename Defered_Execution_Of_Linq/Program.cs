

var words = new List<string> { "a", "bb", "ccc", "dddd"};

//creation, not execution
var shortWords = words.Where(word => word.Length < 3).ToList();

Console.WriteLine("First iteration");
//execution
foreach (var word in shortWords)
{
    Console.WriteLine( word);
}

words.Add("e");
Console.WriteLine("Second iteration");
foreach (var word in shortWords)
{
    Console.WriteLine(word);
}

var people = new List<Person>
{
    new Person("John", "USA"),
    new Person("Betty", "UK")
};

var allAmericans = people.Where(person => person.Country == "USA");
var notAllAmericans = allAmericans.Take(100);

foreach (var person in allAmericans)
{
    Console.WriteLine(person);
}

Console.ReadKey();

public class Person
{
    public string Name;
    public string Country;

    public Person(string name, string country)
    {
        Name = name;
        Country = country;
    }

    public override string ToString()
    {
        return $"{Name}, {Country}";
    }
}

