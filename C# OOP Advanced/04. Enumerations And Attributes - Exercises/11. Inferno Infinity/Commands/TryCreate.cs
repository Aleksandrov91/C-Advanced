namespace _11.Inferno_Infinity.Commands
{
    using System.Collections.Generic;
    using Factories;
    using Interfaces;

    public class TryCreate : Command
    {
        public override void Execute(List<string> parameters)
        {
            string[] weaponParameters = parameters[0].Split(' ');

            IWeapon weapon = WeaponFactory.CreateInstance(weaponParameters[1], parameters[1], weaponParameters[0]);
        }
    }
}