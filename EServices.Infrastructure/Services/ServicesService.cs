using Eservices.Core.Contracts;

using EServices.Core.Common;
using EServices.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace EServices.Infrastructure.Services
{
    public class ServicesService : IServicesService
    {
        private readonly IRepository<EServices.Core.Data.Services> _serviceRepository;

        public ServicesService( IRepository<EServices.Core.Data.Services> serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        public async Task<IReadOnlyList<EServices.Core.Data.Services>> GetById(int id)
        {
            try
            {
                return await _serviceRepository.DataSet.Where(x=> x.Id==id)
                                .Include(x => x.Stages).ThenInclude(x => x.StageForms)
                                .ThenInclude(x => x.Form).ThenInclude(x => x.FormSections)
                                .ThenInclude(x => x.FormSectionFields).ThenInclude(x => x.FormFieldConstraints)
                                .ThenInclude(x => x.FieldConstraintType)

                                 .Include(x => x.Stages).ThenInclude(x => x.StageForms)
                                .ThenInclude(x => x.Form).ThenInclude(x => x.FormSections)
                                .ThenInclude(x => x.FormSectionAttachments)

                                .Include(x => x.Stages).ThenInclude(x => x.StageForms)
                                .ThenInclude(x => x.Form).ThenInclude(x => x.FormSections)
                                .ThenInclude(x => x.FormSectionFields).ThenInclude(x => x.EntityField)
                                .ThenInclude(x => x.Entity)

                                .Include(x => x.Stages).ThenInclude(x => x.StageForms)
                                .ThenInclude(x => x.Form).ThenInclude(x => x.FormSections)
                                .ThenInclude(x => x.FormSectionFields).ThenInclude(x => x.EntityField)
                                .ThenInclude(x => x.FieldType)
                                .ToListAsync();
            }
            catch (System.Exception ex)
            {
                return null;
            }            
        }
        public async Task<IReadOnlyList<EServices.Core.Data.Services>> GetyByGroupId(int id)
        {
            try
            {

                return await _serviceRepository.Get(x=> x.GroupId==id);

            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        public async Task DeleteById(int id)
        {
            try
            {
                var entity = await _serviceRepository.GetById(id);
                if (entity != null)
                {

                    await _serviceRepository.Delete(entity);

                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IReadOnlyList<EServices.Core.Data.Services>> GetAll()
        {
            return await _serviceRepository.DataSet

                .Include(x => x.Stages).ThenInclude(x => x.StageForms)
                .ThenInclude(x => x.Form).ThenInclude(x => x.FormSections)
                .ThenInclude(x => x.FormSectionFields).ThenInclude(x => x.FormFieldConstraints)
                .ThenInclude(x=> x.FieldConstraintType)

                 .Include(x => x.Stages).ThenInclude(x => x.StageForms)
                .ThenInclude(x => x.Form).ThenInclude(x => x.FormSections)
                .ThenInclude(x => x.FormSectionAttachments)

                .Include(x => x.Stages).ThenInclude(x => x.StageForms)
                .ThenInclude(x => x.Form).ThenInclude(x => x.FormSections)
                .ThenInclude(x => x.FormSectionFields).ThenInclude(x => x.EntityField)
                .ThenInclude(x=> x.Entity)

                .Include(x => x.Stages).ThenInclude(x => x.StageForms)
                .ThenInclude(x => x.Form).ThenInclude(x => x.FormSections)
                .ThenInclude(x => x.FormSectionFields).ThenInclude(x => x.EntityField)
                .ThenInclude(x => x.FieldType)


                .ToListAsync();


                //.Include(x => x.Stages).ThenInclude(x=> x.StageActions)
        }

        public async Task Update(EServices.Core.Data.Services service)
        {
            try
            {
                //await _serviceRepository.UpdateAsync(datatoUpdate);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<EServices.Core.Data.Services> Save(EServices.Core.Data.Services service)
        {
            //var post = await _serviceRepository.Insert(service);
            return null;
        }

        public async Task<IReadOnlyList<EServices.Core.Data.Services>> GetByPage(int pgNo, int pgSize)
        {
            try
            {
                //var services = await _serviceRepository.ListAsync(new PaginationSpecification<Service>(pgNo, pgSize));
                //if (services.Count > 0)
                //{
                //    return _mapper.Map<IReadOnlyList<EServices.Core.Data.Services>>(services);
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
