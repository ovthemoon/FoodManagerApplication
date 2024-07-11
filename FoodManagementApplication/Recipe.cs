using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Recipe
{
    public string Name { get; set; }
    public List<IngredientMeasurement> Ingredients { get; set; } = new List<IngredientMeasurement>();
    public string Method { get; set; }
    public Recipe()
    {
        Ingredients = new List<IngredientMeasurement>();
    }
    public Recipe(string name, string method,params IngredientMeasurement[] ingredients)
    {
        Name = name;
        Ingredients.AddRange(ingredients);
        Method=method;
    }
    public Recipe(string name, string method, List<IngredientMeasurement> ingredients)
    {
        Name = name;
        Ingredients = ingredients;
        Method=method;
    }

    public override string ToString()
    {
        string text = $"레시피 : {Name}, 재료 :";
        text += string.Join(", ", Ingredients.Select(i => i.ToString()));
        return text;
    }
}