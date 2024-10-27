using AutoMapper;
using BusinessObjects.Business;
using BusinessObjects.Systems;
using HomeRentals.Models.Business;
using HomeRentals.Models.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class ObjectMapper
    {
        public static IMapper Mapper;

        public static void CreateMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            Mapper = config.CreateMapper();
        }

        public static TDestination Map<TDestination>(object source)
        {
            return Mapper.Map<TDestination>(source);
        }

        public static TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            return Mapper.Map(source, destination);
        }

        public static IQueryable<TDestination> ProjectTo<TDestination>(IQueryable source)
        {
            return Mapper.ProjectTo<TDestination>(source);
        }
    }

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LoginModel, LoginEntity>().ReverseMap();
            CreateMap<ConnectionModel, ConnectionEntity>().ReverseMap();
            CreateMap<UserModel, UserEntity>().ReverseMap();
            CreateMap<CustomerModel, CustomerEntity>().ReverseMap();
        }
    }
}
