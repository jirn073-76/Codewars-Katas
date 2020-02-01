// FSharp
let squaresInRect lng wdth =
      let rec rectToSquaresUtil a b sol =
         let lng = if a > b then a else b   
         let shrt = if b > a then a else b
                  
         match (lng, shrt, sol) with
         | _ when sol = [] && lng = shrt -> None  
         | _ when (lng - shrt) <= 0 -> Some(sol @ [shrt])
         | _ -> rectToSquaresUtil (lng-shrt) shrt (sol @ [shrt])
         
      rectToSquaresUtil lng wdth []        
