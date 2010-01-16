#light

let squares = [| for i in 1 .. 7 -> i * i |]


//index with a dot and indexer
printfn "%d" squares.[0] 

//array is mutable
squares.[0] <- 10000

printfn "%d" squares.[0]

let slice = squares.[0..3]

let lowerbound = squares.[0..]

let upperbound = squares.[..4]

let all = squares.[*]

let divisions = 4.0
let twoPi = 2.0 * Math.PI;;

val divisions : float = 4.0
val twoPi : float = 6.283185307

//creates a 4 element array function gets called 4 times with the index
Array.init (int divisions) (fun i -> float i * twoPi / divisions);;

let describe array = 
	match array with
	| null 	-> "null"
	| [| |] -> "empty"
	| [| x |] -> "single element"
	| [| x; y |] -> "two element"
	| _ -> "more than 2"

describe [|1|]
describe [|1; 2|]
describe null
describe [| 1; 5; 22|]


