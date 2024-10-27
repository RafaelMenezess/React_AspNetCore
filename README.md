
# API RESTful com ASP.NET Core e Frontend em React

Este projeto é uma aplicação full-stack que integra uma API RESTful desenvolvida com ASP.NET Core e uma aplicação frontend em React. A API segue as melhores práticas de desenvolvimento RESTful e busca alcançar o nível 3 de maturidade em REST, implementando recursos como segurança, validação, HATEOAS e versionamento.

## Objetivo
Este projeto visa criar uma API RESTful robusta, estruturada em camadas para facilitar a organização do código e a comunicação entre o backend e o frontend, permitindo uma fácil escalabilidade e manutenção. O projeto utiliza o Entity Framework Core para manipulação de dados, e o Visual Studio Code como IDE principal.

## Pré-requisitos
Para executar este projeto, é recomendável que você tenha conhecimentos básicos em:
- **C#**
- **HTML, CSS e JavaScript**
- **SQL**

## Funcionalidades
- **ASP.NET Core 6**: Criação da API utilizando o framework .NET Core.
- **React**: Desenvolvimento de uma interface de usuário dinâmica e interativa.
- **RESTful API**: Estruturação seguindo os padrões RESTful.
- **Entity Framework Core 5**: Integração com banco de dados relacional.
- **Comunicação Frontend e Backend**: Implementação de comunicação eficiente e segura entre cliente e servidor.
- **HATEOAS e Versionamento**: Adoção de HATEOAS para navegabilidade e versionamento para manter compatibilidade.

## Tecnologias Utilizadas
- **Backend**: ASP.NET Core, Entity Framework Core
- **Frontend**: React
- **Banco de Dados**: SQL (compatível com SQL Server, PostgreSQL, entre outros)
- **IDE**: Visual Studio Code

## Estrutura do Projeto
O projeto é estruturado em camadas para facilitar a separação de responsabilidades:

- **Camada de Apresentação (Frontend)**: Implementada em React para interagir com a API e fornecer a interface ao usuário.
- **Camada de Aplicação**: Lida com regras de negócio e lógica de aplicação no ASP.NET Core.
- **Camada de Dados**: Usando Entity Framework Core para gerenciar a persistência dos dados no banco de dados.

## Instalação

### 1. Clonar o repositório
```bash
git clone https://github.com/RafaelMenezess/React_AspNetCore.git
```

### 2. Configuração do Backend
1. Navegue até a pasta do backend:
   ```bash
   cd back
   cd src
   cd pro-atividade-api
   ```
2. Restaure as dependências:
   ```bash
   dotnet restore
   ```
3. Configure o banco de dados e atualize as migrações:
   ```bash
   dotnet ef database update
   ```
4. Inicie a aplicação:
   ```bash
   dotnet run
   ```

### 3. Configuração do Frontend
1. Navegue até a pasta do frontend:
   ```bash
   cd front
   cd pro-atividade-app
   ```
2. Instale as dependências:
   ```bash
   npm install
   ```
3. Inicie o servidor de desenvolvimento:
   ```bash
   npm start
   ```

## Uso
Acesse a interface do frontend em `http://localhost:3000` e a documentação da API gerada pelo Swagger em `http://localhost:5000/swagger`.

## Contribuição
Para contribuir com este projeto, faça um fork do repositório e crie uma nova branch para suas modificações. Envie um pull request com suas melhorias.

## Licença
Este projeto está sob a licença MIT.
