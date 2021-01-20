using EServices.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eservices.Core.Contracts
{
    public interface IServicesService
    {
        Task<IReadOnlyList<Services>> GetAll();
        Task<IReadOnlyList<Services>> GetById(int id);
        Task DeleteById(int id);
        Task<IReadOnlyList<Services>> GetyByGroupId(int id);
        Task Update(Services service);
        Task<Services> Save(Services service);
        Task<IReadOnlyList<Services>> GetByPage(int pgNo, int pgSize);
    }
}
