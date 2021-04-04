using NUnit.Framework;
using System;

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
            item = new Item("me","1");
        }

        [Test]
        public void NoSuchCellExists()
        {
            Exception ex = Assert.Throws<ArgumentException>(() => vault.AddItem("missingCell", item));

            Assert.AreEqual(ex.Message,"Cell doesn't exists!");
        }
        
        [Test]
        public void CellAlreadyFull()
        {
            vault.AddItem("A2", item);
            
            Exception ex = Assert.Throws<ArgumentException>(() => vault.AddItem("A2", new Item("me", "1")));

            Assert.AreEqual(ex.Message, "Cell is already taken!");
        }
        
        [Test]
        public void ItemAlreadyExistsInCell()
        {
            vault.AddItem("A2", item);
            
            Exception ex = Assert.Throws<InvalidOperationException>(() => vault.AddItem("A1", item));

            Assert.AreEqual(ex.Message, "Item is already in cell!");
        }
        
        [Test]
        public void CorrectMessageWhenAdded()
        {
            string result = vault.AddItem("A2", item);

            Assert.That(result, Is.EqualTo($"Item:{item.ItemId} saved successfully!"));
        }

        [Test]
        public void NoSuchCellExistsWhenRemoving()
        {
            Exception ex = Assert.Throws<ArgumentException>(() => vault.RemoveItem("noSuchCell", item));

            Assert.AreEqual(ex.Message, "Cell doesn't exists!");
        }
        
        [Test]
        public void ItemToRemoveNotTheSame()
        {
            Exception ex = Assert.Throws<ArgumentException>(() => vault.RemoveItem("A2", item));

            Assert.AreEqual(ex.Message, "Item in that cell doesn't exists!");
        }

        [Test]
        public void CorrectMessageWhenRemoved()
        {
            vault.AddItem("A2",item);
            string result = vault.RemoveItem("A2", item);

            Assert.AreEqual(result, $"Remove item:{item.ItemId} successfully!");
        }
    }
}