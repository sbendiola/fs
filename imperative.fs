#light

type Car = { Make : string; Model : string; mutable Miles : int }

let drive car miles =
	car.Miles <- car.Miles + miles

let car : Car = { Make = "Ford"; Model = "Mustang"; Miles = 0 }

//add 100 miles
drive car 100

//point hoopty to the existing car
let mutable hoopty = car

//reassigns the reference
hoopty <- { Make = "Ford"; Model = "Truck"; Miles = 0 };;


//a ref is a cell
let planets = ref [
        "Mercury";  "Venus";     "Earth";
        "Mars";     "Jupiter";   "Saturn";
        "Uranus";   "Neptune";   "Pluto"]

//remove pluto and reassign the ref
planets := !planets |> List.filter (fun p -> p <> "Pluto")


//mutable values are only accessible in the function they are declared
let x =
	let mutable i = 0
	//next 2 lies don't compile
	//let incrementI() = i <- i + 1
	//incrementI()
	
	//to get around this place in a ref
	let i = ref 0
	let incrementI() = i <- i + 1
	incrementI()

//while loops
let mutable i = 0
while i < 5 do
    i <- i + 1
    printfn "i = %d" i;;
i = 1
i = 2
i = 3
i = 4
i = 5


//for loops
for i = 1 to 5 do
    printfn "%d" i

for i = 5 downto 1 do
    printfn "%d" i
    

//for loop for enumerable
for i in [1..5] do
    printfn "%d" i

//can pattern match
type Pet = 
     | Cat of string * int //name and lives
     | Dog of string //name

let pets = [Dog("fido"); Dog("lassie"); Cat("tom", 9); Cat("morris", 9)]

for Dog(name) in pets do
    printfn "%s woof!" name

     


