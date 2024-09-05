using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IngredientList : MonoBehaviour
{
    public TMP_Text text;
    string oldText;
    string newIngredient;
    void Start()
    {
        /*oldText = "jorbis" + "\n";
        text.text = oldText + "Jorbis2" + "\n";*/
    }

    public void AddToList(string newIngredient){
        oldText = text.text;
        text.text = oldText + "\n" + newIngredient;
    }
}
