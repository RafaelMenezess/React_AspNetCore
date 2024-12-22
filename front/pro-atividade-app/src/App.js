import "./App.css";
import Atividades from "./pages/atividades/Atividades";
import { Switch, Route } from "react-router-dom";
import Cliente from "./pages/clientes/Cliente";
import Dashboard from "./pages/dashboard/Dashboard";
import ClienteForm from "./pages/clientes/ClienteForm";
import PageNotFound from "./pages/PageNotFound";

export default function App() {
  return (
    <Switch>
      <Route path="/" exact component={Dashboard} />
      <Route path="/atividade/lista" component={Atividades} />
      <Route path="/cliente/lista" component={Cliente} />
      <Route path="/cliente/detalhe/:id?" component={ClienteForm} />
      <Route component={PageNotFound} />
    </Switch>
  );
}
