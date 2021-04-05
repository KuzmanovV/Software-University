using System;
using System.Linq;
using NUnit.Framework;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;
        [SetUp]
        public void Setup()
        {
            arena = new Arena();
        }

        [Test]
        public void CtorInitializeWarriors()
        {
            Assert.That(arena.Warriors, Is.Not.Null);
        }

        [Test]
        public void CountIsZero_WhenArenaEmpty()
        {
            Assert.That(arena.Count, Is.EqualTo(0));
        }

        [Test]
        public void EnrollThrowsException_WhenWarriorAlreadyExist()
        {
            string name = "Warrior";
            arena.Enroll(new Warrior(name, 50,50));

            Assert.Throws<InvalidOperationException>(() => arena.Enroll(new Warrior(name, 55, 55)));
        }

        [Test]
        public void EnrollEncreasesCount()
        {
            arena.Enroll(new Warrior("Warrior", 50,50));

            Assert.That(arena.Count, Is.EqualTo(1));
        }

        [Test]
        public void EnrollAddsWarriorToWarriors()
        {
            string name = "Warrior";
            arena.Enroll(new Warrior(name, 50, 50));

            Assert.That(arena.Warriors.Any(w=>w.Name==name), Is.True);
        }

        [Test]
        public void FightThrowsException_WhenDefenderDoesNotExist()
        {
            string attacker = "Attacker";
            arena.Enroll(new Warrior(attacker,40,40));

            Assert.Throws<InvalidOperationException>(() => arena.Fight(attacker, "Defender"));
        }
        
        [Test]
        public void FightThrowsException_WhenAttackerDoesNotExist()
        {
            string defender = "Defender";
            arena.Enroll(new Warrior(defender,40,40));

            Assert.Throws<InvalidOperationException>(() => arena.Fight( "Attacker", defender));
        }
        
        [Test]
        public void FightThrowsException_WhenAttackerAndDefenderDoesNotExist()
        {
            Assert.Throws<InvalidOperationException>(() => arena.Fight( "Attacker", "Defender"));
        }

        [Test]
        public void FightDecreasesHPOfBothWarriors()
        {
            var initialHPs = 100;

            var attacker = new Warrior("Attacker", 50, initialHPs);
            var defender = new Warrior("Defender", 50, initialHPs);

            arena.Enroll(attacker);
            arena.Enroll(defender);

            arena.Fight(attacker.Name,defender.Name);

            Assert.That(attacker.HP,Is.EqualTo(initialHPs-defender.Damage));
            Assert.That(defender.HP,Is.EqualTo(initialHPs-attacker.Damage));
        }
    }
}
