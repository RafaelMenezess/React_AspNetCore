import "./App.css";
import Atividades from "./pages/atividades/Atividades";
import { Switch, Route } from "react-router-dom";
import Cliente from "./pages/clientes/Cliente";
import Dashboard from "./pages/dashboard/Dashboard";

export default function App() {
  return (
    <Switch>
      <Route path="/" exact component={Dashboard} />
      <Route path="/atividades" component={Atividades} />
      <Route path="/clientes" component={Cliente} />
    </Switch>
  );
}
