namespace _11.Inferno_Infinity.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Interfaces;

    public class WeaponFactory
    {
        public static IWeapon CreateInstance(string type, string name, string rarity)
        {
            Type classType = Assembly.GetExecutingAssembly().GetTypes().First(t => t.Name == type);

            return (IWeapon)Activator.CreateInstance(classType, name, rarity);
        }
    }
}