using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pro_atividade_data.Context;
using pro_atividade_domain.Entities;
using pro_atividade_domain.Interfaces.Repositories;

namespace pro_atividade_data.Repositories
{
    public class AtividadeRepo : GeralRepo, IAtividadeRepo
    {
        public DataContext _context { get; }
        public AtividadeRepo(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Atividade> GetByIdAsync(int id)
        {
            IQueryable<Atividade> query = _context.Atividades;

            query = query.AsNoTracking()
                         .OrderBy(atv => atv.Id)
                         .Where(a => a.Id == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Atividade> GetByTitleAsync(string titulo)
        {
            IQueryable<Atividade> query = _context.Atividades;

            query = query.AsNoTracking()
                         .OrderBy(atv => atv.Id);

            return await query.FirstOrDefaultAsync(a => a.Titulo == titulo);
        }

        public async Task<Atividade[]> GetAllAsync()
        {
            IQueryable<Atividade> query = _context.Atividades;

            query = query.AsNoTracking()
                         .OrderBy(atv => atv.Id);

            return await query.ToArrayAsync();
        }
    }
}