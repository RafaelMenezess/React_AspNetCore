using Microsoft.AspNetCore.Mvc;

namespace pro_atividade_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtividadeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "método Get";
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"método Get com id:{id}";
        }

        [HttpPost]
        public string Post()
        {
            return "método Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "método Put";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "método Delete";
        }

    }
}