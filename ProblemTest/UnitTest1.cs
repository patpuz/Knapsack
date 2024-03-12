using Microsoft.VisualStudio.TestTools.UnitTesting;
using solver;

namespace ProblemTest
{
    [TestClass]
    public class ProblemTests
    {
        [TestMethod]
        public void test1()
        {
            var problem = new Problem(3, 1);
            var capacity = 10;

            var result = problem.Solve(capacity);

            Assert.IsTrue(result.Pack.Count > 0);
        }

        [TestMethod]
        public void test2()
        {
            var problem = new Problem(3, 1);
            var capacity = 0;

            var result = problem.Solve(capacity);

            Assert.AreEqual(0, result.Pack.Count);
        }

        [TestMethod]
        public void test3()
        {
            var items = new List<Item>
            {
                new Item(2, 2),
                new Item(1, 3),
                new Item(3, 4)
            };
            var items2 = new List<Item>
            {
                new Item(3, 4),
                new Item(1, 3),
                new Item(2, 2)
            };
            var problem1 = new Problem(items);
            var problem2 = new Problem(items2);
            var capacity = 10;

            var result1 = problem1.Solve(capacity);
            var result2 = problem2.Solve(capacity);

            Assert.AreEqual(result1.TotalValue, result2.TotalValue);
            Assert.AreEqual(result1.TotalWeight, result2.TotalWeight);
        }

        [TestMethod]
        public void test4()
        {
            var items = new List<Item>
            {
                new Item(1, 3),
                new Item(2, 2),
                new Item(3, 4)
            };
            var problem = new Problem(items);

            var capacity = 5;
            var expectedTotalValue = 3;
            var expectedTotalWeight = 5;

            var result = problem.Solve(capacity);

            Assert.AreEqual(expectedTotalValue, result.TotalValue);
            Assert.AreEqual(expectedTotalWeight, result.TotalWeight);
        }
        [TestMethod]
        public void test5()
        {
            var problem = new Problem(new List<Item>());
            var capacity = 10;

            var result = problem.Solve(capacity);

            Assert.AreEqual(0, result.TotalValue);
            Assert.AreEqual(0, result.TotalWeight);
            Assert.AreEqual(0, result.Pack.Count);
        }
        [TestMethod]
        public void test6()
        {
            var problem = new Problem(100, 1);
            var capacity = 1000;
            var result = problem.Solve(capacity);
            Assert.AreEqual(100, result.Pack.Count);

        }
        [TestMethod]
        public void test7()
        {
            var items = new List<Item>
            {
                new Item(1, 10),
                new Item(2, 10),
                new Item(3, 10)
            };
            var problem = new Problem(items);

            var capacity = -20;
            var result = problem.Solve(capacity);

            Assert.AreEqual(0, result.Pack.Count);
        }
        [TestMethod]
        public void test8()
        {
            var items = new List<Item>
            {
                new Item(2, 2),
                new Item(3, 2),
                new Item(2, 2)
            };
            foreach (var item in items)
            {
                Assert.IsTrue(item.Weight > 0);
            }
            
        }
    }
}
