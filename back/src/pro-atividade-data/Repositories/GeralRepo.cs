using System.Threading.Tasks;
using pro_atividade_data.Context;
using pro_atividade_domain.Interfaces.Repositories;

namespace pro_atividade_data.Repositories
{
    public class GeralRepo : IGeralRepo
    {
        public readonly DataContext _context;
        public GeralRepo(DataContext context)
        {
            _context = context;
        }
        public void Adicionar<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Atualizar<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Deletar<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeletarVarias<T>(T[] entityArray) where T : class
        {
            _context.RemoveRange(entityArray);
        }

        public async Task<bool> SalvarMudancasAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}