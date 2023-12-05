using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.DTOs.Responses.Slide;

namespace VissSoft.Core.Interfaces.IRepositories
{
    public interface ISlideRepository
    {
        Task<List<SlideDTO>?> readAll();
        Task<SlideDTO?> readById(int id);
    }
}
