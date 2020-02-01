// CSharp

using System; 

public class Kata
{
   private char[] alph = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private char[] alphShift13 = "nopqrstuvwxyzabcdefghijklm".ToCharArray();

        private string _Rot13(string message)
        {
            string sol = "";
            foreach (char chr in message)
            {
                int ind = Array.IndexOf(alph, Char.ToLower(chr));

                if (ind == -1)
                    sol += chr;
                else if (Char.IsUpper(chr))
                    sol += Char.ToUpper(alphShift13[ind]);
                else
                    sol += alphShift13[ind];
            }
            return sol;
        }

        public static string Rot13(string message)
        {
            return new Kata()._Rot13(message);
        }
}
