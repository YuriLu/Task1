﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public enum TypeCandy { Lollipop, ChocolateCandy };

    public class Candy : Sweet
    {
        public string Color { get; private set; }
        public TypeCandy Type; 
        

        public Candy(string candyName, int candyWeight, int candySugar, int candyCalories, TypeCandy type)
            : base(candyName, candyWeight, candySugar, candyCalories)
        {
            this.Type = type;
        }

        //public override void StructureCandy()
        //{
        //    Console.WriteLine("Состав конфеты: {0}, {1}, {2}, {3}, {4}", Name, Weight, Sugar, Calories, color);
        //}
    }
}
