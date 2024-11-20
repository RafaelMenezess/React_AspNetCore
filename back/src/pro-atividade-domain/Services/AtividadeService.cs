using System;
using System.Threading.Tasks;
using pro_atividade_domain.Entities;
using pro_atividade_domain.Interfaces.Repositories;
using pro_atividade_domain.Interfaces.Services;

namespace pro_atividade_domain.Services
{
    public class AtividadeService : IAtividadeService
    {
        public readonly IAtividadeRepo _atividadeRepo;
        public AtividadeService(IAtividadeRepo atividadeRepo)
        {
            _atividadeRepo = atividadeRepo;
        }
        public async Task<Atividade> AddAtividade(Atividade model)
        {
            if (await _atividadeRepo.GetByTitleAsync(model.Titulo) != null)
            {
                throw new Exception("Já existe uma atividade com esse título");
            }

            if (await _atividadeRepo.GetByIdAsync(model.Id) == null)
            {
                _atividadeRepo.Adicionar(model);
                if (await _atividadeRepo.SalvarMudancasAsync())
                    return model;
            }

            return null;
        }
        public async Task<Atividade> UpdateAtividade(Atividade model)
        {
            if (model.DataConclusao != null)
            {
                throw new Exception("Não pode alterar atividade já concluída.");
            }

            if (await _atividadeRepo.GetByIdAsync(model.Id) != null)
            {
                _atividadeRepo.Atualizar(model);
                if (await _atividadeRepo.SalvarMudancasAsync())
                    return model;
            }

            return null;
        }

        public async Task<bool> ConcluirAtividade(Atividade model)
        {
            if (model != null)
            {
                model.Concluir();
                _atividadeRepo.Atualizar(model);
                return await _atividadeRepo.SalvarMudancasAsync();
            }

            return false;
        }

        public async Task<bool> DeleteAtividade(int id)
        {
            var atv = await _atividadeRepo.GetByIdAsync(id);
            if (atv == null)
            {
                throw new Exception("Atividade que tentou deletar não existe");
            }

            _atividadeRepo.Deletar(atv);
            return await _atividadeRepo.SalvarMudancasAsync();
        }

        public async Task<Atividade> GetByIdAtividadeAsync(int id)
        {
            try
            {
                var atv = await _atividadeRepo.GetByIdAsync(id);
                return atv;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Atividade[]> GetAllAtividadesAsync()
        {
            try
            {
                var atividades = await _atividadeRepo.GetAllAsync();
                return atividades;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}