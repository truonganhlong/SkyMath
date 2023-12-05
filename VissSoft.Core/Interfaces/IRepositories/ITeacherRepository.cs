using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.DTOs.Responses.Teacher;

namespace VissSoft.Core.Interfaces.IRepositories
{
    public interface ITeacherRepository
    {
        Task<List<TeacherDTO>?> readAll();
        Task<TeacherDTO?> readById(int id);
    }
}
