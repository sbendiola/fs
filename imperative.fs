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


//mutable values are only accessible in the function they are declared must put them in a ref
let x =
	let mutable i = 0
	//next 2 lies don't compile
	//let incrementI() = i <- i + 1
	//incrementI()
	
