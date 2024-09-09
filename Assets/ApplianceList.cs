using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ApplianceList : MonoBehaviour
{
    public TMP_Text text;
    string oldText;
    string newAppliance;
    public List<string> selectedAppliance = new List<string>();

    void Start()
    {
        /*oldText = "jorbis" + "\n";
        text.text = oldText + "Jorbis2" + "\n";*/
    }

    public void AddToList(string newAppliance){
        selectedAppliance.Add(newAppliance);
        oldText = text.text;
        text.text = oldText + "\n" + newAppliance;
    }

    public void ResetText(){
        text.text = "";
    }
}
