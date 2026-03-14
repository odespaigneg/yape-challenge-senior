# Yape Senior Engineer Challenge

> **REST API built with .NET 8 applying Hexagonal Architecture (Ports & Adapters)**  
> Developed as a technical assessment for a Senior Software Engineer position.

---

## Overview

This project implements a backend REST API following **Hexagonal Architecture** principles, achieving strict separation between the business domain and infrastructure concerns. The design ensures the core logic is fully testable in isolation and decoupled from frameworks, databases, or external services.

---

## Architecture

```
yape-challenge-senior/
├── Adapters/        # Inbound & outbound adapters (controllers, infrastructure implementations)
├── Ports/           # Interfaces defining contracts between layers (inbound & outbound ports)
├── Services/        # Application/domain services — core business logic
├── Models/          # Domain entities and value objects
├── Tests/           # Unit and integration tests (xUnit)
├── Vendors/         # Third-party or vendor-specific configurations
├── Program.cs       # Application entry point & DI container configuration
└── appsettings.json # Application configuration
```

### Hexagonal Architecture — Layer Responsibilities

```
┌─────────────────────────────────────────────────┐
│                  ADAPTERS (outer)                │
│   HTTP Controllers  │  DB Repos  │  Ext Services │
└────────────┬────────┴─────┬──────┴──────┬────────┘
             │  Inbound     │             │ Outbound
             ▼  Port        │             ▼ Port
┌────────────────────────── │ ────────────────────┐
│           DOMAIN CORE (inner)                    │
│     Services  ◄───────────┘                      │
│     Models                                       │
│     Ports (interfaces)                           │
└─────────────────────────────────────────────────┘
```

The domain core **has zero dependencies** on external frameworks or infrastructure. All dependencies point inward.

---

## Tech Stack

| Layer | Technology |
|---|---|
| Language | C# |
| Framework | .NET 8 |
| Architecture | Hexagonal Architecture (Ports & Adapters) |
| Testing | xUnit |
| API Testing | .http file (VS / VS Code REST Client) |
| Configuration | appsettings.json / appsettings.Development.json |

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022+ or VS Code with C# extension

### Run locally

```bash
# Clone the repository
git clone https://github.com/odespaigneg/yape-challenge-senior.git
cd yape-challenge-senior

# Restore dependencies
dotnet restore

# Run the API
dotnet run
```

The API will be available at `https://localhost:5001` (or the port shown in the console).

### Run tests

```bash
dotnet test
```

Tests are located in the `Tests/` folder and cover core business logic in isolation from infrastructure.

---

## API Endpoints

You can test the API endpoints using the included `.http` file (`yape-challenge-senior.http`) with Visual Studio's HTTP client or the [REST Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client) VS Code extension.

---

## Design Decisions

**Why Hexagonal Architecture?**

- **Testability**: Business logic is fully testable without spinning up HTTP, databases, or any infrastructure
- **Maintainability**: Changes to infrastructure (e.g. swapping a database, changing an HTTP client) don't ripple into the domain
- **Clarity**: Each layer has a single, explicit responsibility — adapters translate, ports define contracts, services execute logic
- **Scalability**: New inbound adapters (e.g. a gRPC interface, a message consumer) can be added without touching existing code

This is the same architecture pattern applied professionally at **Arkano** for .NET 4.8 → .NET 8 enterprise migrations.

---

## Code Analysis

A full technical code analysis document is included in the repository: [`analisis codigo.docx`](./analisis%20codigo.docx)

---

## Author

**Oglys Despaigne Garbey** — Senior Software Engineer  
[LinkedIn](https://www.linkedin.com/in/oglysdespaigne-garbey-a26322120/) · [GitHub](https://github.com/odespaigneg)
