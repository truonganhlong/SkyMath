using AutoMapper;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using VissSoft.Core.Interfaces.IRepositories;
using VissSoft.Infrastracture.Data;
using VissSoft.Infrastracture.Repositories;

namespace VissSoft.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntroController : BaseController
    {
        private readonly IntroRepository _repository;
        public IntroController(VissSoftDbContext dbContext, IMapper mapper)
        {
            _repository = new IntroRepository(dbContext, mapper);
        }

        [HttpGet("readAll")]
        public async Task<IActionResult> ReadAll()
        {
            try
            {
                var data = await _repository.readAll();
                if (data == null)
                {
                    return CustomResult("Không tìm thấy dữ liệu!", HttpStatusCode.NotFound);
                }
                return CustomResult("Dữ liệu tải thành công!", data);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ReadById(int id)
        {
            try
            {
                var data = await _repository.readById(id);
                if (data == null)
                {
                    return CustomResult("Không tìm thấy dữ liệu!", HttpStatusCode.NotFound);
                }
                return CustomResult("Dữ liệu tải thành công!", data);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
