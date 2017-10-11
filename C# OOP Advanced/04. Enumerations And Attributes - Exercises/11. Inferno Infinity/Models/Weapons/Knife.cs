namespace _11.Inferno_Infinity.Models.Weapons
{
    using Interfaces;

    public class Knife : Weapon, IWeapon
    {
        private const int KnifeMinDamage = 3;
        private const int KnifeMaxDamage = 4;
        private const int KnifeNumberOfSockets = 2;

        public Knife(string name, string rarity)
            : base(name, rarity, KnifeMinDamage, KnifeMaxDamage, KnifeNumberOfSockets)
        {
        }
    }
}