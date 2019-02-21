﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassesIntro
{
    public class Dog
    {
        public string Breed;
        public int Height;
        public string Name;

        public Dog(string breed, string name, int height)
        {
            Breed = breed;
            Height = height;
            Name = name;
        }

        public void Bark()
        {
            MessageBox.Show("Bark from" + Name);
        }
        public void SayName()
        {
            MessageBox.Show("My name is " + Name);
        }
    }
}