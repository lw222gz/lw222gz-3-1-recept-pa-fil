using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{
    /// <summary>
    /// 
    /// </summary>
    public class RecipeView : ViewBase, IRecipeView
    {
        public void Show(IRecipe recipe)
        {
            Header = recipe.Name;
            ShowHeaderPanel();

            Console.WriteLine("\nIngredienser:\n");
            foreach (Ingredient ingredient in recipe.Ingredients)
            {
                Console.WriteLine(ingredient);
            }

            Console.WriteLine("\nInstruktioner:");
            int Row = 1;
            foreach (string instruction in recipe.Instructions)
            {
            Console.WriteLine("\nSteg {0}: {1}", Row, instruction);
            Row++;
            }
        }

        public void Show(IEnumerable<IRecipe> recipes)
        {
            foreach (Recipe recipe in recipes)
            {
                Show(recipe);
                ContinueOnKeyPressed();
            }
        }
    }
}
