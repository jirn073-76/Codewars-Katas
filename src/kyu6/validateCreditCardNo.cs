// CSharp

using System;
using System.Linq;

public class solution
{
        public bool validate(string n)
        {
            int[] numbers = n.Reverse()
                .Where(x => Char.IsNumber(x))
                .Select(x => Int32.Parse(x.ToString()))
                .ToArray();

            bool alt = false;
            for (int i = 1; i <= numbers.Length; i++)
            {
                if (alt)
                {
                    numbers[i-1] *= 2;
                    if (numbers[i-1] > 9)
                        numbers[i-1] = Int32.Parse(numbers[i-1].ToString()[0].ToString()) + Int32.Parse(numbers[i-1].ToString()[1].ToString());
                }
                alt = !alt;
            }
            return numbers.Sum() % 10 == 0;
        }
}
