using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CaloryInfo
{
    public string RecipeName { get; set; }
    public int Calories { get; set; }
    public int Protein { get; set; } // 단백질 (g)
    public int Fat { get; set; }     // 지방 (g)
    public int Carbohydrates { get; set; } // 탄수화물 (g)

    public CaloryInfo(int calories, int protein, int fat, int carbohydrates)
    {
        Calories = calories;
        Protein = protein;
        Fat = fat;
        Carbohydrates = carbohydrates;
    }

    public override string ToString()
    {
        return $"Calories: {Calories} kcal, Protein: {Protein} g, Fat: {Fat} g, Carbohydrates: {Carbohydrates} g";
    }
}