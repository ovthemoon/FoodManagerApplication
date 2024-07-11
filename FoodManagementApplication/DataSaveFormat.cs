using System.Collections.Generic;

interface IData { }

public class RecipeData : IData
{
    public List<Recipe> Recipes { get; set; }

}
public class IngredientData : IData
{
    public List<Ingredient> Ingredients { get; set; }
}
public class CaloryData : IData
{
    public List<CaloryInfo> CaloryInfos { get; set; }
}

