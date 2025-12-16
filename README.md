[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
![.NET Core](https://img.shields.io/badge/.NET-512BD4?style=flat&logo=dotnet&logoColor=white)
![React](https://img.shields.io/badge/React-20232A?style=flat&logo=react&logoColor=61DAFB)
![TypeScript](https://img.shields.io/badge/TypeScript-007ACC?style=flat&logo=typescript&logoColor=white)
![Material UI](https://img.shields.io/badge/MUI-%230081CB.svg?style=flat&logo=mui&logoColor=white)
![SQLite](https://img.shields.io/badge/sqlite-%2307405e.svg?style=flat&logo=sqlite&logoColor=white)
![Docker](https://img.shields.io/badge/docker-2496ED?style=flat&logo=docker&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=flat&logo=visual-studio&logoColor=white)
![Git](https://img.shields.io/badge/GIT-F05032?style=flat&logo=git&logoColor=white)


# 💰 Expense Control

Sistema completo de Gestão Financeira Pessoal desenvolvido como desafio técnico Full-Stack da empresa Maxiprod. O projeto permite gerenciar pessoas, categorias financeiras e lançamentos (receitas e despesas), com validações de regras de negócio no Back-end.

## 🚀 Tecnologias Utilizadas

### Back-end
- **.NET 9** (C#)
- **Entity Framework Core** (ORM)
- **SQLite** (Banco de Dados)
- **Swagger** (Documentação da API)
- **Arquitetura em Camadas** (API, Application, Domain, Infrastructure)

### Front-end
- **React** (Vite)
- **TypeScript**
- **Material UI (MUI)** (Interface e Componentes)
- **Axios** (Integração com API)
- **React Router DOM** (Navegação)
- **React Hook Form** (Formulários)

---

## ⚙️ Funcionalidades

- **👥 Gestão de Pessoas:** Cadastro de membros da família com nome e idade.
- **🏷️ Gestão de Categorias:** Definição de tipos de lançamento (Receita, Despesa ou Ambos).
- **💸 Transações:** Registro de entradas e saídas financeiras.
- **🚫 Regras de Negócio:**
  - **Proteção para Menores:** O sistema impede que pessoas menores de 18 anos registrem transações do tipo **"Receita"**. Apenas "Despesas" são permitidas.
  - **Coerência de Categoria:** Não é permitido lançar uma Despesa usando uma Categoria exclusiva de Receita (e vice-versa).
- **📊 Dashboard:** Tela inicial com resumo visual das funcionalidades.

---

## 🔧 Como Rodar o Projeto

### Pré-requisitos
- [.NET 9 SDK](https://dotnet.microsoft.com/download) instalado.
- [Node.js](https://nodejs.org/) instalado.

### 1. Rodando o Back-end (API)

1. Navegue até a pasta da API (onde está o arquivo `.csproj` ou a Solução):
   ```bash
   cd ExpenseControl.API


## ✨ O FrontEnd (React) do projeto se encontra no link:

[https://github.com/marcelogmoura/desafioExpenseControl-UI](https://github.com/marcelogmoura/desafioExpenseControl-UI)


---

## 🏗️ Arquitetura do Projeto

A solução foi estruturada utilizando o padrão **Onion Architecture / Clean Architecture**:

1.  **Domain**: O núcleo do sistema. Contém as Entidades (`Pessoa`, `Categoria`), Interfaces (`IRepository`) e Regras de Negócio Puras (``). 
2.  **Application**: Camada de orquestração. Contém os DTOs (Data Transfer Objects) e Services que traduzem os dados externos para o domínio.
3.  **Infra**: Implementação técnica. Contém o `DbContext`, Mapeamentos do EF Core e Repositórios concretos.
4.  **API**: Ponto de entrada. Controllers enxutos que apenas recebem requisições e devolvem respostas HTTP.

---


### ✅ Funcionalidades Implementadas


## 📚 Exemplos de requisições e respostas

Cadastro de Pessoa

![Cadastro de Pessoa](https://i.postimg.cc/1XdgmzJz/1-cadastro-Pessoa.jpg)

Listagem de Pessoas

![Listagem de Pessoas](https://i.postimg.cc/1XdgmzJn/2-lista-Pessoas.jpg)


Cadastro de Categoria

![Cadastro de Categoria](https://i.postimg.cc/WzyDN4Xd/3-cadastro-Categoria.jpg)

Listagem de Categorias

![Listagem de Categorias](https://i.postimg.cc/7hRCHLm2/4-lista-Categorias.jpg)


Cadastro de Transação

![Cadastro de Transação](https://i.postimg.cc/ZnQ9bqVy/5-cadastro-Transacao.jpg)

Listagem de Transações

![Listagem de Transações](https://i.postimg.cc/QCzB8M05/6-lista-Transacoes.jpg)


Tratamento de erro (menor de idade)

![Tratamento de erro](https://i.postimg.cc/cCzKxJXf/7-erro-Menor18.jpg)

Exclusão de Pessoa

![Exclusão de Pessoa](https://i.postimg.cc/C52ZhKmj/8-exclusao-Pessoa.jpg)


Autenticação JWT

![Autenticação JWT](https://i.postimg.cc/mkncLr8C/9-autenticado-Token.jpg)

Documentação

![Documentação](https://i.postimg.cc/vTK1Ym3t/9-sw-agger.jpg)


Home

![Home](https://i.postimg.cc/mkncLr8N/10-home.jpg)




👨‍💻 **Autor:** Marcelo Moura 

📧 **Email:** [mgmoura@gmail.com](mailto:mgmoura@gmail.com)   
📧 **Email:** [admin@allriders.com.br](mailto:admin@allriders.com.br)   
🐱 **GitHub:** [github.com/marcelogmoura](https://github.com/marcelogmoura)   
🔗 **LinkedIn:** [linkedin.com/in/marcelogmoura](https://www.linkedin.com/in/marcelogmoura/)   
