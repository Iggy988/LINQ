
var numbers = new[] { 9, 3, 7, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var pets = new[]
{
     new Pet(1, "Hannibal", PetType.Fish, 1.1f),
     new Pet(2, "Antony", PetType.Cat, 2f),
     new Pet(3, "Ed", PetType.Cat, 0.7f),
     new Pet(4, "Taiga", PetType.Dog, 35f),
     new Pet(5, "Rex", PetType.Dog, 40f),
     new Pet(6, "Lucky", PetType.Dog, 5f),
     new Pet(7, "Storm", PetType.Cat, 0.9f),
     new Pet(8, "Nyan", PetType.Cat, 2.2f),
};



var orderedNumbers = from number in numbers
                     let floorOfSquere = Math.Floor(Math.Sqrt(number))
                     orderby floorOfSquere
                     select floorOfSquere;
Printer.Print(orderedNumbers, nameof(orderedNumbers));
Console.WriteLine();
Console.WriteLine();

//orderby
Console.WriteLine("orderby");
var orderedNumbersDesc = from number in numbers
                        orderby number descending
                        select number;
Printer.Print(orderedNumbersDesc, nameof(orderedNumbersDesc));
var petsOrderedByNameDesc = from pet in pets
                            orderby pet.Name descending
                            select pet;
Printer.Print(petsOrderedByNameDesc, nameof(petsOrderedByNameDesc));
var petsOrderedByTypeTnenId = from pet in pets
                            orderby pet.PetType, pet.Id
                            select pet;
Printer.Print(petsOrderedByTypeTnenId, nameof(petsOrderedByTypeTnenId));
var petsOrderedByNameDesc2 = (from pet in pets
                              orderby pet.Name
                              select pet).Reverse();
Printer.Print(petsOrderedByNameDesc2, nameof(petsOrderedByNameDesc2));
Console.WriteLine();
Console.WriteLine();

//where
Console.WriteLine("where");
var evenNumbers = from number in numbers
                  where number % 2 == 0
                  orderby number descending
                  select number;
Printer.Print(evenNumbers, nameof(evenNumbers));
var specificPets = from pet in pets
                   where (pet.PetType == PetType.Dog || pet.PetType == PetType.Cat) &&
                   pet.Weight < 10 &&
                   pet.Name.Length > 4
                   select pet;
Printer.Print(specificPets, nameof(specificPets));
var countOfCats = (from p in pets
                  where p.PetType == PetType.Cat
                  select p).Count();
Printer.Print(countOfCats, nameof(countOfCats));

Console.ReadKey();
