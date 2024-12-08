import "./App.css";
import Atividade from "./pages/atividades/Atividade";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";

export default function App() {
  return (
    <>
      <Router>
        <Route path="/atividade" component={Atividade} />
        <Route path="/clientes" component={Cliente} />
        <Route path="/home" component={Home} />
      </Router>
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
