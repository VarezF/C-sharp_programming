namespace HW2
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class TestClass
    {
        private List<int> test1;
        private List<int> test2;
        private List<int> test3;
        private Strat1 test1a;
        private Strat2 test1b;
        private Strat3 test1c;
        private Strat1 test2a;
        private Strat2 test2b;
        private Strat3 test2c;
        private Strat1 test3a;
        private Strat2 test3b;
        private Strat3 test3c;

        [SetUp]
        public void InitTest()
        {
            Random rand = new Random();
            this.test1 = new List<int>();
            this.test2 = new List<int>();
            this.test3 = new List<int>();

            for (int i = 0; i < 10000; i++)
            {
                this.test1.Add(rand.Next(20001));
                this.test2.Add(rand.Next(20001));
                this.test3.Add(rand.Next(20001));
            }

            this.test1a = new Strat1(this.test1);
            this.test1b = new Strat2(this.test1);
            this.test1c = new Strat3(this.test1);
            this.test2a = new Strat1(this.test2);
            this.test2b = new Strat2(this.test2);
            this.test2c = new Strat3(this.test2);
            this.test3a = new Strat1(this.test3);
            this.test3b = new Strat2(this.test3);
            this.test3c = new Strat3(this.test3);
        }

        [TestCase]
        public void EquivalencyTest()
        {
            Assert.AreEqual(this.test1a.GetSize(), this.test1b.GetUniqueInt());
            Assert.AreEqual(this.test1b.GetUniqueInt(), this.test1c.GetUniquInt());

            Assert.AreEqual(this.test2a.GetSize(), this.test2b.GetUniqueInt());
            Assert.AreEqual(this.test2b.GetUniqueInt(), this.test2c.GetUniquInt());

            Assert.AreEqual(this.test3a.GetSize(), this.test3b.GetUniqueInt());
            Assert.AreEqual(this.test3b.GetUniqueInt(), this.test3c.GetUniquInt());
        }
    }
}
