namespace P01_BillsPaymentSystem.App
{
    using AutoMapper;
    using P01_BillsPaymentSystem.App.MapperProfiles;

    public static class MappingConfig
    {
        public static void RegisterMaps()
        {
            Mapper.Initialize(config =>
            {
                config.AddProfile<BankProfile>();
                config.AddProfile<UserProfile>();
                config.AddProfile<CardProfile>();
            });
        }
    }
}
