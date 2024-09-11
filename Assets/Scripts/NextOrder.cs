using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextOrder : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Recipes> menu = new List<Recipes>();
    public static List<string> ingredients;
    public Recipes currentRecipe;
    void Start()
    {
            ingredients = new List<string>();
            int choice = UnityEngine.Random.Range(0,menu.Count-1);
            int rand = UnityEngine.Random.Range(0,menu[choice].optionals.Count);
            currentRecipe = menu[choice];
        
            for (int i = 0; i < menu[choice].necessary.Count; i++)
            {
                ingredients.Add(menu[choice].necessary[i]);
            }
            if (rand != 0)
            {
                for (int i = 0; i <= rand; i++)
                {
                    ingredients.Add(menu[choice].optionals[i]);
                }
            }
            for (int i = 0; i < ingredients.Count; i++)
            {
                Debug.Log(ingredients[i]);
            }
            Debug.Log("--------------------");

        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
