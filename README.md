# Design Pattern – Builder

## Contexto

Neste desafio foi necessário resolver um problema real de design e construção de objetos complexos utilizando o **Design Pattern Builder**.

Durante a implementação, foram reforçados importantes conceitos de engenharia de software:

- Boas Práticas de Desenvolvimento
- Código Limpo (Clean Code)
- Princípios SOLID
- Design Patterns

---

## Problema

O sistema precisava gerar **múltiplos tipos de relatórios**, incluindo:

- PDF
- Excel
- HTML

Cada relatório poderia possuir diversas **configurações opcionais**, como:

- Cabeçalho
- Rodapé
- Gráficos
- Tabelas
- Filtros
- Outras variações de layout

A implementação existente apresentava problemas clássicos de modelagem:

 Construtores com muitos parâmetros

 Uso excessivo de setters

 Código difícil de ler e manter

 Risco elevado de estados inválidos

 Baixa legibilidade na criação dos objetos

---

## Objetivo

Refatorar o processo de criação dos relatórios para:

- Eliminar construtores telescópicos
- Garantir fluidez e clareza na construção
- Permitir combinações flexíveis de configurações
- Evitar objetos inconsistentes
- Melhorar a legibilidade do código

---

## Solução

Foi aplicado o **Builder Pattern**, permitindo separar a **construção** do objeto da sua **representação final**.

A criação do relatório passou a seguir um fluxo declarativo e controlado.

---

## Estrutura da Solução

O padrão foi organizado em:

- **Product** → `Report`
- **Builder Interface** → Define etapas de construção
- **Concrete Builders** → Implementações por tipo (PDF, Excel, HTML)
- **Director (opcional)** → Orquestra construções padronizadas

---

## Exemplo de Uso

A construção do relatório tornou-se mais expressiva e segura:

```
var report = new PdfReportBuilder()
    .WithHeader("Relatório de Vendas")
    .WithFooter("Confidencial")
    .WithCharts()
    .WithTables()
    .WithFilters()
    .Build();
```

Benefícios imediatos:

Código autoexplicativo

Ordem de construção controlada

Configurações opcionais bem organizadas

Redução de erros de inicialização

---

## Benefícios Obtidos

Com a adoção do Builder:

Eliminação de construtores complexos

Maior clareza semântica

Facilidade de extensão

Encapsulamento da lógica de construção

Melhor manutenção e testes

Adicionar novos tipos de relatório agora exige apenas:

1. Criar um novo Builder concreto
2. Implementar as regras específicas

Sem impacto no código cliente.

---

## Aprendizados

Este desafio consolidou conhecimentos importantes:

- Construção de objetos complexos
- Separação entre criação e representação
- API fluente (Fluent Interface)
- Aplicação prática de SOLID
- Redução de complexidade acidental

---

## 🚀 Conclusão

O **Builder Pattern** mostrou-se ideal para cenários com múltiplas variações e parâmetros opcionais, proporcionando um código mais legível, flexível e sustentável.
