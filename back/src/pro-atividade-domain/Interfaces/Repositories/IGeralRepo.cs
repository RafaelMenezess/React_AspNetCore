using System.Threading.Tasks;

namespace pro_atividade_domain.Interfaces.Repositories
{
    public interface IGeralRepo
    {
        void Adicionar<T>(T entity) where T : class;
        void Atualizar<T>(T entity) where T : class;
        void Deletar<T>(T entity) where T : class;
        void DeletarVarias<T>(T[] entity) where T : class;
        Task<bool> SalvarMudancasAsync();
    }
}