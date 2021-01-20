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

    public class StageActionsService : IStageActionsService
    {
        private readonly IRepository<StageActions> _stageActionRepository;
        public StageActionsService( IRepository<StageActions> stageActionRepository)
        {
            _stageActionRepository = stageActionRepository;
        }

        public async Task DeleteById(int id)
        {
            try
            {
                var stageAction = await _stageActionRepository.GetById(id);
                if (stageAction != null)
                {

                    await _stageActionRepository.Delete(stageAction);

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IReadOnlyList<StageActions>> GetAll()
        {
            var stages = await _stageActionRepository.GetAll();
            return stages.ToList();
        }

        public async Task<StageActions> GetById(int id)
        {
            try
            {
                var stages = await _stageActionRepository.GetById(id);
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


        public async Task<IReadOnlyList<StageActions>> GetByPage(int pgNo, int pgSize)
        {
            try
            {
                //var stages = await _stageActionRepository.ListAsync(new PaginationSpecification<StageAction>(pgNo, pgSize));
                //if (stages.Count > 0)
                //{
                //    return _mapper.Map<IReadOnlyList<StageActions>>(stages);
                //}

                return null;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IReadOnlyList<StageActions>> GetByStageId(int id)
        {
            try
            {
                //var stageAction = await _stageActionRepository.ListAsync(new StageActionWithStageIdSpecification(id));
                //if (stageAction != null)
                //{
                //    return _mapper.Map<IReadOnlyList<StageActions>>(stageAction);
                //}

                return null;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<StageActions> Save(StageActions stageAction)
        {
            try
            {
                //var post = await _stageActionRepository.Insert(stageAction);
                return null;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task Update(StageActions stageAction)
        {
            try
            {
                //await _stageActionRepository.UpdateAsync(stageAction);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
