namespace P01_BillsPaymentSystem.App.MapperProfiles
{
    using AutoMapper;
    using P01_BillsPaymentSystem.Data.Models;
    using P01_BillsPaymentSystem.Data.Models.ViewModels;
    using System.Linq;

    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>()
                .ForMember(
                    uvm => uvm.PaymentMethods,
                    cfg => cfg.MapFrom(u => u.PaymentMethods
                    .Where(x => x.BankAccount != null)
                    .Select(pm => pm.BankAccount))
                )
                .ForMember(
                    uvm => uvm.PaymentMethods,
                    cfg => cfg.MapFrom(u => u.PaymentMethods
                    .Where(pm => pm.CreditCard != null)
                    .Select(pm => pm.CreditCard))
                );
        }
    }
}
