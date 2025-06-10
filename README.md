# Projeto de Programação Funcional em F#

## Objetivo
Aprofundar os conceitos de programação funcional, resolvendo problemas complexos que envolvem recursão, lazy evaluation, processamento de streams e paralelismo funcional.

---

## Problema 1: Árvores e Recursão

### O que foi implementado
- Definição da estrutura de árvore binária (`Arvore<'T>`) com nós e folhas.
- Função `mapArvore` que aplica uma função a todos os elementos da árvore.
- Função `foldArvore` que reduz a árvore a um único valor (exemplo: soma).
- Função `espelharArvore` que inverte os ramos esquerdo e direito da árvore.
- Função auxiliar para cálculo de profundidade da árvore.

### Conceitos de Programação Funcional usados
- **Recursão**: Todas as funções que percorrem a árvore usam recursão para visitar cada nó e folha.
- **Imutabilidade**: As funções não modificam a árvore original, apenas criam novas estruturas.
- **Tipos algébricos (discriminated unions)**: A estrutura da árvore foi definida usando tipos algébricos do F# para representar nós e folhas.

### Conceitos ainda não usados (próximos problemas)
- **Lazy Evaluation (avaliação preguiçosa)**
- **Processamento de Streams infinitos**
- **Tail recursion e Memoization**
- **Paralelismo funcional**

---

## Próximos passos

- Implementar streams infinitos e funções de intercalamento (lazy evaluation).
- Implementar sequência de Fibonacci usando tail recursion e memoization.
- Implementar paralelismo funcional para soma dos quadrados em listas grandes.

---

## Como rodar

1. Ter o .NET SDK instalado.
2. Na pasta do projeto, executar:

```bash
dotnet run
