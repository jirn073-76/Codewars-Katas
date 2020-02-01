// FSharp

open System

let deleteDigit (n : int) =
    let n = n.ToString().ToCharArray()
    let rec genNum i ls =
        match i with
        | _ when i < n.Length -> let newNum = seq { 
                                                    for i2 in [0 .. n.Length-1] do
                                                        if i2 <> i then
                                                            yield n.[i2].ToString()
                                                  }
                                 genNum (i+1) ((String.concat "" newNum) :: ls)
        | _ -> Int32.Parse ((List.sort ls).[ls.Length-1])
    genNum 0 []
