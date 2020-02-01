// FSharp
open System

let predictAge(age1: int, age2: int, age3: int, age4: int, age5: int, age6: int, age7: int, age8: int): int = 
    let ages = [age1;age2;age3;age4;age5;age6;age7;age8]
    ages |> List.map(fun x -> x*x)
         |> List.sum
         |> (fun x -> int((sqrt(float x)/2.0)))
    
