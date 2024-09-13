using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submit : MonoBehaviour
{
    IngredientList ingredientList;
    public NextOrder nextOrder;
    private bool _ingredientsMatch = false;
    private bool incorrect = false;
    public List<string> selectedIngredients;
    public List<string> ingredients;
    public string selectedPlate = "bowl";
    public string selectedAppliance = "grill";
    // Start is called before the first frame update
    void Start()
    {
        selectedIngredients = GameObject.Find("IngredientList").GetComponent<IngredientList>().selectedIngredients;
        nextOrder = GetComponent<NextOrder>();
    }

    public void SubmitOrder()
    {
        ingredients = nextOrder.ingredients;
        for (int i = 0; i < ingredients.Count; i++)
        {
            for (int j = 0; j < selectedIngredients.Count; j++)
            {
                if (selectedIngredients[j].ToLower().Equals(ingredients[i].ToLower()))
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
        if (nextOrder.currentRecipe != null)
        {
            if (incorrect)
            {

            }
            else if (nextOrder.currentRecipe.appliance.Equals(selectedAppliance) &&
                     nextOrder.currentRecipe.plate.Equals(selectedPlate))
            {

            }

            Debug.Log("12345678");
        }


    }

}