# KieTec

Esse projeto foi desenvolvido para o teste técnico da Kie Tec.
Foi utilizado ASP.NET MVC com .NET 8, assim como o banco de dados SQLite para armazenamento das informações.

### Instruções para rodar a aplicação

- Faça o clone do repositório.
- Acesse a solução e abra o terminal na raiz do projeto.

### Próximos passos (IMPORTANTE)
Método 1: Caso esteja utilizando o terminal do Windows ou Power Shell, rode o seguinte comando:

- dotnet ef database update
  (Se não possuir o "dotnet ef" instalado, instale com o seguinte comando: dotnet tool install --global dotnet-ef --version 8.\*)

Método 2: Caso esteja utilizando o console do NuGet Package Manager, rode o seguinte comando:

- update-database

Após isso, já é possível rodar a aplicação através do Visual Studio ou pelo seguinte comando:

- dotnet run

### Fluxo alternativo

Se houver algum problema com o banco de dados no momento de rodar a aplicação, exclua o arquivo "LocalDatabase.db" e a pasta "Migrations", crie e execute as migrations novamente, da seguinte forma:

- dotnet ef migrations add NomeDaMigration
- dotnet ef database update

ou

- add-migration NomeDaMigration
- update-database

### Decisões

O teste não ficou 100% concluído. Por erro meu, passou despercebido a instrução para a criação do método "Add Supplier", quando voltei para revisar os requisitos já estava com o tempo curto desenvolver. Para associar o "Fornecedor" ao produto, ele pode ser adicionado normalmente através do formulário de edição do produto, ou na criação do mesmo.

Esse teste foi construído utilizando o padrão MVC. Infelizmente não consegui tempo o suficiente para fazer tudo que estava planejando devido as demandas na empresa em que trabalho atualmente, e na minha faculdade. Com mais tempo disponível eu com certeza melhoraria os seguintes pontos:

- Validações e mensagens dos campos, principalmente os númericos. Pois o campo de "Preço" do produto por exemplo, apresenta alguns bugs quando é inserido com casas decimais.
- Máscara para o campo de telefone.
- Deixaria os cards de produtos e fornecedores (que só aparecem na versão mobile) mais intuitivos e "agradáveis" visualmente.
- Desenvolveria um layout mais amigável.
