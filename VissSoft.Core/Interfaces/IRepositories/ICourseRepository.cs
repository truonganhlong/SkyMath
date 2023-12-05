using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.DTOs.Responses.Course;

namespace VissSoft.Core.Interfaces.IRepositories
{
    public interface ICourseRepository
    {
        Task<List<CourseDTO>?> readAll();
        Task<CourseDTO?> readById(int id);
    }
}
