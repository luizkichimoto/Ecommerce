# 📌 CP1 - 2TDSPB - 2026.2: Modelo Entidade-Relacionamento e WebAPI

Este projeto contém a modelagem de banco de dados (MER) e a estrutura inicial de uma WebAPI em .NET, seguindo os princípios da Clean Architecture. O foco desta entrega é a definição das Entidades, seus atributos e seus relacionamentos (sem implementação de CRUD ou persistência em banco).

## 👥 Integrantes do Grupo

*   **Luiz Felipe Kichimoto Valdevino** - RM: 567726
*   **Gabriel Rocha de Souza** - RM: 567023
*   **Luis Fillipe Rodruigues Seripieri** - RM: 567918

## 🎯 O Domínio Escolhido: E-commerce (Loja Virtual)

Escolhemos o domínio de um E-commerce pois ele oferece uma riqueza de regras de negócio que permite explorar todos os cenários de relacionamentos (1:1, 1:N e N:N) e diferentes níveis de opcionalidade, garantindo uma modelagem completa e realista.

## 📦 Entidades Modeladas

Adotamos a utilização de **GUID** (Unique Identifier) para todas as Chaves Primárias (PK). Essa estratégia foi escolhida por facilitar a geração de IDs na própria aplicação e por aumentar a segurança.

Foram modeladas **6 entidades** no total:

1.  **Cliente:** Representa o usuário comprador da plataforma.
2.  **Carrinho:** Armazena o estado atual de compras não finalizadas de um cliente.
3.  **Categoria:** Classificação para organizar o catálogo da loja.
4.  **Produto:** O item disponível para venda.
5.  **Pedido:** O registro de uma compra finalizada pelo cliente.
6.  **ItemPedido:** Entidade associativa que conecta os Pedidos aos Produtos, registrando o preço na hora da compra e a quantidade.

## 🔗 Resumo dos Relacionamentos

A modelagem conta com os seguintes relacionamentos de cardinalidade e opcionalidade:

*   **Cliente 1 : 1 Carrinho (Opcional):** Um cliente pode ter, no máximo, um carrinho ativo. O carrinho é opcional para o cliente (ele pode estar sem carrinho), mas o carrinho obrigatoriamente pertence a um único cliente.
*   **Cliente 1 : N Pedido (Obrigatório do lado do pedido):** Um cliente pode realizar vários pedidos (ou nenhum, sendo opcional no MER). Porém, todo pedido criado pertence obrigatoriamente a um, e somente um, cliente.
*   **Categoria 1 : N Produto (Obrigatório):** Uma categoria abrupa vários produtos. Todo produto deve obrigatoriamente pertencer a uma categoria para existir no catálogo.
*   **Pedido N : N Produto (Resolvido via `ItemPedido`):** Um pedido pode conter vários produtos diferentes, e um mesmo produto pode ser vendido em vários pedidos. Esse relacionamento N:N foi resolvido criando a entidade associativa **ItemPedido** (sendo `Pedido 1:N ItemPedido` e `Produto 1:N ItemPedido`).

*   
