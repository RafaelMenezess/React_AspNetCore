import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import "bootstrap/dist/css/bootstrap.min.css";
import App from "./App";
import Menu from "./components/Menu";
import "bootswatch/dist/cosmo/bootstrap.min.css";
import { BrowserRouter as Router } from "react-router-dom";

const container = document.getElementById("root");

if (!container) {
  throw new Error("Root container missing in index.html");
}

const root = ReactDOM.createRoot(container);
root.render(
  <Router>
    <Menu />
    <div className="container">
      <App />
    </div>
  </Router>
);
