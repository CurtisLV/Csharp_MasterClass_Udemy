namespace _60_LINQ.SampleData;

public static class Data
{
    public static IEnumerable<Pet> Pets = new[]
    {
        new Pet(1, "Hannibal", PetType.Fish, 1.1f),
        new Pet(2, "Anthony", PetType.Cat, 2f),
        new Pet(3, "Ed", PetType.Cat, 0.7f),
        new Pet(4, "Taiga", PetType.Dog, 35f),
        new Pet(5, "Rex", PetType.Dog, 40f),
        new Pet(6, "Lucky", PetType.Dog, 5f),
        new Pet(7, "Storm", PetType.Cat, 0.9f),
        new Pet(8, "Nyan", PetType.Cat, 2.2f)
    };

    public static IEnumerable<int> numbers = new[]
    {
        16,
        8,
        9,
        -1,
        2,
        -2,
        -1,
        8,
        7,
        12,
        -3,
        3,
        -7,
        6,
        16
    };

    public static IEnumerable<List<int>> listOfNumbers = new List<List<int>>
    {
        new List<int> { 15, -92, 74, 31, -48, 5 },
        new List<int> { -18, 60, -88, 42, 3, -67 },
        new List<int> { 89, -51, 22, -95, 76, 10 },
    };
}
