using Abp.AutoMapper;
using MeiLian.Authorization.Users;
using MeiLian.Authorization.Users.Dto;
using MeiLian.Web.Areas.Mpa.Models.Common;

namespace MeiLian.Web.Areas.Mpa.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}
