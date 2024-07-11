using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ingredient
{
    public DateTime ExpirationTime { get; set; }
    public IngredientMeasurement Measurement { get; set; }

    public Ingredient()
    {

    }
    public Ingredient(DateTime expirationTime, IngredientMeasurement measurement)
    {
        ExpirationTime = expirationTime;
        Measurement = measurement;
    }

    public override string ToString()
    {
        return $"재료 이름 : {Measurement.Name},\n\n 유통기한 : {GetFormattedExpirationDate()}\t, {Measurement}";
    }

    public string GetFormattedExpirationDate()
    {
        return ExpirationTime.ToString("yyyy-MM-dd");
    }

    public string Print()
    {
        return ToString();
    }

    public string GetUniqueKey()
    {
        return $"{Measurement.Name}_{GetFormattedExpirationDate()}";
    }
    public string GetUniqueKey(string name, string date)
    {
        return $"{name}_{date}";
    }
}
