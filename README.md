## Sobre o Projeto

Esta **API** , desenvolvida utilizando **.NET 8** , adota os princípios do **Domain-Driven Design (DDD)** para oferecer uma solução estruturada e eficaz no gerenciamento de despesas pessoais. O objetivo principal é permitir que os usuários registrem suas despesas, detalhando informações como título, dados e hora, descrição, valor e tipo de pagamento, com os dados armazenados de forma segura em um banco de dados **MySQL** .

A arquitetura da API baseia-se em **REST** , utilizando métodos **HTTP** padrão para uma comunicação eficiente e simplificada. Além disso, é complementado por uma documentação **Swagger** , que fornece uma interface gráfica interativa para que os desenvolvedores possam explorar e testar os endpoints de maneira fácil.

Dentre os pacotes **NuGet** usados, o **AutoMapper** é o responsável pelo mapeamento entre objetos de domínio e requisição/resposta, diminuindo a necessidade de código repetitivo e manual. O **FluentAssertions** é utilizado em testes de unidade para tornar as verificações mais legíveis, ajudando a escrever testes claros e compreensíveis. Para as validações, o **FluentValidation** é usado para implementar regras de validação de forma simples e intuitiva nas classes de requisições, mantendo o código limpo e fácil de manter. Por fim, o **EntityFramework** atua como um ORM (Object-Relational Mapper) que simplifica as interações com o banco de dados, permitindo o uso de objetos .NET para manipular dados diretamente, sem a necessidade de lidar com consultas SQL.


### Construido com

![.Net] ![MySql] ![Windowns] ![LinkedIn] ![Swagger]



### Requisitos
- Visual Studio versão 2022+ ou Visual Studio Code
- Windows 10+ ou Linux/MacOS com [.NET SDK](https://dotnet.microsoft.com/pt-br/download) instalado 
- Servidor MySQL

### Instalação
1. Clonar o Repositório:

```sh
git clone https://github.com/paulo-demetrio/Expense_Api.git
```
2. Preencha as informações no arquivo `appsettings.Development.json.`

3.Executar a API





[.Net]: https://img.shields.io/badge/.NET-512BD4.svg?style=for-the-badge&logo=dotnet&logoColor=white
[MySql]: https://img.shields.io/badge/MySQL-4479A1?logo=mysql&logoColor=fff&style=for-the-badge
[Windowns]: https://img.shields.io/badge/Windows-blue?style=for-the-badge&logoColor=white&link=www.linkedin.com%2Fin%2F%20paulo-demetrio
[LinkedIn]: https://img.shields.io/badge/LinkedIn-blue?style=for-the-badge

[Swagger]: https://img.shields.io/badge/Swagger-85EA2D?logo=swagger&logoColor=000&style=for-the-badge


