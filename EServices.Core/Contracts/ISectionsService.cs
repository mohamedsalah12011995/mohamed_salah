using EServices.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eservices.Core.Contracts
{
    public interface ISectionsService
    {
        Task<IReadOnlyList<Sections>> GetAll();
    }
}
