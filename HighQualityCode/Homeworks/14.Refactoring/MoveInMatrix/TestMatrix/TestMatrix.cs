namespace TestMatrix
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MoveInMatrix;

    [TestClass]
    public class MatrixInitialiserTests
    {
        [TestMethod]
        public void TestChangeDirectionsWithCorectSteps()
        {
            int horizontalStep = 1;
            int verticalStep = 1;
            int expectedHorizontalstep = 1;
            int expectedVerticalStep = 0;

            MoveInMatrix.ChangeDirections(ref horizontalStep, ref verticalStep);

            Assert.AreEqual(expectedHorizontalstep, horizontalStep);
            Assert.AreEqual(expectedVerticalStep, verticalStep);
        }

        [TestMethod]
        public void TesInitialiseMatrixWhilePosible()
        {
            int[,] matrix = 
            {
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            };
            int[,] expectedMatrix = 
            {
                { 1, 7, 8 },
                { 6, 2, 9 },
                { 5, 4, 3 }
            };
            int numberOfRows = 3;
            int row = 0;
            int col = 0;
            int stepX = 1;
            int stepY = 1;
            int number = 1;

            MoveInMatrix.InitializeMatrix(numberOfRows, matrix, ref number, ref row, ref col, ref stepX, ref stepY);

            for (int i = 0; i < expectedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < expectedMatrix.GetLength(1); j++)
                {
                    Assert.AreEqual(expectedMatrix[i, j], matrix[i, j]);
                }
            }
        }
    }
}