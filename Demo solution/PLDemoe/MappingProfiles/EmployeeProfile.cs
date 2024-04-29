using AutoMapper;
using DALDemo.Models;
using PLDemoe.ViewModels;

namespace PLDemoe.MappingProfiles
{
	public class EmployeeProfile:Profile
	{
        public EmployeeProfile()
        {
            CreateMap<EmployeeViewModel, Employee>().ReverseMap();
        }
    }
}
