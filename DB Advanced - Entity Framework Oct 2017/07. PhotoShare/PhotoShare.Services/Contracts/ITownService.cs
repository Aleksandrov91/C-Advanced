namespace PhotoShare.Services.Contracts
{
    using PhotoShare.Models;

    public interface ITownService
    {
        Town ByName(string townName);

        Town Add(string townName, string countryName);
    }
}
