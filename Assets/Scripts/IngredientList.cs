using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IngredientList : MonoBehaviour
{
    public TMP_Text text;
    string oldText;
    string newIngredient;
    public List<string> selectedIngredients = new List<string>();

    void Start()
    {
        text.text = "Ingredients:";
    }

    public void AddToList(string newIngredient){
        selectedIngredients.Add(newIngredient);
        oldText = text.text;
        text.text = oldText + "\n" + newIngredient;
    }

    public void Reset(){
        text.text = "Ingredients:";
        selectedIngredients.Clear();
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.P) & selectedIngredients != null){
            for(int i = 0; i < selectedIngredients.Count; i++){
			Debug.Log(selectedIngredients[i]);
            }
        }
    }
}
