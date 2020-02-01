-- Haskell
module Haskell.Codewars.RemoveChar where

removeChar :: String -> String
removeChar str = tail (init str)
