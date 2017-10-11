namespace _11.Inferno_Infinity
{
    using Commands;

    public class Startup
    {
        public static void Main()
        {
            CommandInterpreter engine = new CommandInterpreter();
            engine.Run();
        }
    }
}
