    using EServices.Core.Data;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    namespace Eservices.Core.Contracts
    {
        public interface IEntitiesService
        {
            Task<IReadOnlyList<Entities>> GetAll();
            Task<Entities> GetById(int id);
            Task<IReadOnlyList<Entities>> GetByName(string name);
            Task DeleteById(int id);
            Task Update(Entities entity);
            Task<Entities> Save(Entities entity);
            Task<IReadOnlyList<Entities>> GetByPage(int pgNo, int pgSize);


        }
    }


