# 🚀 Medical API - IA Generativa e Prontuários (.NET 8)

Esta é uma API RESTful construída em .NET 8 (C#) para gerenciar Prontuários Médicos, integrações com o Google Gemini (IA Generativa) e Telemetria IoT/IoB.

## 🛠 Pré-requisitos

1.  Instale o **.NET 8 SDK** na sua máquina.
2.  Um editor de código como **Visual Studio**, **Visual Studio Code** ou **Rider**.

## ⚙️ Como Configurar as Credenciais e Conexões

Na raiz do projeto (junto ao `Program.cs`), você precisará criar ou modificar o arquivo `appsettings.json` (ou `appsettings.Development.json` para rodar localmente). 

Adicione a estrutura abaixo para configurar o **JWT**, o **MongoDB** e o **Oracle**:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "Jwt": {
    "Issuer": "SuaEmpresaIssuer",
    "Audience": "SuaEmpresaAudience",
    "Key": "COLOQUE_UMA_CHAVE_MUITO_SECRETA_E_SEGURA_AQUI_COM_PELO_MENOS_32_CARACTERES!"
  },
  "ConnectionStrings": {
    "MongoDb": "mongodb://usuario:senha@localhost:27017/SeuBancoMedico",
    "OracleDb": "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=seu-host)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=seu_servico)));User Id=usuario;Password=senha;"
  },
  "GeminiAI": {
    "ApiKey": "SUA_API_KEY_DO_GOOGLE_GEMINI"
  }
}
```

## ▶️ Como Rodar o Projeto

1.  Abra o terminal na pasta do projeto (onde está o arquivo `MedicalApi.csproj`).
2.  Restaure os pacotes NuGet executando:
    ```bash
    dotnet restore
    ```
3.  Execute a API executando:
    ```bash
    dotnet run
    ```
4.  O terminal mostrará a URL onde a API está rodando (ex: `https://localhost:7123`).
5.  Acesse o **Swagger** para testar os endpoints através do navegador, adicionando `/swagger` no final da URL:
    👉 `https://localhost:7123/swagger`

## 📚 Endpoints Implementados (CRUD Completo)

*   **/api/v1/medical-records**: GET (Todos), GET (Por ID), POST (Criar), PUT (Atualizar) e DELETE (Remover).
*   **/api/v1/ai/insights**: POST (Gerar Insight), GET (Por ID), PUT (Atualizar) e DELETE (Remover).
*   **/api/v1/ai/contexts**: POST (Gerar Contexto).
*   **/api/v1/ai/audit**: GET (Histórico de Auditoria).
*   **/api/v1/telemetry/events**: GET (Todos), GET (Por ID), POST (Inserir), PUT (Atualizar) e DELETE (Remover).

> **Atenção:** Quase todos os endpoints exigem autenticação via token JWT (Bearer Token). No Swagger, você precisará gerar um token e adicioná-lo no botão "Authorize".
