using System.Threading.Tasks;
using pro_atividade_domain.Entities;

namespace pro_atividade_domain.Interfaces.Repositories
{
    public interface IAtividadeRepo : IGeralRepo
    {
        Task<Atividade[]> GetAllAsync();
        Task<Atividade> GetByIdAsync(int id);
        Task<Atividade> GetByTitleAsync(string titulo);
    }
}