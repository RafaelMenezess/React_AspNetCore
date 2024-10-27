using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpPost]
        public string Post()
        {
            return "método Post";
        }

        [HttpPut]
        public string Put()
        {
            return "método Put";
        }

        [HttpDelete]
        public string Delete()
        {
            return "método Delete";
        }

    }
}