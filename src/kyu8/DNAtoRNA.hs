-- Haskell
module DnaToRna where 

dnaToRna :: String -> String 
dnaToRna xs = map (\x -> if x == 'T' then 'U' else x) xs
