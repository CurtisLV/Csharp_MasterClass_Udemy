using _55_CookieCookbook.App;
using _55_CookieCookbook.DataAccess;
using _55_CookieCookbook.FileAccess;
using _55_CookieCookbook.Recipes.Ingredients;

try
{
    // define if saved in .txt or .json
    const FileFormat Format = FileFormat.Json;

    //const FileFormat Format = FileFormat.Txt;

    const string FileName = "recipes";
    const string BaseDirectory =
        "C:\\Users\\s3257b\\Desktop\\github.CurtisLV\\Csharp_MasterClass_Udemy\\55_CookieCookbook\\Files";

    //string filePath = Format == FileFormat.Json ? $"{FileName}.json" : $"{FileName}.txt";

    var fileMetadata = new FileMetadata(FileName, Format);

    string fullFilePath = BaseDirectory + "\\" + fileMetadata.ToPath();

    IStringsRepository stringsRepository =
        Format == FileFormat.Json ? new StringsJsonRepository() : new StringsTextualRepository();

    var ingredientsRegister = new IngredientRegister();

    var cookieRecipeApp = new CookieRecipeApp(
        new RecipesRepository(stringsRepository, ingredientsRegister),
        new RecipesConsoleUserInteraction(ingredientsRegister)
    );
    cookieRecipeApp.Run(fullFilePath);
}
catch (Exception ex)
{
    Console.WriteLine($"Sorry! The application experienced an unexpected error and will have to be closed." 
        + $"The error message: {ex.Message}");
	throw;
}

