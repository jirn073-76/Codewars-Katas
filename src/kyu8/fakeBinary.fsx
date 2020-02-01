// FSharp
let tofakebin = fun chr ->
                match chr with
                | chr when int(chr) < 53 -> '0'
                | chr when int(chr) >= 53 -> '1'
                | _ -> '/'
                        
let fakeBin str = String.map tofakebin str
