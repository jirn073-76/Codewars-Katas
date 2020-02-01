// FSharp

let nums n = seq { for i in 1..n do yield i } |> Seq.toList
let rec fSum ls ag =  match ls with
                         | [] -> ag
                         | hd::tl when (hd % 3 = 0) || (hd % 5 = 0) -> fSum tl (ag+hd)
                         | hd::tl -> fSum tl ag
                         
let findSum n = fSum (nums n) 0
                         
