using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputerBuildingSystem.Tests
{
    [TestClass]
    public class TestingRandomGenerator
    {
        [TestMethod]
        public void TestMethodRandomNumbers()
        {
            var computerRam = new Ram(2);
            var computerVideo = new VideoCard(false);
            PC newPc = new PC(Type.PC, new Cpu(2, 32, computerRam, computerVideo), computerRam, new[] { new HardDrive(500, false, 0) }, computerVideo, null);
            var actual = newPc.RandomGenerator(1, 10);
            Assert.AreNotEqual(11, actual);
        }

        [TestMethod]
        public void TestMethodOutOfRange()
        {
            var computerRam = new Ram(2);
            var computerVideo = new VideoCard(false);
            PC newPc = new PC(Type.PC, new Cpu(2, 32, computerRam, computerVideo), computerRam, new[] { new HardDrive(500, false, 0) }, computerVideo, null);
            var actual = newPc.RandomGenerator(1, 10);
            Assert.AreNotEqual(0, actual);
        }
    }
}
