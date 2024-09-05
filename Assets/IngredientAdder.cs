using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuOpener : MonoBehaviour
{
    public Button button;
	public string buttonText;
	public List<string> ingredientList = new List<string>();

	void Start () {
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		buttonText = this.GetComponentInChildren<TMP_Text>().text;
	}

	void TaskOnClick(){
		ingredientList.Add(buttonText);
		Debug.Log(buttonText);
		GameObject.Find("IngredientList").GetComponent<IngredientList>().AddToList(buttonText);
	}
}
