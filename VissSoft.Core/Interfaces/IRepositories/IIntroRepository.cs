using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.DTOs.Responses.Intro;

namespace VissSoft.Core.Interfaces.IRepositories
{
    public interface IIntroRepository
    {
        Task<List<IntroDTO>?> readAll();
        Task<IntroDTO?> readById(int id);
    }
}
