﻿public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    public void ShowMessage(string msg)
    {
        Console.WriteLine(msg);
    }

    public void Exit()
    {
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}