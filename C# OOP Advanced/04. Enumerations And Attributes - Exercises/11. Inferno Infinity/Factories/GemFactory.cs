namespace _11.Inferno_Infinity.Factories
{
    using System;
    using System.Reflection;
    using Interfaces;

    public class GemFactory
    {
        private const string GemNamespace = "_11.Inferno_Infinity.Models.Gems.";

        public static IGem CreateInstance(string gemQuality, string gemType)
        {
            Type type = Type.GetType(GemNamespace + gemType);

            return (IGem) Activator.CreateInstance(type, gemQuality);
        }
    }
}