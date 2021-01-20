using EServices.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eservices.Core.Contracts
{
    public interface IStageActionRolesService
    {
        Task<StageActionRoles> GetByStageActionId(int id);
        Task<StageActionRoles> GetByRoleId(int id);
    }
}
