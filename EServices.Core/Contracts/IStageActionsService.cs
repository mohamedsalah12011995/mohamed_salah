using EServices.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eservices.Core.Contracts
{
    public interface IStageActionsService
    {
        Task<IReadOnlyList<StageActions>> GetAll();
        Task<StageActions> GetById(int id);
        Task<IReadOnlyList<StageActions>> GetByStageId(int id);
        Task DeleteById(int id);
        Task Update(StageActions entity);
        Task<StageActions> Save(StageActions entity);
        Task<IReadOnlyList<StageActions>> GetByPage(int pgNo, int pgSize);
    }
}
