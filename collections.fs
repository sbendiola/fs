#light
open System.Collections.Generic
let planets = new List<string>();;

// Add individual planets
planets. Add("Mercury")
planets. Add("Venus")
planets. Add("Earth")
planets. Add("Mars");;
planets. Count;;

//units of measure

[<Measure>]
type amu

type Atom = { Name: string; Weight : float<amu> };;
let periodicTable = new Dictionary<string, Atom>()
periodicTable.Add("H", {Name = "Hydrogen"; Weight = 1.0079<amu> });;
periodicTable. Add("He", { Name = "Helium";    Weight = 4.0026<amu> })
periodicTable. Add("Li", { Name = "Lithium";   Weight = 6.9410<amu> })
periodicTable. Add("Be", { Name = "Beryllium"; Weight = 9.0122<amu> })
periodicTable. Add( "B", { Name = "Boron ";    Weight = 10.811<amu> })


//this get returns a tuple
let symbol = "B"
let (found, atom) = periodicTable.TryGetValue(symbol)
if found then
   printfn "%s" atom.Name
else
   printfn "error %s not found" symbol


//this get throws exception on missing elements
let boron = periodicTable.[symbol]