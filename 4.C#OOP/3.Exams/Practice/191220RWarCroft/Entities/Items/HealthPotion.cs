using WarCroft.Entities.Characters.Contracts;

namespace WarCroft.Entities.Items
{
    public class HealthPotion: Item
    {
        public HealthPotion() 
            : base(5)
        {
        }

        void AffectCharacter(Character character)
        {
        }
    }
}