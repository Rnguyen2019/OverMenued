using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    private static double totalCost = 0;
    public static Text pointScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void gainPoints(double points){
        totalCost += points;
        pointScore.text = "$" + totalCost;
    }
}
