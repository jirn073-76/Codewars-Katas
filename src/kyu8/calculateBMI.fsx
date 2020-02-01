// FSharp
let bmi weight height = 
  let bmicoeff = weight / (height * height)
  if bmicoeff <= 18.5 then "Underweight"
  elif bmicoeff <= 25.0 then "Normal"
  elif bmicoeff <= 30.0 then "Overweight"
  else "Obese"
