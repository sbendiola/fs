#light

open System

//raise an exception

let throws n d =
    if d = 0 then raise <| new DivideByZeroException()
    n / d

let showCatch =
    try 
      throws 1 2 |> ignore
      throws 1 0
    with 
      | :? DivideByZeroException as d -> 
           printfn "divided by zero %s" d.Message
           -1
      | ex -> 
           printfn "unknown %s" ex.Message
           -2
let tryfinally() = 
    try
      printfn "about to fail"
      failwith "error"
      printfn "after error"
    finally
      printfn "in finally"