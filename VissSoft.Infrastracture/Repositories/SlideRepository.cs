using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.DTOs.Responses.Slide;
using VissSoft.Core.Entities;
using VissSoft.Core.Interfaces.IRepositories;
using VissSoft.Infrastracture.Data;

namespace VissSoft.Infrastracture.Repositories
{
    public class SlideRepository : ISlideRepository
    {
        private readonly VissSoftDbContext _dbContext;
        private readonly IMapper _mapper;
        public SlideRepository(VissSoftDbContext dbContext, IMapper mapper) {
            _dbContext = dbContext;
            _mapper = mapper;   
        }
        public async Task<List<SlideDTO>?> readAll()
        {
            try
            {
                List<Slide> list = await _dbContext.Slides.ToListAsync();
                if (list == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<List<SlideDTO>>(list);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<SlideDTO?> readById(int id)
        {
            try
            {
                var slide = await _dbContext.Slides.FindAsync(id);
                if (slide == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<SlideDTO>(slide);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
