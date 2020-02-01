// FSharp

let vowels = ['a'; 'e'; 'i'; 'o'; 'u'; 'A';'E';'I';'O';'U';]

let disemvowel s = 
  s |> String.filter(fun x -> not(List.exists(fun y -> y = x) vowels))
