using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.DTOs.Responses.Intro;
using VissSoft.Core.Entities;
using VissSoft.Core.Interfaces.IRepositories;
using VissSoft.Infrastracture.Data;

namespace VissSoft.Infrastracture.Repositories
{
    public class IntroRepository : IIntroRepository
    {
        private readonly VissSoftDbContext _dbContext;
        private readonly IMapper _mapper;
        public IntroRepository(VissSoftDbContext dbContext, IMapper mapper) {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<IntroDTO>?> readAll()
        {
            try
            {
                List<Intro> list = await _dbContext.Intros.ToListAsync();
                if (list == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<List<IntroDTO>>(list);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<IntroDTO?> readById(int id)
        {
            try
            {
                var intro = await _dbContext.Intros.FindAsync(id);
                if (intro == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<IntroDTO>(intro);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
