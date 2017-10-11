namespace _11.Inferno_Infinity.Models.Weapons
{
    using Interfaces;

    public class Sword : Weapon, IWeapon
    {
        private const int SwordMinDamage = 4;
        private const int SwordMaxDamage = 6;
        private const int SwordNumberOfSockets = 3;

        public Sword(string name, string rarity)
            : base(name, rarity, SwordMinDamage, SwordMaxDamage, SwordNumberOfSockets)
        {
        }
    }
}