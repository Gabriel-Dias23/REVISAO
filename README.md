1. Entendendo o que é uma API
Pense em uma API (Interface de Programação de Aplicativos) como um "garçom" em um restaurante. Você (o cliente ou 

frontend) faz um pedido (uma requisição) ao garçom (a API). O garçom leva seu pedido para a cozinha (o 


backend ou servidor), que prepara a comida (processa a requisição). Finalmente, o garçom traz o prato pronto para você (a resposta).



Em termos técnicos, uma API é um conjunto de regras que permite que diferentes sistemas de software "conversem" entre si. Ela define como um aplicativo pode solicitar serviços ou dados de outro.


2. Configurando o Ambiente e Criando seu Primeiro Projeto
Para começar a construir APIs em .NET, você precisará de algumas ferramentas básicas, como o Visual Studio 2022 e o SDK do .NET 6.

Ao criar um novo projeto no Visual Studio, você geralmente escolherá o template "ASP.NET Core Web API". Durante a configuração, é importante selecionar o framework (como o .NET 6.0), habilitar o suporte para "Controllers" e também para o "OpenAPI" (Swagger).




O que é o Swagger? É uma ferramenta fantástica que gera uma documentação interativa para a sua API automaticamente. Ele cria uma página web onde você pode ver todos os "pedidos" que sua API aceita (os 


endpoints) e até mesmo testá-los diretamente pelo navegador, facilitando muito o desenvolvimento e a depuração.

3. As Operações Fundamentais: CRUD
CRUD é um acrônimo para as quatro operações básicas que podemos realizar com dados em uma aplicação:

C - Create (Criar): Adicionar novos dados. Geralmente associado ao verbo HTTP 

POST.



R - Read (Ler/Recuperar): Buscar dados existentes. Associado ao verbo HTTP 

GET.



U - Update (Atualizar): Modificar dados que já existem. Associado ao verbo HTTP 

PUT.


D - Delete (Deletar): Remover dados. Associado ao verbo HTTP 

DELETE.


Nos exemplos das aulas, para simular um banco de dados, os dados são armazenados temporariamente em uma lista estática dentro do próprio 

Controller.


4. A Importância da Validação de Dados
Validar os dados que chegam à sua API é um passo crucial por diversos motivos:


Integridade dos Dados: Garante que informações incorretas ou mal formatadas não sejam salvas no sistema.


Segurança: Previne ataques maliciosos, como a injeção de scripts (XSS) ou comandos SQL, que exploram a falta de validação.


Experiência do Usuário: Permite que você dê um feedback claro e imediato ao usuário sobre o que está errado com os dados enviados, evitando frustrações.


Prevenção de Erros: Evita que dados inválidos causem problemas lógicos ou quebrem a aplicação durante o processamento.
