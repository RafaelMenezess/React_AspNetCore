using System.Threading.Tasks;
using pro_atividade_domain.Entities;

namespace pro_atividade_domain.Interfaces.Repositories
{
    public interface IAtividadeRepo
    {
        Task<Atividade[]> GetAllAsync();
        Task<Atividade> GetByIdAsync();
        Task<Atividade> GetByTitleAsync();
    }
}