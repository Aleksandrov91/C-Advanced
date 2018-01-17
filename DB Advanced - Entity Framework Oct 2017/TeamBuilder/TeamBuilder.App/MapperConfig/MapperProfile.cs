namespace TeamBuilder.App.MapperConfig
{
    using AutoMapper;
    using TeamBuilder.DTO;
    using TeamBuilder.Models;

    internal class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
