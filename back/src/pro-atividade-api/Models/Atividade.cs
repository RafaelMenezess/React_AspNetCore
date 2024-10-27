namespace pro_atividade_api.Models
{
    public class Atividade
    {
        public int id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Prioridade { get; set; }

        public Atividade()
        {

        }
    }
}