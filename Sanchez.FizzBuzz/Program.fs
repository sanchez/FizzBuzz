[<AutoOpen>]
module FizzBuzz =
    let (|Fizz|_|) arg =
        if (arg % 3) = 0 then Some ()
        else None
        
    let (|Buzz|_|) arg =
        if (arg % 5) = 0 then Some ()
        else None

[<EntryPoint>]
let main argv =
    let items =
        Seq.initInfinite id
        |> Seq.skip 1
    
    items
    |> Seq.map (function
        | Fizz & Buzz -> "FizzBuzz"
        | Fizz -> "Fizz"
        | Buzz -> "Buzz"
        | rem -> sprintf "%d" rem)
    |> Seq.iter (printf "%s, ")
    
    0
