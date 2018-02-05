using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//change this to xml one day

public static class RecipeBook{
    public static Ingredient Lettuce = new Ingredient("Lettuce", Ingredient.IngredientType.Filling);
    public static Ingredient Bread = new Ingredient("Bread", Ingredient.IngredientType.Bread);
    public static Ingredient Meat = new Ingredient("Meat", Ingredient.IngredientType.Meat);

    public static List<Ingredient> ingredients = new List<Ingredient>()
    {
        Lettuce,
        Bread,
        Meat
    };

    static Ingredient[] burgerRecipe = { Lettuce, Bread, Meat };

    public static List<Meal> meals = new List<Meal>()
    {
        new Meal("Burger",new Recipe(burgerRecipe))


    };

}
