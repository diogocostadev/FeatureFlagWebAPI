# FeatureFlagWebAPI

Este projeto é um exemplo prático de uma aplicação Web API REST utilizando Feature Flags para habilitar ou desabilitar funcionalidades de forma dinâmica.

## Tecnologias Utilizadas
- .NET 9
- ASP.NET Core
- Injeção de Dependência

## Como Configurar
1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/FeatureFlagWebAPI.git
   cd FeatureFlagWebAPI

	2.	Restaure os pacotes NuGet:

dotnet restore


	3.	Execute o projeto:

dotnet run



Testando a API
•	GET /api/teste/ativa: Testa a funcionalidade habilitada.
•	GET /api/teste/inativa: Testa a funcionalidade desabilitada.

Configurando Feature Flags

As Feature Flags estão configuradas no arquivo appsettings.json:

{
"FeatureFlags": {
"FuncionalidadeAtiva": true,
"FuncionalidadeInativa": false
}
}

Basta editar este arquivo para alterar o estado das funcionalidades.

Este é um exemplo simples e pode ser expandido para projetos mais complexos!

---

Se precisar de ajuda para adicionar mais funcionalidades ou configurar o ambiente, estou à disposição!