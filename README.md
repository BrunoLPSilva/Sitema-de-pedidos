# 📦 Sistema de Pedidos | Angular 17 + .NET 8 + SQL Server

Este projeto é uma aplicação full stack desenvolvida com **Angular 17** no front-end, **.NET 8 (ASP.NET Core Web API)** no back-end e banco de dados **SQL Server** utilizando **Entity Framework Core com Migrations**.

> Idealizado para demonstrar habilidades técnicas em desenvolvimento web moderno, seguindo boas práticas, arquitetura limpa e integração entre front e back-end.

======================================================================================================================================

                        [TECNOLOGIAS UTILIZADAS]

[FRONT-END]
- [Angular 17](https://angular.io/)
- TypeScript
- HTML5 / CSS3 / Bootstrap
- Consumo de API REST
- Formulário para criação de pedidos
- Tabela com listagem dos pedidos
- Filtro por status (Pendente, Processado)
- Botão para alterar o status de um pedido
- Feedback visual (toasts/alerts) para operações

*Entre na pasta do projeto
cd pedido-front

* Instale as dependências
npm install

* Execute a aplicação em modo de desenvolvimento
ng serve

======================================================================================================================================
[BACK-END]
- [.NET 8.0 (ASP.NET Core Web API)](https://learn.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core)
- Entity Framework Core 8
- Migrations para criação de banco
- Repositório + Service Pattern

* Banco de Dados
- SQL Server (via Migrations)
- Tabelas e relacionamentos gerados automaticamente com `dotnet ef`

* Configuração da String de Conexão
No arquivo appsettings.json, localizado em:

bash
Copiar
Editar
/src/project_product_orders.WebApi/appsettings.json
Altere a string de conexão para apontar para seu ambiente local:

json
Copiar
Editar
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=NomeDoBanco;User Id=seu_usuario;Password=sua_senha;TrustServerCertificate=True;"
}

======================================================================================================================================

* Estrutura do Projeto

/src/
├── project_product_orders.WebApi/         # Camada de API (aponta para Application, Domain, Infrastructure)
│   ├── Controllers/                       # Endpoints da aplicação
│   │   ├── PedidosController.cs
│   │   └── ProdutosController.cs
│   ├── appsettings.json                   # Configuração da conexão com SQL Server
│   ├── Program.cs                         # Ponto de entrada da API
│   └── project_product_orders.WebApi.http # Testes rápidos de requisições (opcional)
│
├── project_product_orders.Application/    # Lógica da aplicação (DTOs, services, interfaces)
│
├── project_product_orders.Domain/         # Entidades e regras de negócio
│
├── project_product_orders.Infrastructure/ # Repositórios e integração com EF Core e SQL Server
======================================================================================================================================

[DB]

* Criar nova migration
dotnet ef migrations add NomeDaMigration

* Atualizar banco com a migration
dotnet ef database update


{
  "id": "UUID (ou ID autoincrement)",
  "cliente": "João da Silva",
  "itens": [
    { "produto": "Teclado", "quantidade": 2, "precoUnitario": 150.00 },
    { "produto": "Mouse", "quantidade": 1, "precoUnitario": 100.00 }
  ],
  "total": 400.00,
  "status": "Pendente",
}

======================================================================================================================================

[Tecnologias e Ferramentas]
Tecnologia	Versão
Angular	17.x
TypeScript	5.x
.NET	8.0
SQL Server	2022+
Entity Framework	EF Core 8
Bootstrap	5.x
Visual Studio	2022+
VS Code	Última

👨[Autor]
Desenvolvido por Bruno Luiz
LinkedIn: https://www.linkedin.com/in/bruno-silva-a204b11a1/
GitHub: https://github.com/BrunoLPSilva/

======================================================================================================================================