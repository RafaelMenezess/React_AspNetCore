using System.Threading.Tasks;
using pro_atividade_domain.Entities;

namespace pro_atividade_domain.Interfaces.Services
{
    public interface IAtividadeService
    {
        Task<Atividade> AddAtividade(Atividade model);
        Task<Atividade> UpdateAtividade(Atividade model);
        Task<bool> DeleteAtividade(int id);
        Task<bool> ConcluirAtividade(Atividade model);
        Task<Atividade[]> GetAllAtividadesAsync();
        Task<Atividade> GetByIdAtividadeAsync(int id);
    }
}