using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submit : MonoBehaviour
{
    public NextOrder nextOrder;
    private bool _ingredientsMatch = false;
    private bool incorrect = false;
    public List<string> selectedIngredients = new List<string>(){"bread","meat","lettuce"};
    public List<string> ingredients = new List<string>(){"lettuce","meat","bread"};
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
                //_ingredientsMatch = false;
            }
            else
            {
                Debug.Log("incoreect");
                incorrect = true;
                break;
            }
        }
//if it's fully correct
    }

    // Update is called once per frame
    void Update()
    {
        if ( nextOrder.currentRecipe != null)
        {
            if (_ingredientsMatch){
                GameObject.Find("PointSystem").GetComponent<PointSystem>().gainPoints(gameObject.GetComponent<ReceiptScript>().cost);
                Debug.Log("gg");
                //_ingredientsMatch = false;
            }
            if (incorrect)
            {
                
            }
            else if (nextOrder.currentRecipe.appliance.Equals(selectedAppliance) && nextOrder.currentRecipe.plate.Equals(selectedPlate))
            {
                GameObject.Find("PointSystem").GetComponent<PointSystem>().gainPoints(nextOrder.currentRecipe.cost);
                Debug.Log("gg");
            }
        }
    }
    
}
