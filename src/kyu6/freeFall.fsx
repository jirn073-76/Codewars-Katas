// FSharp
let maxBall(v0:int) = let v0, g = (float(v0) / 3.6), 9.81
                      let ls =  [for i in 0.0 .. 0.1 .. 10.0**4.0 do yield (i*10.0 ,(v0*i - 0.5*g*i*i))] |> Seq.maxBy snd |> fst
                      int(ls)
