
using EServices.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eservices.Core.Contracts
{
    public interface IFieldLookupsService
    {
        Task<IReadOnlyList<FiledLookups>> GetAll();
        Task<IReadOnlyList<FiledLookups>> GetById(int id);
    }
}
