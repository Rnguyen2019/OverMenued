using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Submit : MonoBehaviour
{
    IngredientList ingredientList;
    ApplianceList applianceList;
    DishList dishList;
    public NextOrder nextOrder;
    private bool _ingredientsMatch = false;
    private bool incorrect = false;
    public List<string> selectedIngredients;
    public string selectedPlate;
    public string selectedAppliance;
    public List<string> ingredients;
    // Start is called before the first frame update
    void Start()
    {
        
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
                //Debug.Log("incoreect");
                incorrect = true;
                break;
            }
        }
        if(!_ingredientsMatch)
        {
            Debug.Log("You win for real this time");
        }

        //if it's fully correct
    }
    public void CheckOrder()
    {
        if (selectedPlate != null)
        {
            selectedPlate = GameObject.Find("DishList").GetComponent<DishList>().selectedDish[0];
        }
        if (selectedAppliance != null)
        {
            selectedAppliance = GameObject.Find("ApplianceList").GetComponent<ApplianceList>().selectedAppliance[0];
        }
        Debug.Log(selectedAppliance);
        Debug.Log(selectedPlate);
        
        selectedIngredients = GameObject.Find("IngredientList").GetComponent<IngredientList>().selectedIngredients;
        for(int i = 0; i < selectedIngredients.Count; i++){
            Debug.Log(selectedIngredients[i]);
        }
        if (nextOrder.currentRecipe != null)
        {
            if (nextOrder.currentRecipe.appliance.ToLower().Equals(selectedAppliance.ToLower()) ||
                     nextOrder.currentRecipe.plate.ToLower().Equals(selectedPlate.ToLower()))
            {
                Debug.Log("12345678");
            }
            else if (incorrect)
            {
                Debug.Log("we win!!!!");
            }


        }
    }
    
    
}