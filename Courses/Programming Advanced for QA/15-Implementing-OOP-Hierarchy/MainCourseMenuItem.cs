﻿using System;

namespace ExerciseOopHierarchy
{

    //Артикул от менюто - Основно ястие
    public class MainCourseMenuItem : MenuItem
    {
        public MainCourseMenuItem(string name, string description, decimal price) : base(name, description, price)
        {

        }

        public override string ToString()
        {
            return $"Main Course: " + base.ToString();
        }
    }
}
