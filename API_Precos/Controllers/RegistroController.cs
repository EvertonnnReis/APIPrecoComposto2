using Microsoft.AspNetCore.Mvc;
using APIPrecoComposto2.Services;

namespace APIPrecoComposto2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : ControllerBase
    {
        private readonly IServices _services;

        public RegistroController(IConfiguration configuration,
            IServices services)
        {
            _services = services;
        }



        [HttpGet]
        public async Task<dynamic> ObterRegistros()
        {
            var registro = await _services.ObterRegistros("38A650FD-9176-4E85-AAA3-BC5ACA973EAC");

            // Retorna os registros como resposta JSON
            return new {registro};
        }
    }
}
