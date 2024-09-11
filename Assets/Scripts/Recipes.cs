using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipes : MonoBehaviour
{
    public List<string> necessary;
    public List<string> optionals;
    public string appliance;
    public string plate;
        public Recipes(List<string> necessaries, string plate, string appliance)
        {
            necessary = necessaries;
            this.plate = plate;
            this.appliance = appliance;
        }
        public Recipes(List<string> necessaries, List<string> optional, string plate)
        {
            necessary = necessaries;
            optionals = optional;
            this.plate = plate;
        }
        public Recipes(List<string> necessaries, List<string> optional, string plate, string appliance)
        {
            necessary = necessaries;
            optionals = optional;
            this.plate = plate;
            this.appliance = appliance;
        }
}
