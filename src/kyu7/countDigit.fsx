// FSharp
let toSeq (n:int) = seq {for x in 0..n do yield! string(x*x)} |> Seq.toList
let rec countdig (ag:int) (d:int) (i:list<char>) = match i with                                                    
                                                    | hd::tl when hd = char(d) + '0' -> countdig (ag+1) d tl                            
                                                    | hd::tl -> countdig ag d tl
                                                    | _ -> ag                                                      
let nbDig (n:int) (d:int) =
    toSeq n |> countdig 0 d
  
