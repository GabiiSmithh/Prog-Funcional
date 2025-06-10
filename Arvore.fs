module Arvore

/// Define a estrutura de uma árvore binária com valores em nós e folhas
type Arvore<'T> =
    | Folha of 'T
    | No of 'T * Arvore<'T> * Arvore<'T>

/// Aplica uma função a todos os elementos da árvore
let rec mapArvore f arv =
    match arv with
    | Folha valor -> Folha (f valor)
    | No (valor, esq, dir) ->
        No (f valor, mapArvore f esq, mapArvore f dir)

/// Reduz a árvore a um único valor usando uma função acumuladora
let rec foldArvore f acc arv =
    match arv with
    | Folha valor -> f acc valor
    | No (valor, esq, dir) ->
        let acc1 = f acc valor
        let acc2 = foldArvore f acc1 esq
        foldArvore f acc2 dir

/// Inverte os ramos da árvore (espelhamento horizontal)
let rec espelharArvore arv =
    match arv with
    | Folha valor -> Folha valor
    | No (valor, esq, dir) ->
        No (valor, espelharArvore dir, espelharArvore esq)
