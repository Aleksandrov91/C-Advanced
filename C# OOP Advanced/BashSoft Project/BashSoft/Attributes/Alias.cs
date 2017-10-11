namespace BashSoft.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Class)]
    public class Alias : Attribute
    {
        private string name;

        public Alias(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }

        public override bool Equals(object obj)
        {
            return this.Name.Equals(obj);
        }
    }
}