namespace TeamBuilder.App.Contracts
{
    public interface IDispatcher
    {
        string Dispatch(string commandName, string[] data);
    }
}
