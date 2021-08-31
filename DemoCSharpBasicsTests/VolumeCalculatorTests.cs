using DemoCSharpBasics;
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
            Cube cube = new Cube(name: "cube", a: 2, color: "blue");
            double expectedvolume = 8;

            //Act
            double volume = cube.Calculate();

            //Assert
            Assert.AreEqual(expectedvolume, Math.Round(volume));
        }

        [Test]
        public void CylinderVolumeTest()
        {
            //Arange
            Cylinder cylinder = new Cylinder(name: "cylinder", r: 2, H: 10, color: "blue");
            double expectedvolume = 25.12;

            //Act
            double volume = cylinder.Calculate();

            //Assert
            Assert.AreEqual(Math.Round(expectedvolume, 2), Math.Round(volume, 2));
        }

        [Test]
        public void SphereVolumeTest()
        {
            //Arange
            Sphere sphere = new Sphere(name: "sphere", r: 6, color: "blue");
            double expectedvolume = 33.49;

            //Act
            double volume = sphere.Calculate();

            //Assert
            Assert.AreEqual(Math.Round(expectedvolume, 2), Math.Round(volume, 2));
        }
    }
}