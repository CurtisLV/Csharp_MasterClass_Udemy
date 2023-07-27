using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_CookieCookbook.Recipes.Ingredients
{
    public class Salt : Ingredient
    {
        public override int Id => 4;
        public override string Name => "Salt";
        public override string Description => "Sprinkle for taste while cooking.";
    }
}
