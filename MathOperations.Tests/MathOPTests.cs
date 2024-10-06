using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathOperations.Tests
{
    [TestClass]
    public class MathOPTests
    {
        [TestMethod]
        public void FindTheRoot_DiscriminantLessThanZero_NoRealRoots()
        {
            CollectionAssert.AreEqual(new double[] { }, MathOP.FindTheRoot(1, 2, 5));
        }

        [TestMethod]
        public void FindTheRoot_DiscriminantEqualsZero_OneRealRoot()
        {
            CollectionAssert.AreEquivalent(new double[] { -1 }, MathOP.FindTheRoot(1, 2, 1));
        }

        [TestMethod]
        public void FindTheRoot_DiscriminantGreaterThanZero_TwoUniqueRealRoots()
        {
            CollectionAssert.AllItemsAreUnique(MathOP.FindTheRoot(1, -3, 2)); 
            CollectionAssert.AreEquivalent(new double[] { 2, 1 }, MathOP.FindTheRoot(1, -3, 2));
        }

        [TestMethod]
        public void CalculatePercentage_ValidInput_CorrectResultWithDelta()
        {
            double total = 200.0;
            double percentage = 15.0;
            double expected = 30.0; 
            double actual = MathOP.CalculatePercentage(total, percentage);
            double delta = 0.001; 

            Assert.AreEqual(expected, actual, delta, $"Ошибка: {percentage}% от {total} должно быть {expected}, но получено {actual}.");
        }
    }
}