namespace _11.Inferno_Infinity.Models.Weapons
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Enums;
    using Gems;
    using Interfaces;

    public abstract class Weapon : IWeapon
    {
        private IGem[] sockets;
        private Rarity rarity;

        protected Weapon(string name, string rarity, int minDamage, int maxDamage, int numberOfSockets)
        {
            this.Name = name;
            Enum.TryParse(rarity, out this.rarity);
            this.MinDamage = minDamage * (int)this.Rarity;
            this.MaxDamage = maxDamage * (int)this.Rarity;
            this.sockets = new Gem[numberOfSockets];
        }

        public string Name { get; }

        public int MinDamage { get; }

        public int MaxDamage { get; }

        public IReadOnlyCollection<IGem> Sockets
        {
            get { return this.sockets; }
        }

        public Rarity Rarity
        {
            get { return this.rarity; }
        }

        public void TryAddGem(int socketIndex, IGem gem)
        {
            CheckSockets(socketIndex);

            this.sockets[socketIndex] = gem;
        }

        public void TryRemoveGem(int socketIndex)
        {
            CheckSockets(socketIndex);

            this.sockets[socketIndex] = null;
        }

        public override string ToString()
        {
            int[] totalStats = GetAllStats();

            return $"{this.Name}: {this.MinDamage + (totalStats[0] * 2) + totalStats[1]}-{this.MaxDamage + (totalStats[0] * 3) + (totalStats[1] * 4)} Damage, +{totalStats[0]} Strength, +{totalStats[1]} Agility, +{totalStats[2]} Vitality";
        }

        private void CheckSockets(int socketIndex)
        {
            if (socketIndex < 0 || socketIndex >= this.sockets.Length)
            {
                throw new ArgumentException();
            }
        }

        private int[] GetAllStats()
        {
            int[] stats = new int[3];

            foreach (var socket in this.sockets.Where(g => g != null))
            {
                stats[0] += socket.Strength;
                stats[1] += socket.Agility;
                stats[2] += socket.Vitality;
            }

            return stats;
        }
    }
}