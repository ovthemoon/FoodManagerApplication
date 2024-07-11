using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class IngredientMeasurement
{
    public string Name { get; set; }
    public float Quantity { get; set; }
    public Unit Unit { get; set; }

    
    public IngredientMeasurement(string name, float quantity, Unit unit)
    {
        Name = name;
        Quantity = quantity;
        Unit = unit;
    }

    public override string ToString()
    {
        return $"{Name} {Quantity} {Unit}";
    }
}