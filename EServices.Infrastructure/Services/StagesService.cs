using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EServices.Core.Common;
using EServices.Core.Data;
using Eservices.Core.Contracts;
using System.Linq;

namespace EServices.Infrastructure.Services
{

    public class StagesService : IStagesService
    {
        private readonly IRepository<Stages> _stageRepository;
        public StagesService(IRepository<Stages> stageRepository)
        {
            _stageRepository = stageRepository;
        }

        public async Task DeleteById(int id)
        {
            try
            {
                var entity = await _stageRepository.GetById(id);
                if (entity != null)
                {

                    await _stageRepository.Delete(entity);

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IReadOnlyList<Stages>> GetAll()
        {
            var stages = await _stageRepository.GetAll();
            return stages.ToList();
        }

        public async Task<Stages> GetById(int id)
        {
            try
            {
                var stages = await _stageRepository.GetById(id);
                if (stages != null)
                {
                    return stages;
                }

                return null;
            }
            catch (Exception ex)
            {

                throw;
            }

        }


        public async Task<IReadOnlyList<Stages>> GetByPage(int pgNo, int pgSize)
        {
            try
            {
                //var stages = await _stageRepository.ListAsync(new PaginationSpecification<Stage>(pgNo, pgSize));
                //if (stages.Count > 0)
                //{
                //    return _mapper.Map<IReadOnlyList<Stages>>(stages);
                //}

                return null;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<Stages> Save(Stages stages)
        {
            try
            {
                //var post = await _stageRepository.Insert(stages);
                return null;


            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task Update(Stages entity)
        {
            try
            {
               // await _stageRepository.UpdateAsync(datatoSave);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
