module Paralelo

open System
open System.Numerics // Adicione esta linha para usar BigInteger

/// Soma dos quadrados (sequencial) com BigInteger
let somaQuadradosSequencial (lista: int list) =
    lista
    |> List.map (fun x ->
        let bigX = bigint x // Converte x para BigInteger
        bigX * bigX)        // Multiplica como BigInteger
    |> List.sumBy id        // Soma os BigInteger. Use List.sumBy id para BigInteger

/// Soma dos quadrados (paralelo) com BigInteger
let somaQuadradosParalelo (lista: int list) =
    lista
    |> List.toArray
    |> Array.Parallel.map (fun x ->
        let bigX = bigint x // Converte x para BigInteger
        bigX * bigX)        // Multiplica como BigInteger
    |> Array.sumBy id       // Soma os BigInteger. Use Array.sumBy id para BigInteger