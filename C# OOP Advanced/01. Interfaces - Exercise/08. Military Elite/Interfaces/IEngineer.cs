namespace _08.Military_Elite.Interfaces
{
    using System.Collections.Generic;

    public interface IEngineer : ISpecialisedSoldier
    {
        List<IRepairable> Repairs { get; }
    }
}
