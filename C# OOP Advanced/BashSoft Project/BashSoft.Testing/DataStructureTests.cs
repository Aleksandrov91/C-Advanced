namespace BashSoft.Testing
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using DataStructures;
    using NUnit.Framework;

    [TestFixture]
    public class DataStructureTests
    {
        private ISimpleOrderedBag<string> names;

        [SetUp]
        public void Initalize()
        {
            this.names = new SimpleSortedList<string>();
        }

        [Test]
        public void TestEmptyCtor()
        {
            this.names = new SimpleSortedList<string>();

            Assert.AreEqual(16, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }

        [Test]
        public void TestCtorWithInitialCapacity()
        {
            this.names = new SimpleSortedList<string>(20);

            Assert.AreEqual(20, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }

        [Test]
        public void TestCtorWithInitialComparer()
        {
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase);

            Assert.AreEqual(16, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }

        public void TestCtorWithAllParameters()
        {
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase, 30);

            Assert.AreEqual(30, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }

        [Test]
        public void TestAddIncreaseSize()
        {
            this.names.Add("Nasko");

            Assert.AreEqual(1, this.names.Size);
        }

        [Test]
        public void AddNullThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => this.names.Add(null));
        }

        [Test]
        public void TestAddUnsortedDataIsHeldSorted()
        {
            string[] namesToAdd = { "Rosen", "Georgi", "Balkan" };
            this.names.AddAll(namesToAdd);

            int index = namesToAdd.Length - 1;
            for (int i = 0; i < this.names.Size; i++)
            {
                Assert.AreEqual(namesToAdd[index--], this.names[i]);
            }
        }

        [Test]
        public void TestAddingMoreThanInitialCapacity()
        {
            for (int i = 0; i < 17; i++)
            {
                this.names.Add("Gosho");
            }

            Assert.AreEqual(17, this.names.Size);
            Assert.AreNotEqual(16, this.names.Capacity);
        }

        [Test]
        public void TestAddingAllFromCollectionIncreasesSize()
        {
            List<string> namesToAdd = new List<string>();
            namesToAdd.Add("Gosho");
            namesToAdd.Add("Ivan");

            this.names.AddAll(namesToAdd);

            Assert.AreEqual(2, this.names.Size);
        }

        [Test]
        public void TestAddingAllFromNullThrowsException()
        {
            List<string> namesToAdd = new List<string>();
            namesToAdd.Add("Gosho");
            namesToAdd.Add("Ivan");
            namesToAdd.Add(null);

            Assert.Throws<ArgumentNullException>(() => this.names.AddAll(namesToAdd));
        }

        [Test]
        public void TestAddAllKeepsSorted()
        {
            List<string> namesToAdd = new List<string>() { "Rosen", "Georgi", "Balkan" };

            this.names.AddAll(namesToAdd);
            namesToAdd.Sort();

            for (int i = 0; i < this.names.Size; i++)
            {
                Assert.AreEqual(namesToAdd[i], this.names[i]);
            }
        }

        [Test]
        public void TestRemoveValidElementDecreasesSize()
        {
            this.names.Add("Gosho");
            this.names.Remove("Gosho");

            Assert.AreEqual(0, this.names.Size);
        }

        [Test]
        public void TestRemoveValidElementRemovesSelectedOne()
        {
            this.names.Add("Ivan");
            this.names.Add("Nasko");
            this.names.Remove("Ivan");

            Assert.AreEqual(1, this.names.Size);
        }

        [Test]
        public void TestRemovingNullThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => this.names.Remove(null));
        }

        [Test]
        public void TestJoinWithNull()
        {
            this.names.Add("Ivan");
            this.names.Add("Gosho");

            Assert.Throws<ArgumentNullException>(() => this.names.JoinWith(null));
        }

        [Test]
        public void TestJoinWorksFine()
        {
            this.names.Add("Gosho");
            this.names.Add("Pesho");
            this.names.Add("Ivan");

            string joined = this.names.JoinWith(", ");

            Assert.AreEqual("Gosho, Ivan, Pesho", joined);
        }
    }
}
