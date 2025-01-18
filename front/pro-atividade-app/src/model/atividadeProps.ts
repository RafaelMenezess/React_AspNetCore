import { atividade } from "./atividade";

export interface AtividadeListaProps{
    atividades: atividade[];
    pegarAtividade: (id: number) => void;
    handleConfirmModal: (id: number) => void;
  }

export interface AtividadeItemProps{
    ativ: atividade;
    pegarAtividade: (id: number) => void;
    handleConfirmModal: (id: number) => void;
  }
  