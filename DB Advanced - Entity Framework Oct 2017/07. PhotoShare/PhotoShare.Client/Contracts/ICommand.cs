namespace PhotoShare.Client.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ICommand
    {
        string Execute(params string[] data);
    }
}
