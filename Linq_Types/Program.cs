﻿var numbers = new[] { -1, 3, 5, 9, 20, 2, 16, 6, 10, 7, -10 };
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


//Average
Console.WriteLine("AVERAGE:");
var averageNumbers = numbers.Average();
Printer.Print(averageNumbers, nameof(averageNumbers));
var averageWeightOfPets = pets.Average( pet => pet.Weight);
Printer.Print(averageWeightOfPets, nameof(averageWeightOfPets));
//var averagePet = pets.Average();
//var emptyNumbers = new int[0];
//var average = emptyNumbers.Average();
Console.WriteLine();
Console.WriteLine();


//Sum
Console.WriteLine("SUM:");
var sumOfNumbers = numbers.Sum();
var sumOfWeights = pets.Sum(p =>  p.Weight);
Printer.Print(sumOfNumbers, nameof(sumOfNumbers));
Printer.Print(sumOfWeights, nameof(sumOfWeights));
var emptyNumbers = new int[0];
var sum = emptyNumbers.Sum();
Printer.Print(sum, nameof(sum));
Console.WriteLine();
Console.WriteLine();


//ElementAt/ElementAtOrDefault
Console.WriteLine("ELEMENTAT/ElementAtOrDefault:");
var secondNumber = numbers.ElementAt(1);
Printer.Print(secondNumber, nameof(secondNumber));
//var noExistingPet = pets.ElementAt(99);
//Printer.Print(noExistingPet, nameof(noExistingPet));
var noExistingPet = pets.ElementAtOrDefault(99);
Printer.Print(noExistingPet, nameof(noExistingPet));
Console.WriteLine();
Console.WriteLine();


//First/Last
Console.WriteLine("FIRST/LAST:");
var firstNumber = numbers.First();
Printer.Print(firstNumber, nameof(firstNumber));
var firstOdd = numbers.First(n => n % 2 == 1);
Printer.Print(firstOdd, nameof(firstOdd));
var lastDog = pets.Last(p => p.PetType == PetType.Dog);
Printer.Print(lastDog, nameof(lastDog));
//var lastPetHeavierThan100 = pets.Last(p => p.Weight > 100);
//Printer.Print(lastPetHeavierThan100, nameof(lastPetHeavierThan100));
var lastPetHeavierThan100 = pets.LastOrDefault(p => p.Weight > 100);
Printer.Print(lastPetHeavierThan100, nameof(lastPetHeavierThan100));
var heaviestPet = pets.OrderBy(p => p.Weight).Last();
Printer.Print(heaviestPet, nameof(heaviestPet));
Console.WriteLine();
Console.WriteLine();


//Single
Console.WriteLine("SINGLE:");
//var singleLargerThan100 = numbers.Single(n => n >100); /// ako ima vise elemenata vrati ce exception
//Printer.Print(singleLargerThan100, nameof(singleLargerThan100));
var singleArray = new[] { 16};
var singleElem = singleArray.Single();
Printer.Print(singleElem, nameof(singleElem));
var singleFish = pets.SingleOrDefault(p => p.PetType == PetType.Fish); // ako ima vise elemenata opet ce vratiti exception
Printer.Print(singleFish, nameof(singleFish));
Console.WriteLine();
Console.WriteLine();


//Where *(important)
Console.WriteLine("WHERE:");
var evenNumbers = numbers.Where(n => n %2 == 0);
Printer.Print(evenNumbers, nameof(evenNumbers));
var heavierThan10Kilos = pets.Where(p => p.Weight > 10);
Printer.Print(heavierThan10Kilos, nameof(heavierThan10Kilos));
var heavierThan100Kilos = pets.Where(p => p.Weight > 100);
Printer.Print(heavierThan100Kilos, nameof(heavierThan100Kilos));
var verySpecificPets = pets.Where(p => p.PetType == PetType.Cat || p.PetType == PetType.Dog && p.Weight > 10 && p.Id == 2);
Printer.Print(verySpecificPets, nameof(verySpecificPets));
var indexesSelectedByUser = new[] { 1,6,7};
var petsSelectedByUserAndLighterThan5Kilos = pets.Where((p, index) => p.Weight < 5 && indexesSelectedByUser.Contains(index));
Printer.Print(petsSelectedByUserAndLighterThan5Kilos, nameof(petsSelectedByUserAndLighterThan5Kilos));
int countOfHeavyPets1 = pets.Count(p =>p.Weight>30);
int countOfHeavyPets2 = pets.Where(p =>p.Weight>30).Count();
Printer.Print(countOfHeavyPets1, nameof(countOfHeavyPets1));
Printer.Print(countOfHeavyPets2, nameof(countOfHeavyPets2));
Console.WriteLine();
Console.WriteLine();


//Take/TakeLast/TakeWhile
Console.WriteLine("Take:");
var firstThreeNumbers = numbers.Take(3);
Printer.Print(firstThreeNumbers, nameof(firstThreeNumbers));
var last5Numbers = numbers.TakeLast(5);
Printer.Print(last5Numbers, nameof(last5Numbers));
var threeHeaviestPets = pets.OrderBy(p => p.Weight).Take(3);
Printer.Print(threeHeaviestPets, nameof(threeHeaviestPets));
var secondLargestNumber = numbers.OrderBy(n => n).TakeLast(2).First();
Printer.Print(secondLargestNumber, nameof(secondLargestNumber));
var sixtyPercentOfPets = pets.Take((int)(pets.Count() * 0.6));
Printer.Print(sixtyPercentOfPets, nameof(sixtyPercentOfPets));
var smallerThan20TakeWhile = numbers.TakeWhile( n => n < 20);
Printer.Print(smallerThan20TakeWhile, nameof(smallerThan20TakeWhile));
var allPetsBefore30Kilos = pets.TakeWhile(p => p.Weight <= 30);
Printer.Print(allPetsBefore30Kilos, nameof(allPetsBefore30Kilos));


Console.ReadKey();
