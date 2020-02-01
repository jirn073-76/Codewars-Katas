// CSharp
using System;

public class Printer 
{
    public static string PrinterError(String s)
        {
            int errors = 0;
            List<char> letters = new List<char> { 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            foreach(char ch in s)
            {
                if(letters.Contains(ch))
                    errors += 1;         
            }
            string answer = (errors + "/" + s.Length);
            return answer;
        }
}
