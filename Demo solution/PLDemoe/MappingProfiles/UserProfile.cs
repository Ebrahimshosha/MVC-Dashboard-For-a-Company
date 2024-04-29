using AutoMapper;
using DALDemo.Models;
using PLDemoe.ViewModels;

namespace PLDemoe.MappingProfiles
{
	public class UserProfile:Profile
	{
        public UserProfile()
        {
            CreateMap<ApplicationUser,UserViewModel>().ReverseMap();
        }
    }
}
