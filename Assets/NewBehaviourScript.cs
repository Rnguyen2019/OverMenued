using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static Recipes burger = new Recipes(new List<string>(){"beef","bread"},new List<string>(){"cheese","lettuce", "pickle","onion"},"plate","grill");
    public static Recipes salad = new Recipes(new List<string>(){"lettuce","tomatoes", "pepper", "carrot"},new List<string>(){"onion","cucumber"},"bowl");
    public static Recipes pizza = new Recipes(new List<string>(){"bread","cheese","oven"},new List<string>(){"pepperoni","mushroom","pepper", "artichoke", "pineapple", "chicken"},"plate","oven");
    public static Recipes pasta = new Recipes(new List<string>(){"noodles","water"},new List<string>(){"pesto","tomato","chicken"},"plate","pot");
    public static Recipes breakfast = new Recipes(new List<string>(){"bacon","potato","eggs","milk"},new List<string>(){"bellpeper"},"plate","pot");
    
    
    public List<Recipes> menu = new List<Recipes>() {burger,salad,pizza,pasta,breakfast};
    void Start()
    {
        int choice = UnityEngine.Random.Range(0,menu.Count-1);
        int optionChoice = UnityEngine.Random.Range(0,);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
