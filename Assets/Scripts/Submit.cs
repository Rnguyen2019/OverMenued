using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submit : MonoBehaviour
{
    private bool _ingredientsMatch = false;
    public List<string> selectedIngredients = new List<string>(){"bread","lettuce","meat"};
    public List<string> ingredients = new List<string>(){"lettuce","meat","1"};
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < ingredients.Count; i++)
        {
            for (int j = 0; j < selectedIngredients.Count; j++)
            {
                if (selectedIngredients[i].Equals(ingredients[j]))
                { 
                    _ingredientsMatch = true;
                    Debug.Log(_ingredientsMatch.ToString() + selectedIngredients[i] + selectedIngredients[j]);
                }
            }
            if (_ingredientsMatch)
            {
                Debug.Log("Ingredients Match" + ingredients[i] + selectedIngredients[i]);
                _ingredientsMatch = false;
            }
            else
            {
                Debug.Log("incoreect");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
