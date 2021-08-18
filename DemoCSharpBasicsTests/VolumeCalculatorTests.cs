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
            double a = 2;
            VolumeCalculator volumeCalculator = new VolumeCalculator();
            double expectedvolume = 8;

            //Act
            double volume = volumeCalculator.CalculateCubeVolume(a);

            //Assert
            Assert.AreEqual(expectedvolume, Math.Round(volume));
        }

        [Test]
        public void CylinderVolumeTest()
        {
            //Arange
            double r = 2;
            double H = 2;
            VolumeCalculator volumeCalculator = new VolumeCalculator();
            double expectedvolume = 25.12;

            //Act
            double volume = volumeCalculator.CalculateCylinderVolume(r, H);

            //Assert
            Assert.AreEqual(Math.Round(expectedvolume, 2), Math.Round(volume, 2));
        }

        [Test]
        public void SphereVolumeTest()
        {
            //Arange
            double r = 2;
            VolumeCalculator volumeCalculator = new VolumeCalculator();
            double expectedvolume = 33.49;

            //Act
            double volume = volumeCalculator.CalculateSphereVolume(r);

            //Assert
            Assert.AreEqual(Math.Round(expectedvolume, 2), Math.Round(volume, 2));
        }
    }
}