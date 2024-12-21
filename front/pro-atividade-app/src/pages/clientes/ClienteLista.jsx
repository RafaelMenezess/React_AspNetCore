import React from "react";
import TitlePage from "../../components/TitlePage";
import InputGroupText from "react-bootstrap/esm/InputGroupText";
import { Form, InputGroup } from "react-bootstrap";

const clientes = [
  {
    id: 1,
    nome: "Microsoft",
    responsavel: "Otto",
    contato: 10665544,
    situacao: "Ativo",
  },
  {
    id: 2,
    nome: "Amazon",
    responsavel: "San",
    contato: 852369741,
    situacao: "Em Análise",
  },
  {
    id: 3,
    nome: "Google",
    responsavel: "Shirley",
    contato: 147852369,
    situacao: "Desativado",
  },
  {
    id: 4,
    nome: "Facebook",
    responsavel: "Charles",
    contato: 369852147,
    situacao: "Ativo",
  },
  {
    id: 5,
    nome: "Twitter",
    responsavel: "Jack",
    contato: 987654321,
    situacao: "Ativo",
  },
];

export default function ClienteLista() {
  return (
    <>
      <TitlePage title={"Cliente Lista"} />
      <InputGroup className="mt-3 mb-3">
        <InputGroup.Text>Buscar:</InputGroup.Text>
        <Form.Control
          aria-label="Default"
          aria-describedby="inputGroup-sizing-default"
        />
      </InputGroup>
      <table className="table table-striped table-hover">
        <thead className="table-dark mt-3">
          <tr>
            <th scope="col">#</th>
            <th scope="col">Nome</th>
            <th scope="col">Responsável</th>
            <th scope="col">Contato</th>
            <th scope="col">Situação</th>
            <th scope="col">Opções</th>
          </tr>
        </thead>
        <tbody>
          {clientes.map((cliente) => (
            <tr key={cliente.id}>
              <td>{cliente.id}</td>
              <td>{cliente.nome}</td>
              <td>{cliente.responsavel}</td>
              <td>{cliente.contato}</td>
              <td>{cliente.situacao}</td>
              <td>
                <div>
                  <button className="btn btn-sm btn-outline-primary me-2">
                    <i className="fas fa-user-edit me-2"></i>
                    Editar
                  </button>
                  <button className="btn btn-sm btn-outline-danger me-2">
                    <i className="fas fa-user-times me-2"></i>
                    Desativar
                  </button>
                </div>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}
