using System;
using System.Threading.Tasks;
using pro_atividade_domain.Entities;
using pro_atividade_domain.Interfaces.Repositories;

namespace pro_atividade_data.Repositories
{
    public class AtividadeRepo : GeralRepo, IAtividadeRepo
    {
        public Task<Atividade[]> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Atividade> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Atividade> GetByTitleAsync(string titulo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SalvarMudancasAsync()
        {
            throw new NotImplementedException();
        }
    }
}