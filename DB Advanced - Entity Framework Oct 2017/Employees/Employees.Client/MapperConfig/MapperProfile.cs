namespace Employees.Client.MapperConfig
{
    using AutoMapper;
    using Employees.Client.Models;
    using Employees.Model;

    internal class MapperProfile : Profile
    {
        public MapperProfile()
        {
            this.CreateMap<Employee, EmployeeDto>();
            this.CreateMap<Employee, EmployeeDetailsDto>();
            this.CreateMap<Employee, ManagerInfoDto>();
        }
    }
}
