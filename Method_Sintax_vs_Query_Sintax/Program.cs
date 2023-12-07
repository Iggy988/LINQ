

var numbers = new [] { 5, 3, 7, 1, 2, 4, 12, 10, 4, 7, 5 };

var smallOrderedNumbersMethodSyntax = numbers
    .Where(num => num < 10)
    .OrderBy(num => num)
    .Distinct();

var smallOrderedNumbersQuerySyntax = 
    (from num in numbers
    where num < 10
    orderby num
    select num).Distinct();

Console.WriteLine(string.Join(", ", smallOrderedNumbersMethodSyntax) );
Console.WriteLine(string.Join(", ", smallOrderedNumbersQuerySyntax) );

Console.ReadKey();