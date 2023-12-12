var numbers = new[] { -1, 3, 5, 9, 2, 16, 6, 10, 7, -10 };
var words = new[] { "lion", "tiger", "leopard"};
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

//Any
Console.WriteLine("ANY:");
bool isAnyLargerThan10 = numbers.Any(num =>num > 10);
Console.WriteLine(isAnyLargerThan10);
var isAnyPetNamedBruce = pets.Any(p => p.Name == "Bruce");
Printer.Print(isAnyPetNamedBruce, nameof(isAnyPetNamedBruce));
var isAnyFish = pets.Any(p => p.PetType == PetType.Fish);
Printer.Print(isAnyFish, nameof(isAnyFish));
var isThereAVerySpecificPet = pets.Any(p => p.Name.Length > 6 && p.Id % 2== 0);
Printer.Print(isThereAVerySpecificPet, nameof(isThereAVerySpecificPet));
var isNotEmpty = pets.Any();
Printer.Print(isNotEmpty, nameof(isNotEmpty));
Console.WriteLine();
Console.WriteLine();

//All
Console.WriteLine("ALL:");
var areAllLargerThanZero = numbers.All(num => num > 0);
Printer.Print(areAllLargerThanZero, nameof(areAllLargerThanZero));
var doAllHaveNoEmptyNames = pets.All(p => !string.IsNullOrEmpty(p.Name));
Printer.Print(doAllHaveNoEmptyNames, nameof(doAllHaveNoEmptyNames));
var areAllPetsCats = pets.All(p => p.PetType == PetType.Cat);
Printer.Print(areAllPetsCats, nameof(areAllPetsCats));
Console.WriteLine();
Console.WriteLine();

//Count/LongCont
Console.WriteLine("COUNT/LONGCOUNT:");
var countOfDogs = pets.Count(p => p.PetType == PetType.Dog);
Printer.Print(countOfDogs, nameof(countOfDogs));
var countOfPetsNAmedBruce = pets.LongCount(p => p.Name == "Bruce");
Printer.Print(countOfPetsNAmedBruce, nameof(countOfPetsNAmedBruce));
var countOfAllSmallDogs = pets.Count(p => p.PetType == PetType.Dog && p.Weight < 10);
Printer.Print(countOfAllSmallDogs, nameof(countOfAllSmallDogs));
var allPetsCount = pets.Count();
Printer.Print(allPetsCount, nameof(allPetsCount));
Console.WriteLine();
Console.WriteLine();

//Contains
Console.WriteLine("CONTAINS:");
bool is7Present = numbers.Contains(7);
Printer.Print(is7Present, nameof(is7Present));
bool isLionPresent = words.Contains("lion");
Printer.Print(isLionPresent, nameof(isLionPresent));
// not the same object (different reference)
bool isHannibalPresent = pets.Contains(new Pet(1, "Hannibal", PetType.Fish, 1.1f));
Printer.Print(isHannibalPresent, nameof(isHannibalPresent));
//same object (same reference)
var hannibal = pets[0];
bool isRealHannibal = pets.Contains(hannibal);
Printer.Print(isRealHannibal, nameof(isRealHannibal));
bool isHannibalPresentCustomComparer = pets.Contains(new Pet(1, "Hannibal", PetType.Fish, 1.1f), new PetComparerById());
Printer.Print(isHannibalPresentCustomComparer, nameof(isHannibalPresentCustomComparer));
Console.WriteLine();
Console.WriteLine();

//OrderBy
Console.WriteLine("ORDERBY:");
var petsOrderedByName = pets.OrderBy(p => p.Name);
Printer.Print(petsOrderedByName, nameof(petsOrderedByName));
//Printer.Print(pets, nameof(pets));
var petsOrderedById = pets.OrderByDescending(p => p.Id);
Printer.Print(petsOrderedById, nameof(petsOrderedById));
var ordererdNumbers = numbers.OrderBy(n  => n);
Printer.Print(ordererdNumbers, nameof(ordererdNumbers));
var petsOrderByTypeThenName = pets.OrderBy(p => p.PetType).ThenBy(p => p.Name);
Printer.Print(petsOrderByTypeThenName, nameof(petsOrderByTypeThenName));
var petsOrderedByTypeWithComparer = pets.OrderBy(p => p, new PetByTypeComparer());
Printer.Print(petsOrderedByTypeWithComparer, nameof(petsOrderedByTypeWithComparer));
var petsReversed = pets.Reverse();
Printer.Print(petsReversed, nameof(petsReversed));
Console.WriteLine();
Console.WriteLine();

//Min/Max
Console.WriteLine("MIN/MAX:");
var smallest = numbers.Min();
Printer.Print(smallest, nameof(smallest));
var largest = numbers.Max();
Printer.Print(largest, nameof(largest));
var minWeight = pets.Min(p =>p.Weight);
var maxWeight = pets.Max(p =>p.Weight);
Printer.Print(minWeight, nameof(minWeight));
Printer.Print(maxWeight, nameof(maxWeight));
var minPet = pets.Min();
Printer.Print(minPet, nameof(minPet));
//var emptyNumbers = new int[0];
//var minimalNumber = numbers.Min();
Console.WriteLine();
Console.WriteLine();



Console.ReadKey();
