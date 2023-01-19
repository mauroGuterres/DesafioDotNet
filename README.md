# Instruções
1. Clonar o projeto em sua máquina local;
2. Certificar-se de que há uma instância de sql server instalada na máquina;
3 .Ir até a instância via Sql Server Management ou outro de sua preferência e criar o banco "Khipo";
4 .Ir até a pasta "Models" no projeto e rodar os scripts "create-procedure-getAllProduto.sql" e "create-procedure-getProdutoById.sql" para criar as procedured de get;
5. Ir até o web.config do projeto, alterar a connectionString para apontar para a sua instância;
6. Abrir o arquivo KhipoEntities.edmx e a partir dele gerar o script para a base de dados;
7. Rodar o script;
8 .Rodar o projeto;
9 .Testar os endpoints via swagger;




# Desafio .NET
Desafio de contratação Khipo. Realize um fork deste repositório e faça as etapas referentes a sua vaga. O intuito desse teste é ser algo simples, porém suficiente para validar a qualidade do seu código.

# Desafio 1

Utilizando o .Net Framework (https://docs.microsoft.com/pt-br/dotnet/framework/get-started/overview) crie uma ``API Rest``. Essa API deverá ser capaz de CRUD em um banco de dados de ``Produtos``. Utilizar procedure para os GETs com o banco de dados.

``GET /api/v1/products``
Retorna todos os produtos em lista

``GET /api/v1/products/:productId``
Retorna apenas o produto do productId

``POST /api/v1/products``
Salva o produto e retorna ele

``PUT /api/v1/products/:productId``
Modifica o produto e retorna o novo produto

``DELETE /api/v1/products/:productId``
Deleta o produto

Exemplo de produtos:
```
[
 {
  "createdAt": "2022-05-20T00:31:08.822Z",
  "name": "Incredible Plastic Pants",
  "price": "827.00",
  "brand": "Hauck - Johnson",
  "updatedAt": "2022-05-22T02:31:08.822Z",
  "id": "1"
 },
 {
  "createdAt": "2022-05-20T09:05:23.745Z",
  "name": "Electronic Wooden Tuna",
  "price": "765.00",
  "brand": "Johns - Farrell",
  "updatedAt": "2022-05-20T09:05:23.745Z",
  "id": "2"
 },
 {
  "createdAt": "2022-05-20T02:07:28.065Z",
  "name": "Awesome Steel Mouse",
  "price": "143.00",
  "brand": "Paucek, Kuvalis and Zieme",
  "updatedAt": "2022-05-23T22:35:23.745Z",
  "id": "3"
 },
 ]
```

Observações
1. É necessario utilizar ADO.Net (https://docs.microsoft.com/pt-br/dotnet/framework/data/adonet/)
2. É essencial que seja conectado em um banco de dados SQL Server.
