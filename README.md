# API — Usuário / Empresa (Clean Architecture)

API REST em .NET 6 estruturada em **Clean Architecture** (4 camadas), com autenticação JWT, autorização por perfis/permissões, versionamento e separação clara entre Domain, Application e Infra.

![.NET](https://img.shields.io/badge/.NET-6.0-512BD4?logo=dotnet&logoColor=white)
![Clean Architecture](https://img.shields.io/badge/arch-Clean%20Architecture-0c7b93)
![JWT](https://img.shields.io/badge/auth-JWT-000000?logo=jsonwebtokens&logoColor=white)
![Swagger](https://img.shields.io/badge/docs-Swagger-85EA2D?logo=swagger&logoColor=black)

## Stack

- **.NET 6** · ASP.NET Core Web API
- **JWT Bearer** (`Microsoft.AspNetCore.Authentication.JwtBearer`)
- **FluentValidation** — validação de entrada
- **AutoMapper** — mapping Model ↔ DTO
- **Swagger / OpenAPI** (`Swashbuckle.AspNetCore`) com `GenerateDocumentationFile`
- **Entity Framework Core** — camada de persistência
- **Middleware customizado** de tratamento de erro e autenticação de cliente

## Arquitetura

```
API/
├── 0.1 - Presentation/
│   └── WMS.Sisdep.API/              Controllers, Program.cs, Startup, Swagger filters
├── 0.2 - Application/
│   ├── WMS.Sisdep.Application/      Interfaces + Services (regras de aplicação)
│   └── WMS.Sisdep.Application.Core/ DTOs + AutoMapper profiles
├── 0.3 - Domain/
│   ├── WMS.Sisdep.Domain/           Entidades + regras de domínio
│   └── WMS.Sisdep.Domain.Core/      Abstrações base (entity, value object)
└── 0.4 - Infra/
    ├── 4.1 - Data/                  Repositórios + EF Core DbContext
    ├── 4.2 - CrossCutting/          Injeção de dependência (IoC)
    ├── 4.3 - Middleware/            Pipeline de autenticação, erros
    ├── 4.4 - Integration/           Integrações externas
    └── 4.5 - OldData/               Compatibilidade com base legada
```

Regra de dependência: camadas externas dependem das internas; **Domain** não depende de ninguém.

## Módulos expostos

| Controller | Responsabilidade |
|---|---|
| `AutenticarController` | Login / geração de JWT |
| `AuthorizeClientController` | Autenticação de aplicação cliente (machine-to-machine) |
| `UsuarioController` | CRUD de usuários |
| `EmpresaController` | CRUD de empresas |
| `PerfilController` | Perfis de acesso |
| `PermissaoController` | Permissões granulares |
| `ConfigController` | Configurações de aplicação |
| `VersaoController` | Versionamento / metadata |

## Como rodar

```bash
# restaurar + build
dotnet restore API-Back.sln
dotnet build

# rodar a API (camada de apresentação)
cd "0.1 - Presentation/WMS.Sisdep.API"
dotnet run
```

Swagger disponível em `https://localhost:<porta>/swagger`.

## Status

Implementação de referência de Clean Architecture em .NET 6 para um domínio real (usuários, empresas, perfis, permissões) — base reutilizável para novas APIs corporativas.
