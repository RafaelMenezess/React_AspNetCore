import React from "react";
import TitlePage from "./../../components/TitlePage";
import { Button } from "react-bootstrap";
import { useHistory } from "react-router-dom";

export default function ClienteForm() {
  let history = useHistory();

  return (
    <>
      <TitlePage title="Cliente Detalhes">
        <Button variant="outline-secondary" onClick={() => history.goBack()}>
          <i className="fas fa-arrow-left me-2"></i>
          Voltar
        </Button>
      </TitlePage>
      <div></div>
    </>
  );
}
