using Eservices.Core.Contracts;
using EServices.Core.Common;
using EServices.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EServices.Infrastructure.Services.Interfaces
{
    public class FieldTypeService : IFieldTypesService
    {
        private readonly IRepository<FieldTypes> _fieldTypesRepository;
        public FieldTypeService( IRepository<FieldTypes> fieldTypeRepository)
        {
            _fieldTypesRepository = fieldTypeRepository;
        }
        public async Task<IReadOnlyList<FieldTypes>> GetAll()
        {
            var entityFields = await _fieldTypesRepository.GetAll();
            return entityFields.ToList();
        }

        public async Task<IReadOnlyList<FieldTypes>> GetByPage(int pgNo, int pgSize)
        {
            try
            {
                //var fieldTypes = await _fieldTypesRepository.ListAsync(new PaginationSpecification<FieldType>(pgNo, pgSize));
                //if (fieldTypes.Count > 0)
                //{
                //    return _mapper.Map<IReadOnlyList<FieldTypes>>(fieldTypes);
                //}

                return null;

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
