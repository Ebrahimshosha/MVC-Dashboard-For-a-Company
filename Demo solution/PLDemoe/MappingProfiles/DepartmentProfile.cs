using AutoMapper;
using DALDemo.Models;
using PLDemoe.ViewModels;

namespace PLDemoe.MappingProfiles
{
	public class DepartmentProfile:Profile
	{
        public DepartmentProfile()
        {
            CreateMap<DepartmentViewModel, Department>().ReverseMap();
        }
    }
}
