namespace ComputerBuildingSystem.Tests
{    
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using ComputerBuildingSystem;

    [TestClass]
    public class TestingSquareNumber
    {
        [TestMethod]
        public void TestMethodCalculateSquare()
        {
            VideoCard video = new VideoCard();
            var serverRam = new Ram(64);
            var serverVideo = new VideoCard();
            var server = new PC(
                    Type.SERVER,
                    new Cpu(8, 64, serverRam, serverVideo),
                    serverRam,
                    new List<HardDrive> { new HardDrive(0, true, 2, new List<HardDrive> { new HardDrive(2000, false, 0), new HardDrive(2000, false, 0) }) },
                    serverVideo,
                    null);
            server.Process(2);
            Assert.AreEqual(4, 2);            
        }

        [TestMethod]
        public void TestMethodCalculateSquareWithNegative()
        {
            VideoCard video = new VideoCard();
            var serverRam = new Ram(64);
            var serverVideo = new VideoCard();
            var server = new PC(
                    Type.SERVER,
                    new Cpu(8, 64, serverRam, serverVideo),
                    serverRam,
                    new List<HardDrive> { new HardDrive(0, true, 2, new List<HardDrive> { new HardDrive(2000, false, 0), new HardDrive(2000, false, 0) }) },
                    serverVideo,
                    null);
            server.Process(-2);
            Assert.AreEqual(0, 10);
        }
    }
}