namespace P01_BillsPaymentSystem.App.MapperProfiles
{
    using AutoMapper;
    using P01_BillsPaymentSystem.Data.Models;
    using P01_BillsPaymentSystem.Data.Models.ViewModels;

    public class CardProfile : Profile
    {
        public CardProfile()
        {
            CreateMap<CreditCardViewModel, CreditCard>();
        }
    }
}
