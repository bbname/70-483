using MPF.ParallelProgramming.Problem;
using NUnit.Framework;

namespace MPF.ParallelProgramming.Tests.Problem
{
    [TestFixture]
    public class MatricesBuilderTests
    {
        [Test]
        public void BuildMatrixWithRandomNumbers_1row1column_MatrixWith1Element()
        {
            var builder = new MatrixBuilder();
            var expectedLengthOfMatrix = 1;
            
            var matrix = builder.BuildMatrixWithRandomNumbers(1, 1, 1, 1);
            var actualLengthOfMatrix = matrix.Length;
            
            Assert.AreEqual(expectedLengthOfMatrix, actualLengthOfMatrix);
        }
    }
}