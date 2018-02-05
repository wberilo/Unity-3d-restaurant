using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Ingredient : FoodItem {
    public enum IngredientType {Bread,Meat,Filling};
    public IngredientType ingType;
    

    public Ingredient(string name,IngredientType ingType)
        :base(name)
    {
        this.ingType = ingType;
    }

   
}
