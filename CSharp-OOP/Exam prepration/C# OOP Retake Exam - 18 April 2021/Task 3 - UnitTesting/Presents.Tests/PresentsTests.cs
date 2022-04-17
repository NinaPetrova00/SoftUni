namespace Presents.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class PresentsTests
    {
        private Bag bag;
        [SetUp]
        public void SetUp()
        {
            bag = new Bag();
        }

        [Test]
        public void Ctor_ValidArguments()
        {
            Assert.That(bag, Is.Not.Null);
        }

        [Test]
        public void Create_ThrowsExceptionWhenPresentIsNull()
        {
            Present present = null;
            Assert.Throws<ArgumentNullException>(() => bag.Create(present));
        }

        [Test]
        public void Create_ThrowsExceptionWhenPresentAlreadyExists()
        {
            Present present = new Present("dog", 2.5);
            bag.Create(present);
            Assert.Throws<InvalidOperationException>(() => bag.Create(present));
        }

        [Test]
        public void Remove_ReturnFalseIfPresentIsNotInTheBag()
        {
            Present present = new Present("dog", 2.5);

            Assert.IsFalse(bag.Remove(present));
        }

        [Test]
        public void Remove_ReturnTruefPresentIsInTheBag()
        {
            Present present = new Present("dog", 2.5);
            bag.Create(present);
            Assert.IsTrue(bag.Remove(present));
        }

        [Test]
        public void GetPresentWithLeastMagic()
        {
            Present pre1 = new Present("dog", 2.5);
            Present pre2 = new Present("cat", 8.9);
            bag.Create(pre1);
            bag.Create(pre2);

            Assert.That(pre1, Is.EqualTo(bag.GetPresentWithLeastMagic()));
        }

        [Test]
        public void GetPresent()
        {
            Present pre1 = new Present("dog", 2.5);
            bag.Create(pre1);

            Assert.That(pre1, Is.EqualTo(bag.GetPresent(pre1.Name)));
        }

        [Test]
        public void GetPresents()
        {
            Assert.That(bag.GetPresents(), Is.InstanceOf<IReadOnlyCollection<Present>>());
        }
    }
}
