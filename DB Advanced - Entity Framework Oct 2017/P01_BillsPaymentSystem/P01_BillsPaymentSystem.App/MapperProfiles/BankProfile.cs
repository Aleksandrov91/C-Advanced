namespace P01_BillsPaymentSystem.App.MapperProfiles
{
    using AutoMapper;
    using P01_BillsPaymentSystem.Data.Models;
    using P01_BillsPaymentSystem.Data.Models.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BankProfile : Profile
    {
        public BankProfile()
        {
            CreateMap<BankAccountViewModel, BankAccount>();
        }
    }
}
