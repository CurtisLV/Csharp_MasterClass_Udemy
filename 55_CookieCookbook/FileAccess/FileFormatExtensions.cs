using _55_CookieCookbook.FileAccess;

public static class FileFormatExtensions
{
    public static string AsFileExtension(this FileFormat fileFormat) =>
        fileFormat == FileFormat.Json ? "json" : "txt";
}



//// if the defined file is not empty, print all existing recipess
//if (File.Exists(fullFilePath))
//{
//    List<string> allRecipes = savingTxt.Read(fullFilePath);
//    PrintAllRecipes(allRecipes);
//}

//Console.WriteLine("Create a new cookie recipe! Available ingredients are:");

//List<string> selectedIngredients = new List<string>();

//// Printing available ingredients
//foreach (Ingredient ingredient in ingredients)
//{
//    Console.WriteLine($"{ingredient.Id}. {ingredient.Name}");
//}

//while (true)
//{
//    Console.WriteLine("Add an ingredient by it's ID or type anything else if finished.");

//    var input = Console.ReadLine();
//    if (!int.TryParse(input, out int selectedId))
//    {
//        break;
//    }

//    Ingredient ingredientData = ingredients.Find(ingredient => ingredient.Id == selectedId);

//    if (ingredientData != null)
//    {
//        selectedIngredients.Add(ingredientData.Id.ToString());
//    }
//    else
//    {
//        break;
//    }
//}

//if (selectedIngredients.Count > 0)
//{
//    string joinedSelectedIngredients = string.Join(",", selectedIngredients);
//    // Happy flow
//    Console.WriteLine("Recipe added:");
//    // Newly added recipe is printed TODO
//    PrintOneRecipe(joinedSelectedIngredients);
//    // Store recipe in the txt/json file TODO

//    savingTxt.Write(fullFilePath, new List<string> { joinedSelectedIngredients });
//}
//else
//{
//    Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
//}
