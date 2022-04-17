namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class AquariumsTests
    {
        [Test]
        public void Ctor_InitializeCorrectly()
        {
            string name = "anme";
            int capacity = 1;
            Aquarium aquarium = new Aquarium(name, capacity);

            Assert.AreEqual(aquarium.Name, name);
            Assert.AreEqual(aquarium.Capacity, capacity);
        }

        [Test]
        public void Ctor_ThrowExceptionWhenInvalidName()
        {
            Assert.Throws<ArgumentNullException>(() => new Aquarium(null, 1));
            Assert.Throws<ArgumentNullException>(() => new Aquarium(string.Empty, 1));
        }

        [Test]
        public void Ctor_ThrowExceptionWhenInvalidCapacity()
        {
            Assert.Throws<ArgumentException>(() => new Aquarium("name", -1));
        }

        [Test]
        public void Count_()
        {
            Aquarium aquarium = new Aquarium("name", 1);
            int expectedCount = 1;

            aquarium.Add(new Fish("Nemo"));

            Assert.AreEqual(expectedCount, aquarium.Count);
        }

        [Test]
        public void Add_ThrowExcpetionWhenCapacityIsInvalid()
        {
            Aquarium aquarium = new Aquarium("name", 0);

            Assert.Throws<InvalidOperationException>(() => aquarium.Add(new Fish("fishy")));
        }

        [Test]
        public void Remove_ThrowExceptionWhenNameIsInvalid()
        {
            Aquarium aquarium = new Aquarium("name", 1);

            Assert.Throws<InvalidOperationException>(() => aquarium.RemoveFish(null));
        }

        [Test]
        public void Remove_CountIsValid()
        {
            Aquarium aquarium = new Aquarium("name", 1);

            aquarium.Add(new Fish("Nemo"));
            aquarium.RemoveFish("Nemo");

            Assert.AreEqual(aquarium.Count, 0);
        }

        [Test]
        public void SellFish_ThrowException()
        {
            Aquarium aquarium = new Aquarium("name", 1);

            Assert.Throws<InvalidOperationException>(() => aquarium.SellFish(null));
        }
        [Test]
        public void SellFish_NameIsValid()
        {
            Aquarium aquarium = new Aquarium("name", 1);
            aquarium.Add(new Fish("Nemo"));

            Fish fish = aquarium.SellFish("Nemo");

            Assert.AreEqual(fish.Name, "Nemo");
        }

        [Test]
        public void Report_()
        {
            Aquarium aquarium = new Aquarium("name", 1);
            aquarium.Add(new Fish("alabala"));


            string expectedMessage = $"Fish available at name: alabala";

            Assert.AreEqual(expectedMessage, aquarium.Report());
        }
    }
}
