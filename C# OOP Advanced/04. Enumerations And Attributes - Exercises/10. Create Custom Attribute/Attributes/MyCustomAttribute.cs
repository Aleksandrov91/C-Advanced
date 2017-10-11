namespace _10.Create_Custom_Attribute.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Class)]
    public class MyCustomAttribute : Attribute
    {
        public MyCustomAttribute(string author, int revision, string description, params string[] reviewers)
        {
            this.Author = author;
            this.Revision = revision;
            this.Description = description;
            this.Reviewers = reviewers;
        }

        public string Author { get; }

        public int Revision { get; }

        public string Description { get; }

        public string[] Reviewers { get; }
    }
}