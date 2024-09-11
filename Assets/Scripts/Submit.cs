using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submit : MonoBehaviour
{
    private bool _ingredientsMatch = false;
    private bool incorrect = false;
    public List<string> selectedIngredients = new List<string>(){"1","2","3"};
    public List<string> ingredients = new List<string>(){"2","3","1"};
    public string selectedPlate = "bowl";
    public string selectedAppliance = "grill";
    // Start is called before the first frame update
    void Start()
    {
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
        if (NextOrder.menu[NextOrder.choice].appliance.Equals(selectedAppliance) && NextOrder.menu[NextOrder.choice].plate.Equals(selectedPlate) && !incorrect)
        {
            
        }
        if (incorrect)
        {
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
