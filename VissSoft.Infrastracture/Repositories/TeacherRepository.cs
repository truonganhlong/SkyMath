using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.DTOs.Responses.Teacher;
using VissSoft.Core.Entities;
using VissSoft.Core.Interfaces.IRepositories;
using VissSoft.Infrastracture.Data;

namespace VissSoft.Infrastracture.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly VissSoftDbContext _dbContext;
        private readonly IMapper _mapper;
        public TeacherRepository(VissSoftDbContext dbContext, IMapper mapper) {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<TeacherDTO>?> readAll()
        {
            try
            {
                List<Teacher> list = await _dbContext.Teachers.ToListAsync();
                if (list == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<List<TeacherDTO>>(list);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<TeacherDTO?> readById(int id)
        {
            try
            {
                var teacher = await _dbContext.Teachers.FindAsync(id);
                if (teacher == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<TeacherDTO>(teacher);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
