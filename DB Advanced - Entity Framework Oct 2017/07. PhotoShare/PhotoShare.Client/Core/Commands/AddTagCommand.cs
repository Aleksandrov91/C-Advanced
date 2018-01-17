namespace PhotoShare.Client.Core.Commands
{
    using System;


    using PhotoShare.Client.Contracts;
    using PhotoShare.Models;
    using PhotoShare.Services.Contracts;
    using Utilities;
    using PhotoShare.Client.Sessions;

    public class AddTagCommand : ICommand
    {
        private readonly ITagService tagService;

        public AddTagCommand(ITagService tagService)
        {
            this.tagService = tagService;
        }

        // AddTag <tag>
        public string Execute(string[] data)
        {
            string tagName = data[0].ValidateOrTransform();

            Tag tag = this.tagService.ByName(tagName);

            if (CurrentSession.LoggedUser == null)
            {
                throw new InvalidOperationException("Invalid credentials!");
            }
            else if (tag != null)
            {
                throw new ArgumentException($"Tag {tagName} exists!");
            }

            this.tagService.Add(tagName);

            return $"Tag {tagName} was added successfully!";
        }
    }
}
