
var numbers = new[] { 9, 3, 7, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


var orderedNumbers = from number in numbers
                     let floorOfSquere = Math.Floor(Math.Sqrt(number))
                     orderby floorOfSquere
                     select floorOfSquere;
Printer.Print(orderedNumbers, nameof(orderedNumbers));











Console.ReadKey();
