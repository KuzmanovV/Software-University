using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class DummyTests
    {
        private Dummy dummy;
        private Dummy deadDummy;
        private int health = 5;
        private int experience = 10;

        [SetUp]
        public void SetUp()
        {
            dummy = new Dummy(health,experience);
            deadDummy = new Dummy(-5,experience);
        }

        [Test]
        public void WhenHealthAndExperiencePrivided_ShouldBeSetCorectly()
        {
            Assert.That(dummy.Health, Is.EqualTo(health));
        }

        [Test]
        public void WhenAttacked_ShouldDecreaseHealth()
        {
            int attackPoints = 3;
            dummy.TakeAttack(attackPoints);

            Assert.That(dummy.Health,Is.EqualTo(health-attackPoints));
        }

        [Test]
        public void WhenAttackDummyIsDead_ShouldThrow()
        {
            Assert.That(() =>
            {
                deadDummy.TakeAttack(3);
            },Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
        }

        [Test]
        public void WhenHealthPositive_ShouldBeAlive()
        {
            Assert.That(dummy.IsDead(),Is.EqualTo(false));
        }

        [Test]
        public void WhenHealthIsNullOrNegative_ShoulBeDead()
        {
            dummy = new Dummy(0, experience);
            Assert.That(dummy.IsDead(),Is.EqualTo(true));

            Assert.That(deadDummy.IsDead(),Is.EqualTo(true));
        }

        [Test]
        public void WhenDead_ShouldGiveExperience()
        {
            Assert.That(deadDummy.GiveExperience(),Is.EqualTo(experience));
        }

        [Test]
        public void WhenAliveGiveExperience_ShouldThrow()
        {
            Assert.That(()=>
            {
                return dummy.GiveExperience();
            },Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
        }
    }
}