using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Steps { get; set; }
        public string FoodGroup { get; set; }
        public int Calories { get; set; }

        public Recipe(string name, List<string> ingredients, List<string> steps, string foodGroup, int calories)
        {
            Name = name;
            Ingredients = ingredients;
            Steps = steps;
            FoodGroup = foodGroup;
            Calories = calories;
        }
    }
}
// References
//Troelsen, A. and Japokse, P., 2022.PRo C# 10 with .NET 6 : Foundational Principles and Practices in Programming. 11th ed.  NEW York: Apress.(30 May 2024)