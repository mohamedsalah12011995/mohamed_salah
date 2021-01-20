using Eservices.Core.Contracts;
using EServices.Core.Common;
using EServices.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EServices.Infrastructure.Services
{
    public class EntityFieldsService : IEntityFieldsService
    {
        private readonly IRepository<EntityFields> _entityFieldsRepository;
        public EntityFieldsService( IRepository<EntityFields> entityFieldsRepository)
        {
            _entityFieldsRepository = entityFieldsRepository;
        }

        public async Task DeleteById(int id)
        {
            try
            {
                var entityField = await _entityFieldsRepository.GetById(id);
                if (entityField != null)
                {

                    await _entityFieldsRepository.Delete(entityField);

                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IReadOnlyList<EntityFields>> GetAll()
        {
            var entityFields = await _entityFieldsRepository.GetAll();
            return entityFields.ToList();
        }

        public async Task<IReadOnlyList<EntityFields>> GetByEntityId(int id)
        {
            try
            {
                //var entityField = await _entityFieldsRepository.ListAsync(new EntityFieldSpecificationWithEntityId(id));
                //if (entityField != null)
                //{
                //    return entityField;
                //}

                return null;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<EntityFields> GetById(int id)
        {
            try
            {
                var group = await _entityFieldsRepository.GetById(id);
                if (group != null)
                {
                    return group;
                }

                return null;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IReadOnlyList<EntityFields>> GetByPage(int pgNo, int pgSize)
        {
            try
            {
                //var entities = await _entityFieldsRepository.ListAsync(new PaginationSpecification<EntityField>(pgNo, pgSize));
                //if (entities.Count > 0)
                //{
                //    return _mapper.Map<IReadOnlyList<EntityFields>>(entities);
                //}

                return null;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<EntityFields> Save(EntityFields entityField)
        {
            try
            {
                //var post = await _entityFieldsRepository.Insert(entityField);
                //return post;
                return null;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task Update(EntityFields entityField)
        {
            try
            {
                //await _entityFieldsRepository.UpdateAsync(entityField);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
