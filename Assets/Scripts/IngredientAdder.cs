using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IngredientAdder : MonoBehaviour
{
    public Button button;
	public string buttonText;

	void Start () {
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		buttonText = this.GetComponentInChildren<TMP_Text>().text;
	}

	void TaskOnClick(){
		GameObject.Find("IngredientList").GetComponent<IngredientList>().AddToList(buttonText);
	}
}
