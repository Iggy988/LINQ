
var numbers = new[] { 9, 3, 7, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var letters = new[] { 'a', 'b', 'c', };
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
var words = new[] { "one", "two", "three" };
var nestedListofNumbers = new List<List<int>>
{
    new List<int> { 1, 2, 3,},
    new List<int> { 4, 5, 6,},
    new List<int> { 5, 6 },
};
var nestedListOfNumbersComplex = new List<List<List<int>>>
{
    new List<List<int>>
    {
        new List<int> { 1, 2, 3,},
        new List<int> { 4, 5, 6,},
        new List<int> { 5, 6 },
    },
    new List<List<int>>
    {
        new List<int> { 10, 12, 13,},
        new List<int> { 14, 15, 16,},
    }
};
var people = new[]
{
    new PetOwner(1, "John", new[]{pets.ElementAt(0), pets.ElementAt(1)}),
    new PetOwner(2, "Jack", new[]{pets.ElementAt(2)}),
    new PetOwner(3, "Stephanie", new[]{pets.ElementAt(3), pets.ElementAt(4), pets.ElementAt(5)}),
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
Console.WriteLine();
Console.WriteLine();

//select
Console.WriteLine("Select");
var tripled = from number in numbers
              select number * 3;
Printer.Print(tripled, nameof(tripled));
var toUppercase = from word in words
              select word.ToUpper();
Printer.Print(toUppercase, nameof(toUppercase));
var namesOnly = from pet in pets
                select pet.Name;
Printer.Print(namesOnly, nameof(namesOnly));
var heavyPetTypees = (from pet in pets
                     where pet.Weight > 4
                     select pet).Distinct();
Printer.Print(heavyPetTypees, nameof(heavyPetTypees));
var petInitials = from p in pets
              orderby p.Name
              select $"{p.Name.First()}";
Printer.Print(petInitials, nameof(petInitials));
var petsData = from pet in pets
               select $"Pet name: {pet.Name}, {pet.Weight} of type: {pet.PetType}";
Printer.Print(petsData, nameof(petsData));
Console.WriteLine();
Console.WriteLine();

//SelectMany
Console.WriteLine("SelectMany");
var allNumbers = from list in nestedListofNumbers
                 from number in list
                 select number;
Printer.Print(allNumbers, nameof(allNumbers));
var petsOfPeople = from person in people
                   where person.Name.StartsWith("J")
                   from pet in person.Pets
                   select pet;
Printer.Print(petsOfPeople, nameof(petsOfPeople));
var result = new List<string>();
foreach (var number in numbers)
{
    foreach (var letter in letters)
    {
        result.Add($"{number},{letter}");
    }
}
var querySyntaxResult = from number in numbers
                        from letter in letters
                        select $"{number},{letter}";
Printer.Print(querySyntaxResult, nameof(querySyntaxResult));
var flattenedNumbers = from nestedList in nestedListOfNumbersComplex
                       from list in nestedList
                       from number in list
                       select number;
Printer.Print(flattenedNumbers, nameof(flattenedNumbers));
Console.WriteLine();
Console.WriteLine();

//Group by
Console.WriteLine("Group by");
var groupedPets = from pet in pets
                  group pet by pet.PetType;
Printer.Print(groupedPets, nameof(groupedPets));
var petTypeWeightSum = groupedPets.ToDictionary(
    grouping => grouping.Key,
    grouping => grouping.Sum(pet => pet.Weight));
Printer.Print(petTypeWeightSum, nameof(petTypeWeightSum));
//first group people by lether of their name
var peopleInitialsPetsMapping = (from person in people
                                 group person by person.Name.First())
                                 // use collection of groupings to build dixctionary
                                 //first key is letter of name is key of grouping and key of dictionary
                                 .ToDictionary(grouping => grouping.Key,
                                 //the value is name of pets belonging to people of group
                                 grouping => string.Join(",", from person in grouping
                                                              from pet in person.Pets
                                                              select pet.Name));
Printer.Print(peopleInitialsPetsMapping, nameof(peopleInitialsPetsMapping));
var petWeightGroup = from pet in pets
                     group pet by Math.Floor(pet.Weight) into grouping
                     orderby grouping.Key
                     let petsOrderedByWeight = from pet in grouping
                                               orderby pet.Weight
                                               select pet
                     select new
                     {
                         Key = grouping.Key,
                         LightesPet = petsOrderedByWeight.First(),
                         HeviestPet = petsOrderedByWeight.Last()
                     };
var petsWeightGroupAsString = from petWeightGrou in petWeightGroup
                              select $"Weight category: {petWeightGrou.Key}," +
                              $" heaviest pet: {petWeightGrou.HeviestPet.Name}," +
                              $" lightest pet: {petWeightGrou.LightesPet.Name}";
Printer.Print(petsWeightGroupAsString, nameof(petsWeightGroupAsString));



Console.ReadKey();
