using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipes : MonoBehaviour
{
    public string dishName;
    public List<string> necessary;
    public List<string> optionals;
    public string appliance;
    public string plate;
    public double price;
        public Recipes(string dishName, List<string> necessaries, string plate, string appliance, double price)
        {
            this.dishName = dishName;
            necessary = necessaries;
            this.plate = plate;
            this.price = price;
        }
        public Recipes(string dishName, List<string> necessaries, List<string> optional, string plate, double price)
        {
            this.dishName = dishName;
            necessary = necessaries;
            optionals = optional;
            this.plate = plate;
            this.price = price;
        }
        public Recipes(string dishName, List<string> necessaries, List<string> optional, string plate, string appliance, double price)
        {
            this.dishName = dishName;
            necessary = necessaries;
            optionals = optional;
            this.plate = plate;
            this.appliance = appliance;
            this.price = price;
        }
}
