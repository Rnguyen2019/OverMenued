using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DishList : MonoBehaviour
{
    public TMP_Text text;
    string oldText;
    string newDish;
    public List<string> selectedDish = new List<string>();

    void Start()
    {
        text.text = "Dish:";
    }

    public void AddToList(string newDish){
        selectedDish.Add(newDish);
        oldText = text.text;
        text.text = oldText + "\n" + newDish;
    }

    public void Reset(){
        text.text = "Dish:";
        selectedDish.Clear();
    }
}
