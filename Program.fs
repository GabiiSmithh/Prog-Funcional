open Arvore
open Streams

[<EntryPoint>]
let main argv =
    // Parte 1: Árvore
    let exemplo =
        No (10,
            Folha 5,
            No (15,
                Folha 12,
                Folha 20))

    let dobrado = mapArvore (fun x -> x * 2) exemplo
    let soma = foldArvore (fun acc x -> acc + x) 0 exemplo
    let profundidade =
        let rec calcProf arv =
            match arv with
            | Folha _ -> 1
            | No (_, esq, dir) -> 1 + max (calcProf esq) (calcProf dir)
        calcProf exemplo

    let espelhada = espelharArvore exemplo

    printfn "Árvore original: %A" exemplo
    printfn "Árvore com valores dobrados: %A" dobrado
    printfn "Soma dos valores da árvore: %d" soma
    printfn "Profundidade da árvore: %d" profundidade
    printfn "Árvore espelhada: %A" espelhada

    // Parte 2: Streams
    // Exemplo 1: primeiros 10 números da sequência de Fibonacci
    let primeirosFib = fibonacci |> Seq.truncate 10 |> Seq.toList
    printfn "Primeiros 10 números de Fibonacci: %A" primeirosFib

    // Exemplo 2: primeiros 10 números primos
    let primeirosPrimos = primos |> Seq.truncate 10 |> Seq.toList
    printfn "Primeiros 10 números primos: %A" primeirosPrimos

    // Exemplo 3: intercalando os dois streams (Fibonacci e Primos)
    let intercalados = intercalar fibonacci primos |> Seq.truncate 20 |> Seq.toList
    printfn "Primeiros 20 números intercalados (Fibonacci e Primos): %A" intercalados

    // Desafio: primeiros 10 primos com o Crivo de Eratóstenes lazy
    let primeirosCrivo = primosCrivo |> Seq.truncate 10 |> Seq.toList
    printfn "Primeiros 10 primos usando o Crivo de Eratóstenes: %A" primeirosCrivo

    0
