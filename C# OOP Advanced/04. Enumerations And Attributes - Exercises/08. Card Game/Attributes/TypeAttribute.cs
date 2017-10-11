namespace _08.Card_Game
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum)]
    public class TypeAttribute : Attribute
    {
        public TypeAttribute(string type, string category, string description)
        {
            this.Type = type;
            this.Category = category;
            this.Description = description;
        }

        public string Type { get; }

        public string Category { get; }

        public string Description { get; }
    }
}
