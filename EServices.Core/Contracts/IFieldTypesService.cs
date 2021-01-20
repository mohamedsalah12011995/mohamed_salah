using EServices.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eservices.Core.Contracts
{
    public interface IFieldTypesService
    {
        Task<IReadOnlyList<FieldTypes>> GetAll();
        Task<IReadOnlyList<FieldTypes>> GetByPage(int pgNo, int pgSize);
    }
}
