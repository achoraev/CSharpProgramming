namespace ComputerBuildingSystem.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;    

    [TestClass]
    public class TestingBatteryCharge
    {
        [TestMethod]
        public void TestMethodChargingBattery()
        {
            LaptopBattery newBattery = new LaptopBattery();
            newBattery.Charge(0);
            int actual = newBattery.LoadRamValue();
            Assert.AreEqual(actual, newBattery.LoadRamValue());
        }

        [TestMethod]
        public void TestMethodChargingBatteryWithNegativeNumber()
        {
            LaptopBattery newBattery = new LaptopBattery();
            int expected = newBattery.LoadRamValue() - 1;
            newBattery.Charge(-1);            
            int actual = newBattery.LoadRamValue();            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodChargingBatteryWithMoreThan100()
        {
            LaptopBattery newBattery = new LaptopBattery();
            int expected = 100;
            newBattery.Charge(200);
            int actual = newBattery.LoadRamValue();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodEmptyBattery()
        {
            LaptopBattery newBattery = new LaptopBattery();
            int expected = 0;
            newBattery.Charge(-100);
            int actual = newBattery.LoadRamValue();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]        
        public void TestMethodMoreThan100()
        {
            LaptopBattery newBattery = new LaptopBattery();
            int expected = 100;
            newBattery.Charge(60);
            int actual = newBattery.LoadRamValue();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodLessThanZero()
        {
            LaptopBattery newBattery = new LaptopBattery();
            int expected = 0;
            newBattery.Charge(-60);
            int actual = newBattery.LoadRamValue();
            Assert.AreEqual(expected, actual);
        }
    }
}
