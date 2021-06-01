using NUnit.Framework;
using InventorySystem;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void voidAddTwoNumbers()
        {
            MathOperations MO = new MathOperations();
            int answer = MO.AddTwoNumbers(1, 3);
            Assert.AreEqual(4, answer);
        }

        [Test]
        public void voidAddTwoNumbersWithFour()
        {
            MathOperations MO = new MathOperations();
            int answer = MO.AddTwoNumbers(4, 3);
            Assert.AreEqual(7, answer);
        }

        [Test]
        public void Test1ForPerfectNumberFalse()
        {
            MathOperations MO = new MathOperations();
            bool answer = MO.IsPerfectNumber(1);
            Assert.AreEqual(false, answer);
        }

        [Test]
        public void Test1ForPerfectNumberTrue()
        {
            MathOperations MO = new MathOperations();
            bool answer = MO.IsPerfectNumber(6);
            Assert.AreEqual(true, answer);
        }

        [Test]
        public void Test1ForLargePerfectNumberTrue()
        {
            MathOperations MO = new MathOperations();
            bool answer = MO.IsPerfectNumber(33550336);
            Assert.AreEqual(true, answer);
        }
    }
}