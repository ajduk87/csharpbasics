﻿using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class Sphere
    {
        private double PI;
        private double r;


        public static int NumberOfSoldSpheres = 0;

        public static void IncrementNumberOfSoldSpheres()
        {
            NumberOfSoldSpheres++;
        }

        public string Name { get; set; }
        public Material Material { get; set; }
        public double Price { get; set; }


        private double CalculateVolume()
        {
            return 4 * Math.Pow(r, 3) * PI / 3;
        }

        public  double Calculate() 
        {
            double volume = CalculateVolume();
            return Math.Round(volume, 2);
        }       
    }
}
