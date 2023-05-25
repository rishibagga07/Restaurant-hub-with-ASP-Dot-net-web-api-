using AutoMapper;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Model.DTO;

namespace Restaurants_MinimalAPI_Mediator.DTOMapping
{
    public class MappingProfile : Profile
    {
     //   public MappingProfile()
     //   {
     ////       CreateMap<AddRestaurantsDTO, RestaurantsRegi>()
     ////.ForMember(dest => dest.RestID, opt => opt.Ignore())
     ////.ForMember(dest => dest.City, opt => opt.MapFrom(src => new City { CityID = src.CityID }))
     ////.ForMember(dest => dest.Role, opt => opt.Ignore())
     ////.ForMember(dest => dest.Approval, opt => opt.MapFrom(src => new Approval { ApprovalID = src.ApprovalID?? 0 }))
     ////.ReverseMap();

     //       CreateMap<RoleDTO , Role>().ReverseMap();
     //   }
    }
}
