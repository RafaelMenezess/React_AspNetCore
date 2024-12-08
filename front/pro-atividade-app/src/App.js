import "./App.css";
import Atividades from "./pages/atividades/Atividades";
import { Switch, Route } from "react-router-dom";

export default function App() {
  return (
    <>
      <Route path="/atividades" component={Atividades} />
      <Route path="/clientes" component={Cliente} />
      <Route path="/home" component={Home} />
    </>
  );
}

const Cliente = () => (
  <div>
    <h1>Cliente</h1>
    <hr />
  </div>
);

const Home = () => (
  <div>
    <h1>Home</h1>
    <hr />
  </div>
);
