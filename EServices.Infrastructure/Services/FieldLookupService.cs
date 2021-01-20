using Eservices.Core.Contracts;
using EServices.Core.Common;
using EServices.Core.Data;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EServices.Infrastructure.Services
{
    public class FieldLookupService : IFieldLookupsService
    {
        private readonly IRepository<FiledLookups> _filedLookupRepository;
        public FieldLookupService( IRepository<FiledLookups> filedLookupRepository)
        {
            _filedLookupRepository = filedLookupRepository;
        }






        public async Task<IReadOnlyList<FiledLookups>> GetById(int entityFieldId)
        {
            try
            {
                //var FiledLookups = await _filedLookupRepository.ListAsync(new FiledLookupWithDetailsSpecification(entityFieldId));
                //var FiledLookUpList = _mapper.Map<IReadOnlyList<FiledLookups>>(FiledLookups.Where(w => w.EntityFieldId == entityFieldId)).ToList();
                //return FiledLookUpList;
                return null;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }


        public async Task<IReadOnlyList<FiledLookups>> GetAll()
        {
            return null;
        }
    }
}
