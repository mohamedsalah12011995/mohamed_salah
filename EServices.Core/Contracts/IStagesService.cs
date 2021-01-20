using EServices.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eservices.Core.Contracts
{
    public interface IStagesService    
    {
        Task<IReadOnlyList<Stages>> GetAll();
        Task<Stages> GetById(int id);
        Task DeleteById(int id);
        Task Update(Stages entity);
        Task<Stages> Save(Stages entity);
        Task<IReadOnlyList<Stages>> GetByPage(int pgNo, int pgSize);
    }
}
