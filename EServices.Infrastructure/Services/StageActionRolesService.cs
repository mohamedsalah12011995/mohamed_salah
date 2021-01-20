using Eservices.Core.Contracts;
using EServices.Core.Common;
using EServices.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EServices.Infrastructure.Services
{
    public class StageActionRolesService : IStageActionRolesService
    {
        private readonly IRepository<StageActionRoles> _StageActionRolesRespository;
        public StageActionRolesService( IRepository<StageActionRoles> staeActionRoleRespository)
        {
            _StageActionRolesRespository = staeActionRoleRespository;
        }
        public async Task<StageActionRoles> GetByRoleId(int id)
        {
            try
            {
                var stage = await _StageActionRolesRespository.GetById(id);
                if (stage != null)
                {
                    return stage;
                }

                return null;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<StageActionRoles> GetByStageActionId(int id)
        {
            try
            {
                //var stage = await _StageActionRolesRespository.ListAsync(new StageRoleSpecificationWithStageActionId(id));
                //if (stage != null)
                //{
                //    return _mapper.Map<StageActionRoles>(stage);
                //}

                return null;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
