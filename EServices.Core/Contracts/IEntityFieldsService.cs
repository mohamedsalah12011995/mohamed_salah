
using EServices.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Eservices.Core.Contracts
{
    public interface IEntityFieldsService
    {
        Task<IReadOnlyList<EntityFields>> GetAll();
        Task<EntityFields> GetById(int id);
        Task<IReadOnlyList<EntityFields>> GetByEntityId(int id);
        Task DeleteById(int id);
        Task Update(EntityFields entityField);
        Task<EntityFields> Save(EntityFields entityField);
        Task<IReadOnlyList<EntityFields>> GetByPage(int pgNo, int pgSize);
    }
}
