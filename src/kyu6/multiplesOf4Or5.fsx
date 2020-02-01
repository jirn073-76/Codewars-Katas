// FSharp

let rec solvefn ls = match ls with
                      | hd::tl when (hd % 3 = 0) || (hd % 5 = 0)  ->  hd :: (solvefn tl)
                      | hd::tl -> solvefn tl
                      | _ -> []
                                 
let solve n = solvefn [1..n-1] |> List.sum
