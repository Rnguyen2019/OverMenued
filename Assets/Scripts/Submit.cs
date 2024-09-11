using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submit : MonoBehaviour
{
    public NextOrder nextOrder;
    private bool _ingredientsMatch = false;
    private bool incorrect = false;
    public List<string> selectedIngredients = new List<string>(){"bread","lettuce","meat"};
    public List<string> ingredients = new List<string>(){"lettuce","meat","1"};
    public string selectedPlate = "bowl";
    public string selectedAppliance = "grill";
    // Start is called before the first frame update
    void Start()
    {
        nextOrder = GetComponent<NextOrder>();
        for (int i = 0; i < ingredients.Count; i++)
        {
            for (int j = 0; j < selectedIngredients.Count; j++)
            {
                if (selectedIngredients[j].Equals(ingredients[i]))
                { 
                    _ingredientsMatch = true;
                    Debug.Log("Ingredients Match" + ingredients[i] + selectedIngredients[j]);
                }
            }
            if (_ingredientsMatch)
            {
                _ingredientsMatch = false;
            }
            else
            {
                Debug.Log("incoreect");
                incorrect = true;
                break;
            }
        }
//if it's fully correct
        if ( nextOrder.currentRecipe != null)
        {
            Debug.Log("12345678");
        }

        if (incorrect)
        {
            
        }
        else if (nextOrder.currentRecipe.appliance.Equals(selectedAppliance) && nextOrder.currentRecipe.plate.Equals(selectedPlate) && !incorrect)
        {
            
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
