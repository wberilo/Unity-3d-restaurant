using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FoodItem : MonoBehaviour {
    public string _name;

    public FoodItem(string name)
    {

        _name = name;
    }
}
