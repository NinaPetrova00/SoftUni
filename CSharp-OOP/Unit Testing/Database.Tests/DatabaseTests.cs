using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    public class DatabaseTests
    {
        private Database dataBase;

        [SetUp]
        public void Setup()
        {
            dataBase = new Database();
        }

        [Test]
        public void Ctor_ThrowsExceptionWhenDBCountIsExceeded()
        {
            Assert.Throws<InvalidOperationException>(() => dataBase = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17));
        }

        [Test]
        public void Ctor_AddValidItemsInToDB()
        {
            var elements = new int[] { 1, 2, 3 };
            dataBase = new Database(elements);
            Assert.That(dataBase.Count, Is.EqualTo(elements.Length));
        }

        [Test]
        public void Add_IncrementsCountWhenAddIsValid()
        {
            var n = 5;

            for (int i = 0; i < n; i++)
            {
                dataBase.Add(i);
            }

            Assert.That(dataBase.Count, Is.EqualTo(n));
        }

        [Test]
        public void Add_ThrowExceptionWhenCapacityIsExceeded()
        {
            var n = 16;

            for (int i = 0; i < n; i++)
            {
                dataBase.Add(i);
            }

            Assert.Throws<InvalidOperationException>(() => dataBase.Add(17));
        }

        [Test]
        public void Remove_DecreaseCapacity()
        {
            var n = 3;

            for (int i = 0; i < n; i++)
            {
                dataBase.Add(123);
            }

            dataBase.Remove();
            var expectedResultCount = 2;

            Assert.That(dataBase.Count, Is.EqualTo(expectedResultCount));
        }

        [Test]
        public void Remove_ThrowExceptionWhenDBIsEmpty()
        {
            Assert.Throws<InvalidOperationException>(() =>dataBase.Remove());
        } 
        
        [Test]
        public void Remove_RemocesElementFromDB()
        {
            var n = 3;
            var lastELement = 3;

            for (int i = 0; i < n; i++)
            {
                dataBase.Add(i);
            }

            dataBase.Remove();
            var elements = dataBase.Fetch();
            Assert.IsFalse(elements.Contains(lastELement));
        }

        [Test]
        public void Fetch_ReturnsDBCopyNotReference()
        {
            dataBase.Add(1);
            dataBase.Add(2);

            var firstCopy = dataBase.Fetch(); // firstCopy -> 2 elements
            dataBase.Add(3);

            var secondCopy = dataBase.Fetch(); // secondCopy -> 3 elements

            Assert.That(firstCopy, Is.Not.EqualTo(secondCopy));
        }

        [Test]
        public void Count_ReturnsZeroWhenDBIsEmpty()
        {
            Assert.That(dataBase.Count, Is.EqualTo(0));
        }

    }
}