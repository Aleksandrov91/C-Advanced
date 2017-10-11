namespace _11.Inferno_Infinity.Interfaces
{
    using System.Collections.Generic;
    using Enums;

    public interface IWeapon
    {
        string Name { get; }

        int MinDamage { get; }

        int MaxDamage { get; }

        IReadOnlyCollection<IGem> Sockets { get; }

        Rarity Rarity { get; }

        void TryAddGem(int socketIndex, IGem gem);

        void TryRemoveGem(int socketIndex);
    }
}