using Eservices.Core.Contracts;
using EServices.Core.Common;
using EServices.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EServices.Infrastructure.Services
{
    public class EntitiesService : IEntitiesService
    {
        private readonly IRepository<Entities> _entityRepository;
        public EntitiesService( IRepository<Entities> entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public async Task DeleteById(int id)
        {
            try
            {
                var entity = await _entityRepository.GetById(id);
                if (entity != null)
                {

                    await _entityRepository.Delete(entity);

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IReadOnlyList<Entities>> GetAll()
        {
            var sections = await _entityRepository.GetAll();
            return sections.ToList();
        }

        public async Task<Entities> GetById(int id)
        {
            try
            {
                var entities = await _entityRepository.GetById(id);
                if (entities != null)
                {
                    return entities;
                }

                return null;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public async Task<IReadOnlyList<Entities>> GetByName(string name)
        {
            try
            {
                List<Entities> entities = await _entityRepository.Get(x => x.Name == name,
                                         f=> f.EntityFields, x => x.EntityRelationshipsFromEntity, t => t.EntityRelationshipsToEntity);

                if (entities.Count > 0)
                {
                     return entities;
                    //return null;
                }

                return null;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IReadOnlyList<Entities>> GetByPage(int pgNo, int pgSize)
        {
            try
            {
                //var entities = await _entityRepository.ListAsync(new PaginationSpecification<Entity>(pgNo, pgSize));
                //if (entities.Count > 0)
                //{
                //    return _mapper.Map<IReadOnlyList<OnlyEntityDTO>>(entities);
                //}

                return null;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<Entities> Save(Entities entity)
        {
            try
            {
                //var datatoSave = _mapper.Map<Entities>(entity);
                //var post = await _entityRepository.Insert(datatoSave);
                //return _mapper.Map<OnlyEntityDTO>(post);

                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task Update(Entities entity)
        {
            try
            {
                //var datatoSave = _mapper.Map<Entities>(entity);
                //await _entityRepository.UpdateAsync(datatoSave);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
