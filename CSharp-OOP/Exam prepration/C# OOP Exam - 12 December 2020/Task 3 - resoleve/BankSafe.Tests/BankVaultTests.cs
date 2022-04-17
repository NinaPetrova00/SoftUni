using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault vault;
        private Item item;
        [SetUp]
        public void Setup()
        {
            vault = new BankVault();
            item = new Item("me", "1");
        }

        [Test]
        public void AddItem_ThrowException_WhenCellDoesNotExist()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.AddItem("doesn't exist", item);
            });

            Assert.AreEqual(ex.Message, "Cell doesn't exists!");
        }

        [Test]
        public void AddItem_ThrowException_WhenCellIsAlreadyTaken()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.AddItem("A2", item);
                vault.AddItem("A2", new Item("ivan", "3"));
            });

            Assert.AreEqual(ex.Message, "Cell is already taken!");
        }

        [Test]
        public void AddItem_ThrowException_WhenItemAlreadyExists()
        {
            Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                vault.AddItem("A2", item);
                vault.AddItem("B2", item);
            });

            Assert.AreEqual(ex.Message, "Item is already in cell!");
        }
        [Test]
        public void AddItem_ItemSetSuccessfully()
        {
            string result = vault.AddItem("A2", item);

            Assert.AreEqual(result, $"Item:{item.ItemId} saved successfully!");
        }
        [Test]
        public void AddItem_WhenItemSetSuccessfully_ShouldSetItemToCell() 
        {
            string result = vault.AddItem("A2", item);

            Assert.AreEqual(item,vault.VaultCells["A2"]);
        }

        [Test]
        public void RemoveItem_ThrowsExcpetion_WhenCellDoesNotExist()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.RemoveItem("B852", item);
            });

            Assert.AreEqual(ex.Message, "Cell doesn't exists!");
        }

        [Test]
        public void RemoveItem_ThrowsExcpetion_WhenItemDoesNotExist()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.RemoveItem("A1", item);
            });

            Assert.AreEqual(ex.Message, $"Item in that cell doesn't exists!");
        }

        [Test]
        public void RemoveItem_ItemSuccessfullyRemoved()
        {
            vault.AddItem("A1", item);

            string result = vault.RemoveItem("A1", item);

            Assert.AreEqual(result, $"Remove item:{item.ItemId} successfully!");
        }

        [Test]
        public void RemoveItem_WhenItemSuccessfullyRemoved_MakeTheCellNull()
        {
            vault.AddItem("A1", item);

            string result = vault.RemoveItem("A1", item);

            Assert.AreEqual(null, vault.VaultCells["A1"]);
        }

        [Test] // not needed for Judge 
        public void Ctor_WhenVaultIsInitialised_ShouldHaveCorrectCells()
        {
            var initialValue = new Dictionary<string, Item>
            {
                {"A1", null},
                {"A2", null},
                {"A3", null},
                {"A4", null},
                {"B1", null},
                {"B2", null},
                {"B3", null},
                {"B4", null},
                {"C1", null},
                {"C2", null},
                {"C3", null},
                {"C4", null},
            };

            var initalValuesAsList = initialValue.ToImmutableDictionary().ToList();

            var vaultValuesAsList = vault.VaultCells.ToList();

            for (int i = 0; i < initalValuesAsList.Count; i++)
            {
                Assert.AreEqual(initalValuesAsList[i].Key,vaultValuesAsList[i].Key);
                Assert.AreEqual(initalValuesAsList[i].Value,vaultValuesAsList[i].Value);
            }
        }
    }
}