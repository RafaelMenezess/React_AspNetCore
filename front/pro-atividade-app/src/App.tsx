import "./App.css";
import Atividades from "./pages/atividades/Atividades";
import { Routes, Route } from "react-router-dom";
import Cliente from "./pages/clientes/Cliente";
import Dashboard from "./pages/dashboard/Dashboard";
import ClienteForm from "./pages/clientes/ClienteForm";
import PageNotFound from "./pages/PageNotFound";

const  App = () => {
  return (
    <Routes>
      <Route path="/" element={<Dashboard />} />
      <Route path="/atividade/*" element={<Atividades />} />
      <Route path="/atividade/:id/cliente" element={<Atividades />} />
      <Route path="/cliente/*" element={<Cliente />} />
      <Route path="/cliente/:id/atividade" element={<Cliente />} />
      <Route path="/cliente/detalhe/" element={<ClienteForm />} />
      <Route path="/cliente/detalhe/:id" element={<ClienteForm />} />
      <Route element={<PageNotFound />} />
    </Routes> 
  );
}

export default App;
