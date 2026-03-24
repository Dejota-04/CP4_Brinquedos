# API de Gestão de Brinquedos - CP4 .NET

API Restful desenvolvida em C# com .NET 8, utilizando Entity Framework Core e banco de dados MySQL para o Checkpoint 4 da disciplina de Advanced Business Development.

## 🚀 Tecnologias Utilizadas
* .NET 8.0
* Entity Framework Core (Pomelo MySQL)
* xUnit (Testes Unitários com banco em memória)
* Swagger / OpenAPI

## 📦 Estrutura do Banco de Dados
A API gerencia a tabela `TDS_TB_Brinquedos` com as seguintes colunas:
* `Id_brinquedo` (PK, int)
* `Nome_brinquedo` (string)
* `Tipo_brinquedo` (string)
* `Classificacao` (string)
* `Tamanho` (string)
* `Preco` (decimal)

## 🛠️ Endpoints e Testes de CRUD
Abaixo estão as evidências de teste do CRUD completo realizado via Swagger/Postman.

### Exemplo de JSON de Cadastro (POST)
```json
{
  "nome_brinquedo": "Lego Star Wars - Millennium Falcon",
  "tipo_brinquedo": "Blocos de Montar",
  "classificacao": "+9 anos",
  "tamanho": "Médio",
  "preco": 850.50
}

```

## Evidências Visuais (Prints)

_(Coloque aqui os prints exigidos pelo professor mostrando o teste no Swagger ou Postman/Insomnia)_

-   **POST (Create):**

-   **GET (Read):**

-   **PUT (Update):**

-   **DELETE:**


----------

## 🧪 Testes Unitários

O projeto conta com uma suíte de testes unitários utilizando o framework **xUnit** e o padrão AAA (Arrange, Act, Assert). Foram implementados 5 métodos de teste com a anotação `[Fact]`, validando todos os cenários do Controller usando um Banco de Dados em Memória para isolamento.

-   **Evidência da execução dos Testes:**




---
