using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meal : FoodItem {
    Recipe recipe;
    public Meal(string name, Recipe recipe)
        :base(name)
    {
        this.recipe = recipe;
    }
}
