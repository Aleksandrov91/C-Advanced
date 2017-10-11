namespace _11.Inferno_Infinity.Commands
{
    using System.Collections.Generic;

    public abstract class Command
    {
        public abstract void Execute(List<string> parameters);
    }
}