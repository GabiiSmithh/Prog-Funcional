module Streams

/// Sequência infinita de números primos (simples, não crivo)
let primos = seq {
    let isPrime n =
        if n < 2 then false
        else
            let limite = int (sqrt (float n))
            seq { 2 .. limite } |> Seq.forall (fun d -> n % d <> 0)

    let mutable x = 2
    while true do
        if isPrime x then yield x
        x <- x + 1
}

/// Sequência infinita de Fibonacci
let fibonacci = seq {
    let mutable a = 0
    let mutable b = 1
    while true do
        yield a
        let temp = a + b
        a <- b
        b <- temp
}

/// Intercala dois streams infinitos
let rec intercalar (s1: seq<'T>) (s2: seq<'T>) : seq<'T> = seq {
    use e1 = s1.GetEnumerator()
    use e2 = s2.GetEnumerator()
    while true do
        if e1.MoveNext() then yield e1.Current
        if e2.MoveNext() then yield e2.Current
}

/// Crivo de Eratóstenes usando lazy evaluation para gerar primos eficientemente
let primosCrivo : seq<int> =
    let rec sieve (xs: seq<int>) = seq {
        let head = Seq.head xs
        yield head
        let tail = Seq.skip 1 xs |> Seq.filter (fun x -> x % head <> 0)
        yield! sieve tail
    }

    sieve (Seq.initInfinite (fun i -> i + 2))  // começa de 2
