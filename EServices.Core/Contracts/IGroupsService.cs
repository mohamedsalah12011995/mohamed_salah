using EServices.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eservices.Core.Contracts
{
    public interface IGroupsService
    {
        Task<IReadOnlyList<Groups>> GetAll();
        Task<Groups> GetById(int id);
        Task<IReadOnlyList<Groups>> GetByParentId(int id);
        Task DeleteById(int id);
        Task Update(Groups group);
        Task<Groups> Save(Groups group);

        Task<IReadOnlyList<Groups>> GetByPage(int pgNo, int pgSize );
    }
}
