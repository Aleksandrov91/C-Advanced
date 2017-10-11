namespace _11.Inferno_Infinity.Models.Weapons
{
    using Interfaces;

    public class Axe : Weapon, IWeapon
    {
        private const int AxeMinDamage = 5;
        private const int AxeMaxDamage = 10;
        private const int AxeNumberOfSockets = 4;

        public Axe(string name,string rarity)
            : base(name, rarity, AxeMinDamage, AxeMaxDamage, AxeNumberOfSockets)
        {
        }
    }
}