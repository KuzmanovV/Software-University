using System;
using NUnit.Framework;

namespace Tests
{
    public class WarriorTests
    {
        [SetUp] 
        public void Setup()
        {
        }

        [Test]
        [TestCase("", 50, 100)]
        [TestCase(" ", 50, 100)]
        [TestCase(null, 50, 100)]
        [TestCase("Warrior", 0, 100)]
        [TestCase("Warrior", -50, 100)]
        [TestCase("Warrior", 50, -100)]
        public void CtorThrowsException_WhenDataIsInvalid(string name, int damage, int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, damage, hp));
        }

        [Test]
        [TestCase(15, 40)]
        [TestCase(40, 15)]
        [TestCase(30, 40)]
        [TestCase(40, 30)]
        public void AttackThrowsException_WhenHPIsLessThanMin(int attackerHp, int warriorHp)
        {
            var attacker = new Warrior("Attacker", 50, attackerHp);
            var warrior = new Warrior("Warrior", 10, warriorHp);
            
            Assert.Throws<InvalidOperationException>(() => attacker.Attack(warrior));
        }

        [Test]
        public void AttackThrowsException_WhenWarriorKillsTheAttacker()
        {
            var attacker = new Warrior("Attacker", 50, 40);
            var warrior = new Warrior("Warrior", attacker.HP+1, 40);

            Assert.Throws<InvalidOperationException>(() => attacker.Attack(warrior));
        }

        [Test]
        public void AttackDecreasesAttackerHPAndWarriorHP()
        {
            int initialAttackerHP = 100;
            int initialWarriorHP = 100;
            
            var attacker = new Warrior("Attacker", 50, initialAttackerHP);
            var warrior = new Warrior("Warrior", 30, initialWarriorHP);

            attacker.Attack(warrior);

            Assert.That(attacker.HP,Is.EqualTo(initialAttackerHP-warrior.Damage));
            Assert.That(warrior.HP,Is.EqualTo(initialWarriorHP-attacker.Damage));
        }
        
        [Test]
        public void AttackSetsEnemyHPToZero_WhenAttackersDemageIsGreterThanEnemyHP()
        {
            var attacker = new Warrior("Attacker", 50, 100);
            var warrior = new Warrior("Warrior", 30, 40);

            attacker.Attack(warrior);

            Assert.That(warrior.HP,Is.EqualTo(0));
        }
    }
}