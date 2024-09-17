using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    private double totalCost = 0;
    private Text pointScore;
    // Start is called before the first frame update
    void Start()
    {
        pointScore = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gainPoints(double points){
        totalCost = 0;
        int rand1 = gameObject.GetComponent<NextOrder>().rand;
        if (rand1 != 0)
        {
            for (int i = 0; i <= rand1; i++)
            {
                totalCost += 0.2;
            }
        }
        totalCost += points;
        pointScore.text = "$" + totalCost;
    }
}
