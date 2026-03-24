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


-   **POST (Create):**
  <img width="1752" height="791" alt="image" src="https://github.com/user-attachments/assets/1bbd6426-dfb8-4c2b-941d-6987dcd9c98f" />


-   **GET (Read):**
  <img width="1752" height="791" alt="image" src="https://github.com/user-attachments/assets/44bcef47-73f5-46ec-9f2c-a164c974592a" />
  <img width="1752" height="791" alt="image" src="https://github.com/user-attachments/assets/9acd8c38-9386-4223-a0d2-c11ac503680a" />


-   **PUT (Update):**
  <img width="1752" height="791" alt="image" src="https://github.com/user-attachments/assets/ea900fd2-b491-4582-9edb-4e8366675430" />


-   **DELETE:**
  <img width="1752" height="791" alt="image" src="https://github.com/user-attachments/assets/130a8ff3-1b27-4e56-9793-ce9de4920c41" />



----------

## 🧪 Testes Unitários

O projeto conta com uma suíte de testes unitários utilizando o framework **xUnit** e o padrão AAA (Arrange, Act, Assert). Foram implementados 5 métodos de teste com a anotação `[Fact]`, validando todos os cenários do Controller usando um Banco de Dados em Memória para isolamento.

-   **Evidência da execução dos Testes:**

<img width="1289" height="104" alt="image" src="https://github.com/user-attachments/assets/46e2fdfb-26b8-423c-bf0b-537a170895ab" />

---
