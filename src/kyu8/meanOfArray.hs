-- Haskell
module Codewars.AverageCalculator where

getAverage :: [Int] -> Int
getAverage marks = sum marks `div` length marks
