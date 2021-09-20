using DemoCSharpBasics;
using DemoCSharpBasics.Shapes;
using NUnit.Framework;
using System;

namespace DemoCSharpBasicsTests
{
    public class VolumeCalculatorTests
    {     

       

        [Test]
        public void CylinderVolumeTest()
        {
            //Arange
            double r = 2;
            double H = 2;
            Cylinder plasticCylinder = new Cylinder();
            double expectedvolume = 37.68;

            //Act
            double volume = plasticCylinder.CalculateVolume();

            //Assert
            Assert.AreEqual(Math.Round(expectedvolume, 2), Math.Round(volume, 2));
        }

        [Test]
        public void SphereVolumeTest()
        {
            //Arange
            double r = 2;
            Sphere plastricSphere = new Sphere();
            double expectedvolume = 33.49;

            //Act
            double volume = plastricSphere.CalculateVolume();

            //Assert
            Assert.AreEqual(Math.Round(expectedvolume, 2), Math.Round(volume, 2));
        }
    }
}