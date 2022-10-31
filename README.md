# Projeto API CRUD - DIO Bootcamp Pottencial Developer.

## Tecnologias utilizadas na criação do projeto: 
 - Framework - .NET Core 6;
 - ORM - Entity Framework Core;
 - Banco de dados - SQL Server.
 - Swagger para teste da API.
 
## Funcionalidades do CRUD:
- Criação de contatos com os campos: Nome, Telefone e Status;
- Listagem de contato com por ID;
- Listagem de contatos por nome;
- Atualização de contatos;
- Deleção de contatos.

## Recurso necessários para rodar a API no visual studio code:

- Se não tiver o entity framework instalado na sua máquina, instalar via comando: 
    - dotnet tool install --global dotnet-ef
    
- Instalar no projeto via terminal os pacotes do entity framework, comandos abaixo: 
    - dotnet add package Microsoft.EntityFrameworkCore.Design
    - dotnet add package Microsoft.EntityFrameworkCore.SqlServer 
    > *Caso queira utilizar outro banco de dados, instalar o pacote do banco desejado*.
    
- No arquivo appsettings.Development.json inserir a configuração do seu banco de dados em "ConnetionStrings"

- Rodar a migration para criação do banco de dados com o comando: 
    - dotnet-ef database update.
