import { useEffect, useState } from "react";
import { Button, Modal } from "react-bootstrap";
import api from "../../api/atividade";
import TitlePage from "../../components/TitlePage";
import AtividadeLista from "./AtividadeLista";
import AtividadeForm from "./AtividadeForm";
import { IAtividade, Prioridade } from "../../model/atividade";

const atividadeInicial: IAtividade = {
  id: 0,
  titulo: "",
  prioridade: Prioridade.NaoDefinido,
  descricao: "",
};

const Atividade = () => {
  const [showAtividadeModal, setShowAtividadeModal] = useState(false);
  const [smshowConfirmModal, setSmshowConfirmModal] = useState(false);

  const [atividades, setAtividades] = useState<IAtividade[]>([]);
  const [atividade, setAtividade] = useState<IAtividade>(atividadeInicial);

  const handleAtividadeModal = () => setShowAtividadeModal(!showAtividadeModal);

  const handleConfirmModal = (id: number) => {
    if (id !== 0 && id !== undefined) {
      const atividade = atividades.filter((atividade) => atividade.id === id);
      setAtividade(atividade[0]);
    } else {
      setAtividade(atividadeInicial);
    }
    setSmshowConfirmModal(!smshowConfirmModal);
  };

  const pegaTodasAtividades = async () => {
    const response = await api.get("atividade");
    return response.data;
  };

  const novaAtividade = () => {
    setAtividade(atividadeInicial);
    handleAtividadeModal();
  };

  useEffect(() => {
    const getAtividades = async () => {
      const todasAtividades = await pegaTodasAtividades();
      if (todasAtividades) setAtividades(todasAtividades);
    };
    getAtividades();
  }, []);

  const addAtividade = async (ativ: IAtividade) => {
    handleAtividadeModal();

    const response = await api.post("atividade", ativ);

    setAtividades([...atividades, response.data]);
  };

  const deletarAtividade = async (id: number) => {
    handleConfirmModal(0);
    if (await api.delete(`Atividade/${id}`)) {
      const atividadesFiltradas = atividades.filter(
        (atividade) => atividade.id !== id
      );
      setAtividades([...atividadesFiltradas]);
    }
  };

  function cancelarAtividade() {
    setAtividade(atividadeInicial);
    handleAtividadeModal();
  }

  const atualizarAtividade = async (ativ: IAtividade) => {
    handleAtividadeModal();

    const response = await api.put(`Atividade/${ativ.id}`, ativ);
    const { id } = response.data;
    setAtividades(
      atividades.map((item) => (item.id === id ? response.data : item))
    );
    setAtividade(atividadeInicial);
  };

  function pegarAtividade(id: number) {
    const atividade = atividades.filter((atividade) => atividade.id === id);
    setAtividade(atividade[0]);
    handleAtividadeModal();
  }

  return (
    <>
      <TitlePage
        title={"Atividade " + (atividade.id !== 0 ? atividade.id : "")}
      >
        <Button variant="outline-secondary" onClick={novaAtividade}>
          <i className="fas fa-plus"></i>
        </Button>
      </TitlePage>

      <AtividadeLista
        atividades={atividades}
        handleConfirmModal={handleConfirmModal}
        pegarAtividade={pegarAtividade}
      />

      <Modal show={showAtividadeModal} onHide={handleAtividadeModal}>
        <Modal.Header closeButton>
          <Modal.Title>
            Atividade {atividade.id !== 0 ? atividade.id : ""}
          </Modal.Title>
        </Modal.Header>
        <Modal.Body>
          <AtividadeForm
            addAtividade={addAtividade}
            atualizarAtividade={atualizarAtividade}
            cancelarAtividade={cancelarAtividade}
            atividadeSelecionada={atividade}
          />
        </Modal.Body>
      </Modal>

      <Modal show={smshowConfirmModal} onHide={() => handleConfirmModal(0)}>
        <Modal.Header closeButton>
          <Modal.Title>
            Excluindo Atividade {atividade.id !== 0 ? atividade.id : ""}
          </Modal.Title>
        </Modal.Header>
        <Modal.Body>
          Tem certeza que deseja excluir a Atividade {atividade.id}
        </Modal.Body>
        <Modal.Footer className="d-flex justify-content-between">
          <button
            className="btn btn-outline-success me-2"
            onClick={() => deletarAtividade(atividade.id)}
          >
            <i className="fas fa-check me-2"></i>
            Sim
          </button>
          <button
            className="btn btn-danger me-2"
            onClick={() => handleConfirmModal(0)}
          >
            <i className="fas fa-times me-2"></i>
            Não
          </button>
        </Modal.Footer>
      </Modal>
    </>
  );
}

export default Atividade; 
