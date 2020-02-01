-- Haskell
module Kata (noSpace) where

noSpace :: String -> String
noSpace str = [n | n <- str, n /= ' ']
