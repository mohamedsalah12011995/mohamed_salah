using Eservices.Core.Contracts;
using EServices.Core.Common;
using EServices.Core.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EServices.Infrastructure.Services
{
    public class SectionsService : ISectionsService
    {
        private readonly IRepository<Sections> _sectionRepository;
        public SectionsService( IRepository<Sections> sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }
        public async Task<IReadOnlyList<Sections>> GetAll()
        {
            //var sections = await _sectionRepository.ListAsync(new SectionWithDetailsSpecification());
            //return _mapper.Map<IReadOnlyList<Sections>>(sections);
            var sections = await _sectionRepository.GetAll();
            return sections.ToList();
        }
    }
}
