// FSharp

let getMiddle (str : string) = match str with
                                     | str when str.Length % 2 = 0 -> let half = str.Length / 2
                                                                      str.[half-1..half]
                                     | _ -> str.[str.Length / 2].ToString()

