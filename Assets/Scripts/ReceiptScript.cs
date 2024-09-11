using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReceiptScript : MonoBehaviour
{
    public Text receipt;
    public double cost;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        receipt.text = "***************** \n" + gameObject.GetComponent<NextOrder>().dish.dishName + "\n\n";
        cost = gameObject.GetComponent<NextOrder>().dish.price;
        int rand1 = gameObject.GetComponent<NextOrder>().rand;
        if (rand1 != 0)
        {
            for (int i = 0; i <= rand1; i++)
            {
                receipt.text += gameObject.GetComponent<NextOrder>().dish.optionals[i] + "\n";
                cost += 0.2;
            }
        }
        receipt.text += "\nTotal     $" + cost +"\n- - - - - - - - - - -";
        //receipt.fontStyle = FontStyle.Bold;
        PointSystem.gainPoints(cost);
    }
}
