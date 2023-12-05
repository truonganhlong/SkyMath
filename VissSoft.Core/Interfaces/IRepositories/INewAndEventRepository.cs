using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.DTOs.Responses.NewAndEvent;

namespace VissSoft.Core.Interfaces.IRepositories
{
    public interface INewAndEventRepository
    {
        Task<List<NewAndEventDTO>?> readAll();
        Task<NewAndEventDTO?> readById(int id);
    }
}
