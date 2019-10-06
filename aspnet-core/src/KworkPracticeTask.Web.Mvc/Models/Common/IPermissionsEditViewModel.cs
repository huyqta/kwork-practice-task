using System.Collections.Generic;
using KworkPracticeTask.Roles.Dto;

namespace KworkPracticeTask.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}