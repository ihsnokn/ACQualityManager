using AutoMapper;
using QM.Common.ViewModels.Users.AppRoleViewModels;
using QM.Common.ViewModels.Users.AppUserViewModels;
using QM.Entities.Concrete.Users;

namespace QM.Common.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            #region AppRole
            CreateMap<AppRole, AppRoleListViewModel>().ReverseMap();
            CreateMap<AppRole, AppRoleAddViewModel>().ReverseMap();
            CreateMap<AppRole, AppRoleUpdateViewModel>().ReverseMap();
            #endregion

            #region AppUser
            CreateMap<AppUser, AppUserListViewModel>().ReverseMap();
            CreateMap<AppUser, AppUserAddViewModel>().ReverseMap();
            CreateMap<AppUser, AppUserUpdateViewModel>().ReverseMap();
            CreateMap<AppUser, AppUserLogInViewModel>().ReverseMap();
            #endregion
         
        }
    }
}
