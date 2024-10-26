import "./App.css";
import { useEffect, useState } from "react";
import AtividadeForm from "./components/AtividadeForm";
import AtividadeLista from "./components/AtividadeLista";

let initialState = [
  {
    id: 1,
    prioridade: "1",
    titulo: "titulo",
    descricao: "Primeira Atividade",
  },
  {
    id: 2,
    prioridade: "2",
    titulo: "titulo",
    descricao: "Segunda Atividade",
  },
  {
    id: 3,
    prioridade: "3",
    titulo: "titulo",
    descricao: "Terceira Atividade",
  },
];

function App() {
  const [index, setIndex] = useState(0);
  const [atividades, setAtividades] = useState(initialState);
  const [atividade, setAtividade] = useState({});

  useEffect(() => {
    atividades.length <= 0
      ? setIndex(1)
      : setIndex(
          Math.max.apply(
            Math,
            atividades.map((item) => item.id)
          ) + 1
        );
  }, [atividades]);

  function addAtividade(ativ) {
    setAtividades([
      ...atividades,
      {
        ...ativ,
        id: index,
      },
    ]);
  }

  function deletarAtividade(id) {
    const atividadesFiltradas = atividades.filter(
      (atividade) => atividade.id !== id
    );
    setAtividades([...atividadesFiltradas]);
  }

  function cancelarAtividade() {
    setAtividade({ id: 0 });
  }

  function atualizarAtividade(ativ) {
    setAtividades(
      atividades.map((item) => (item.id === ativ.id ? ativ : item))
    );
    setAtividade({ id: 0 });
  }

  function pegarAtividade(id) {
    const atividade = atividades.filter((atividade) => atividade.id === id);
    setAtividade(atividade[0]);
  }

  return (
    <>
      <AtividadeForm
        addAtividade={addAtividade}
        atualizarAtividade={atualizarAtividade}
        cancelarAtividade={cancelarAtividade}
        atividadeSelecionada={atividade}
        atividades={atividades}
      />
      <AtividadeLista
        atividades={atividades}
        deletarAtividade={deletarAtividade}
        pegarAtividade={pegarAtividade}
      />
    </>
  );
}

export default App;
