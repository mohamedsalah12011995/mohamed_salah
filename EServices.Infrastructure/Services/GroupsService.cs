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
    public class GroupsService : IGroupsService
    {
        private readonly IRepository<Groups> _grouprepository;
        public GroupsService(IRepository<Groups> grouprepository)
        {
            _grouprepository = grouprepository;
        }

        public async Task DeleteById(int id)
        {
            try
            {
                var group = await _grouprepository.GetById(id);
                if (group != null)
                {

                    await _grouprepository.Delete(group);

                }
               

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IReadOnlyList<Groups>> GetAll()
        {
            var groups = await _grouprepository.GetAll();
            return groups.ToList();
        }

        public async Task<Groups> GetById(int id)
        {
            try
            {
                var group = await _grouprepository.GetById(id);
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

        public async Task<IReadOnlyList<Groups>> GetByPage(int pgNo, int pgSize = 10)
        {
            try
            {
                //var groups = await _grouprepository.ListAsync(new PaginationSpecification<Group>(pgNo, pgSize));
                //if (groups.Count > 0)
                //{
                //    return _mapper.Map<IReadOnlyList<Groups>>(groups);
                //}

                return null;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IReadOnlyList<Groups>> GetByParentId(int id)
        {
            try
            {
                //var groups = await _grouprepository.ListAsync(new GroupWithParentIdSpecification(id));
                //if (groups != null)
                //{
                //    return _mapper.Map<IReadOnlyList<Groups>>(groups);
                //}

                return null;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<Groups> Save(Groups group)
        {

            //var post = await _grouprepository.Insert(group);
            //return post;
            return null;
        }

        public async Task Update(Groups group)
        {
            try
            {
               // await _grouprepository.UpdateAsync(group);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
