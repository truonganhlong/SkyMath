using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.DTOs.Responses.Course;
using VissSoft.Core.Entities;
using VissSoft.Core.Interfaces.IRepositories;
using VissSoft.Infrastracture.Data;

namespace VissSoft.Infrastracture.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly VissSoftDbContext _dbContext;
        private readonly IMapper _mapper;
        public CourseRepository(VissSoftDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<CourseDTO>?> readAll()
        {
            try
            {
                List<Course> list = await _dbContext.Courses.ToListAsync();
                if (list == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<List<CourseDTO>>(list);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<CourseDTO?> readById(int id)
        {
            try
            {
                var course = await _dbContext.Courses.FindAsync(id);
                if (course == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<CourseDTO>(course);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
