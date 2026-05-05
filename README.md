# NerdStore 🧠🛒

Projeto de estudo focado em **Domain-Driven Design (DDD)** utilizando **.NET 10**.

O objetivo é construir uma arquitetura sólida, escalável e bem organizada, separando responsabilidades por **Bounded Contexts** e aplicando boas práticas como **SOLID**, **Clean Architecture** e **separação de domínios**.

---

## 🧱 Arquitetura

O projeto segue princípios de DDD com divisão clara entre domínios:

### 🔵 Domínios Principais (Core Domains)

São o coração do negócio.

- **Catálogo**
  - Responsável por produtos
- **Vendas**
  - Responsável por pedidos
  - Consome produtos do catálogo

---

### 🟡 Domínios Auxiliares (Supporting Domains)

- **Cadastro**
  - Responsável por clientes
- **Fiscal**
  - Responsável por regras fiscais envolvendo pedidos e produtos

---

### 🟢 Domínio Genérico (Generic Domain)

- **Pagamento**
  - Pode ser compartilhado entre múltiplos contextos
  - Não contém regra crítica de negócio principal

---

### ⚫ Núcleo (Core / Shared Kernel)

Contém abstrações reutilizáveis:

- Entidades base
- Value Objects base
- Interfaces
- Notificações
- Handlers
- Eventos de domínio

---

## 📁 Estrutura de Pastas

```bash
src/
  NerdStore.sln

  /BuildingBlocks
    /Core
      Entities/
      ValueObjects/
      Interfaces/
      Notifications/
      Events/

  /Modules

    /Catalogo
      Domain/
      Application/
      Infra/

    /Vendas
      Domain/
      Application/
      Infra/

    /Cadastro
      Domain/
      Application/
      Infra/

    /Pagamento
      Domain/
      Application/
      Infra/

    /Fiscal
      Domain/
      Application/
      Infra/

  /API
    Controllers/
    Config/
```

---

## 🧠 Conceitos Aplicados

- Domain-Driven Design (DDD)
- Bounded Contexts
- Aggregates
- Value Objects
- Domain Events
- Repository Pattern
- Unit of Work
- CQRS (quando aplicável)
- Clean Code
- SOLID

---

## 🔐 Responsabilidades por Domínio

| Domínio   | Tipo      | Responsabilidade            |
| --------- | --------- | --------------------------- |
| Cadastro  | Auxiliar  | Gerenciamento de clientes   |
| Catálogo  | Principal | Gerenciamento de produtos   |
| Vendas    | Principal | Processamento de pedidos    |
| Pagamento | Genérico  | Processamento de pagamentos |
| Fiscal    | Auxiliar  | Regras fiscais              |
| Core      | Núcleo    | Base compartilhada          |

---

## 🚀 Como rodar o projeto

### Pré-requisitos

- .NET 10 SDK
- IDE (Rider, VS Code ou Visual Studio)

### Executar

```bash
dotnet restore
dotnet build
dotnet run --project src/API
```

---

## 🧪 Testes

```bash
dotnet test
```

---

## 📌 Objetivo do Projeto

Este projeto não é apenas funcional, mas sim um laboratório para:

- Evolução em arquitetura
- Prática de DDD real
- Organização de código em nível profissional
- Preparação para sistemas complexos

---

## ⚠️ Observações

- Estrutura pode evoluir conforme o domínio cresce
- Integrações entre contextos devem ser desacopladas
- Evitar dependência direta entre domínios

---

## 👨‍💻 Autor

Projeto de estudo para evolução em arquitetura de software.
