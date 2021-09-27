using DemoCSharpBasics;
using DemoCSharpBasics.Shapes;
using NUnit.Framework;
using System;

namespace DemoCSharpBasicsTests
{
    public class VolumeCalculatorTests
    {
      

        [Test]
        public void CubeVolumeTest()
        {
            //Arange
            double a = 2;
            Cube plasticCube = new Cube(name: "cube", a: 2, Material.PLASTIC, price: 8, orderAmount: 19);
            double expectedvolume = 8;

            //Act
            double volume = plasticCube.Calculate();

            //Assert
            Assert.AreEqual(expectedvolume, Math.Round(volume));
        }

        [Test]
        public void CylinderVolumeTest()
        {
            //Arange
            double r = 2;
            double H = 2;
            Cylinder plasticCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.PLASTIC, price: 10, orderAmount: 24);
            double expectedvolume = 37.68;

            //Act
            double volume = plasticCylinder.Calculate();

            //Assert
            Assert.AreEqual(Math.Round(expectedvolume, 2), Math.Round(volume, 2));
        }

        [Test]
        public void SphereVolumeTest()
        {
            //Arange
            double r = 2;
            Sphere plastricSphere = new Sphere(name: "sphere", r: 2, Material.PLASTIC, price: 6, orderAmount: 11);
            double expectedvolume = 33.49;

            //Act
            double volume = plastricSphere.Calculate();

            //Assert
            Assert.AreEqual(Math.Round(expectedvolume, 2), Math.Round(volume, 2));
        }
    }
}