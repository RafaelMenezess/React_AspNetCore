export interface atividade{
    id: number;
    prioridade: string;
    titulo: string;
    descricao: string;
  }

export interface AtividadeListaProps{
    atividades: atividade[];
    pegarAtividade: (id: number) => void;
    handleConfirmModal: (id: number) => void;
  }
  