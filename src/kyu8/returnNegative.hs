-- Haskell
module Codewars.Kata.Negative where

makeNegative :: (Num a, Ord a) => a -> a
makeNegative a = if a < 0 then a else if a == 0 then a else a * (-1)
