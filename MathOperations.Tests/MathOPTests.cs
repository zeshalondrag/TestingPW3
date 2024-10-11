using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MathOperations.Tests
{
    [TestClass]
    public class MathOPTests
    {
        private static List<double[]> testCasesRoots;
        private static double total;
        private static double percentage;
        private static double expectedPercentage;
        private static double delta;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            testCasesRoots = new List<double[]>
            {
                new double[] { 1, 2, 5 }, 
                new double[] { 1, 2, 1 }, 
                new double[] { 1, -3, 2 } 
            };

            total = 500.0;
            percentage = 12.5;
            expectedPercentage = 63.0;
            delta = 0.5;
        }

        [TestMethod]
        public void FindTheRoot_DiscriminantLessThanZero_NoRealRoots()
        {
            CollectionAssert.AreEqual(new double[] { }, MathOP.FindTheRoot(testCasesRoots[0][0], testCasesRoots[0][1], testCasesRoots[0][2]));
        }

        [TestMethod]
        public void FindTheRoot_DiscriminantEqualsZero_OneRealRoot()
        {
            CollectionAssert.AreEquivalent(new double[] { -1 }, MathOP.FindTheRoot(testCasesRoots[1][0], testCasesRoots[1][1], testCasesRoots[1][2]));
        }

        [TestMethod]
        public void FindTheRoot_DiscriminantGreaterThanZero_TwoUniqueRealRoots()
        {
            double[] roots = MathOP.FindTheRoot(testCasesRoots[2][0], testCasesRoots[2][1], testCasesRoots[2][2]);
            CollectionAssert.AllItemsAreUnique(roots);
            CollectionAssert.AreEquivalent(new double[] { 2, 1 }, roots);
        }

        [TestMethod]
        public void CalculatePercentage_ValidInput_CorrectResultWithDelta()
        {
            double actual = MathOP.CalculatePercentage(total, percentage);
            Assert.AreEqual(expectedPercentage, actual, delta, $"Ошибка: {percentage}% от {total} должно быть {expectedPercentage}, но получено {actual}.");
        }
    }
}
