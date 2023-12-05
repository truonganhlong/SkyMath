using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.DTOs.Responses.NewAndEvent;
using VissSoft.Core.Entities;
using VissSoft.Core.Interfaces.IRepositories;
using VissSoft.Infrastracture.Data;

namespace VissSoft.Infrastracture.Repositories
{
    public class NewAndEventRepository : INewAndEventRepository
    {
        private readonly VissSoftDbContext _dbContext;
        private IMapper _mapper;
        public NewAndEventRepository(VissSoftDbContext dbContext, IMapper mapper) {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<NewAndEventDTO>?> readAll()
        {
            try
            {
                List<NewAndEvent> list = await _dbContext.NewAndEvents.ToListAsync();
                if (list == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<List<NewAndEventDTO>>(list);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<NewAndEventDTO?> readById(int id)
        {
            try
            {
                var newAndEvent = await _dbContext.NewAndEvents.FindAsync(id);
                if (newAndEvent == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<NewAndEventDTO>(newAndEvent);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
