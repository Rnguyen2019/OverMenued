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
    public double cost;
        public Recipes(string name, List<string> necessaries, string plate, string appliance, double cost)
        {
            dishName = name;
            necessary = necessaries;
            this.plate = plate;
            this.appliance = appliance;
            this.cost = cost;
        }
        public Recipes(string name, List<string> necessaries, List<string> optional, string plate, double cost)
        {
            dishName = name;
            necessary = necessaries;
            optionals = optional;
            this.plate = plate;
            this.cost = cost;
        }
        public Recipes(string name, List<string> necessaries, List<string> optional, string plate, string appliance, double cost)
        {
            dishName = name;
            necessary = necessaries;
            optionals = optional;
            this.plate = plate;
            this.appliance = appliance;
            this.cost = cost;
        }
}
