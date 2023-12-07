

var numbers = new List<int> { 5, 3, 7, 1, 2, 4 };
var numbersWith10 = numbers.Append(10);

Console.WriteLine("Numbers: " + string.Join(", ", numbers));
Console.WriteLine("Numbers: " + string.Join(", ", numbersWith10));

var oddNumbers = numbers.Where(number => number % 2 == 1);
//var orderOddNumbers = oddNumbers.OrderBy(numb => numb);

//method chaining
var orderOddNumbers = numbers
    .Where(number => number % 2 == 1)
    .OrderBy(numb => numb);


Console.WriteLine("Numbers: " + string.Join(", ", oddNumbers));
Console.WriteLine("Numbers: " + string.Join(", ", orderOddNumbers));

Console.ReadKey();