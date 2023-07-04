//int firstSeasonNumber = 0;
//Season spring = (Season)firstSeasonNumber;

//decimal a = 10.01m;

//// implicit conversion
//int integer = 10;
//decimal b = integer;

//// explicit conversion
//decimal c = 10.01m;
//int d = (int)c;

//int secondSeasonNumber = 1;
//Season summer = (Season)secondSeasonNumber;
//Console.WriteLine(summer);

//Console.ReadKey();

//public enum Season
//{
//    Spring,
//    Summer,
//    Autumn,
//    Winter
//}




// casting with 'as' gives a null instead of runtime error
// so there should be a check 'if not null' when using 'as'

//pizza.AddIngridients(new Cheddar());
//pizza.AddIngridients(new Mozzarella());
//pizza.AddIngridients(new TomatoSauce());
//Console.WriteLine(pizza.ToString());

//var ingridient = new Ingredient();
//ingridient.PublicField = 10;

//Cheddar cheddar = new Cheddar();
//Console.WriteLine(cheddar.Name);
//cheddar.PublicField = 20;


//Ingredient ingredient1 = new Cheddar();
//Console.WriteLine(ingredient1.Name);

//Console.WriteLine("Value in ingridient " + ingridient.PublicField);
//Console.WriteLine("Value in cheddar " + cheddar.PublicField);

//Console.WriteLine(cheddar.PublicMethod());
//Console.WriteLine(cheddar.PrivateMethod());
//Console.WriteLine(cheddar.ProtectedMethod());

//var cheddar = new Cheddar(2, 12);
//Console.WriteLine(cheddar);

//Ingredient ingredient = new Cheddar(2, 12); // upcasting - converting from derived to base class
//Cheddar cheddar = (Cheddar)ingredient; // downcasting - converting from base to derived class;

//Console.WriteLine($"is object? {(ingredient is object)}");
//Console.WriteLine($"is igredient? {(ingredient is Ingredient)}");
//Console.WriteLine($"is cheddar? {(ingredient is Cheddar)}");
//Console.WriteLine($"is mozarella? {(ingredient is Mozzarella)}");

//Console.ReadKey();

//var ingredients = new List<Ingredient> { new Cheddar(), new Mozzarella(), new TomatoSauce() };

//foreach (var ingredient in ingredients)
//{
//    Console.WriteLine(ingredient.Name);
//}

class RandomPizzaGenerator
{
    Pizza Generate(int howManyIngredients)
    {
        var pizza = new Pizza();
        for (int i = 0; i < howManyIngredients; i++)
        {
            var randomIngredient = GenerateRandomIngredient();
            pizza.AddIngridients(randomIngredient);
        }
        return pizza;
    }

    Ingredient GenerateRandomIngredient()
    {
        var random = new Random();
        var number = random.Next(1, 4);
        if (number == 1)
        {
            return new Cheddar(2, 12);
        }
        if (number == 2)
        {
            return new TomatoSauce(1);
        }
        return new Mozzarella(2);
    }
}
