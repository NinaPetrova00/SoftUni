using NUnit.Framework;
using System;

namespace Tests
{
    public class WarriorTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(null, 100, 100)]
        [TestCase("", 100, 100)]
        [TestCase("null", 0, 100)]
        [TestCase("null", -10, 100)]
        [TestCase("null", 100, -100)]
        public void Ctor_ThrowsExceptionWhenDataIsInvalid(string name, int damage, int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, damage, hp));
        }

        [Test]
        [TestCase(35)]
        [TestCase(30)]
        [TestCase(25)]
        public void Attack_ThrowsExceptionWhenAttackerHpIsLow(int hp)
        {
            var attacker = new Warrior("Ivan", 10, hp);
            var attacked = new Warrior("Georgi", 50, 50);

            Assert.Throws<InvalidOperationException>(() => attacker.Attack(attacked));
        }

        [Test]
        [TestCase(30)]
        [TestCase(25)]
        public void Attack_ThrowsExceptionWhenAttackedHpIsLow(int hp)
        {
            var attacker = new Warrior("Ivan", 50, 50);
            var attacked = new Warrior("Georgi", 50, hp);

            Assert.Throws<InvalidOperationException>(() => attacker.Attack(attacked));
        }

        [Test]
        [TestCase(40, 100, 35, 100)]
        [TestCase(50, 100, 35, 50)]
        [TestCase(60, 100, 35, 50)]
        [TestCase(50, 100, 100, 50)]
        public void Attack_DecreaseBothWarriorsHp(int attackerDamage, int attackerHp, int attackedDamage, int attackedHp)
        {
            var attacker = new Warrior("Ivan", attackerDamage,attackerHp);
            var attacked = new Warrior("Georgi", attackedDamage, attackedHp);

            var attackerExpectedHp = attacker.HP - attacked.Damage;
            var attackedExpectedHp = attacked.HP - attacker.Damage;

            if (attackedExpectedHp < 0)
            {
                attackedExpectedHp = 0;
            }
            attacker.Attack(attacked);

            Assert.AreEqual(attacker.HP, attackerExpectedHp);
            Assert.AreEqual(attacked.HP, attackedExpectedHp);
        }
    }
}