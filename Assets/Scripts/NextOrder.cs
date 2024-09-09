using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextOrder : MonoBehaviour
{
    // Start is called before the first frame update
    public Recipes dish;
    public int rand;
    public List<Recipes> menu = new List<Recipes>();
    void Start()
    {
        List<string> ingredients = new List<string>();
        int choice = UnityEngine.Random.Range(0,menu.Count-1);
        rand = UnityEngine.Random.Range(0,menu[choice].optionals.Count);
        
        dish = menu[choice];
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

        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
