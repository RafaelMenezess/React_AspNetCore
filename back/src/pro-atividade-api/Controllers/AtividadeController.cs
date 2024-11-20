using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using pro_atividade_domain.Entities;
using pro_atividade_domain.Interfaces.Services;

namespace pro_atividade_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtividadeController : ControllerBase
    {
        public readonly IAtividadeService _atividadeService;
        public AtividadeController(IAtividadeService atividadeService)
        {
            _atividadeService = atividadeService;
        }

        [HttpGet]
        public IEnumerable<Atividade> Get()
        {
            return _context.Atividades;
        }

        [HttpGet("{id}")]
        public Atividade Get(int id)
        {
            return _context.Atividades.FirstOrDefault(atv => atv.Id == id); ;
        }

        [HttpPost]
        public Atividade Post(Atividade atv)
        {
            _context.Atividades.Add(atv);
            if (_context.SaveChanges() > 0)
            {
                return atv;
            }
            else
            {
                throw new Exception("Não foi possível adicionar a atividade");
            }
        }

        [HttpPut("{id}")]
        public Atividade Put(int id, Atividade atv)
        {
            if (atv.Id != id)
            {
                throw new Exception("Você está tentando atualizar a atividade errada.");
            }

            _context.Update(atv);
            if (_context.SaveChanges() > 0)
            {
                return _context.Atividades.FirstOrDefault(ativ => ativ.Id == id);
            }
            else
            {
                throw new Exception("Não foi possível adicionar a atividade");
            }
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var atv = _context.Atividades.FirstOrDefault(ativ => ativ.Id == id);
            if (atv == null)
            {
                throw new Exception("Ativade não encontrada");
            }

            _context.Remove(atv);

            return _context.SaveChanges() > 0;
        }
    }
}