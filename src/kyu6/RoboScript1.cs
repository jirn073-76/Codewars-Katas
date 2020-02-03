// CSharp
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Syntax
{
        public static Dictionary<char, string> formatter = new Dictionary<char, string>
        {
            {'F', "<span style=\"color: pink\">"},
            {'L', "<span style=\"color: red\">"},
            {'R', "<span style=\"color: green\">"},
            {'D', "<span style=\"color: orange\">"},
        };

        static char[] commands = new char[] { 'F', 'L', 'R' };

        private static void AppendString(string str, StringBuilder strBuilder)
        {
            string formatterStr = "";
            
            if (!Char.IsDigit(str[0]))
                formatterStr = formatter[str[0]];
            else
                formatterStr = formatter['D'];
  
            strBuilder.Append(formatterStr + str + "</span>");
        }
        
        public static string Highlight(string code)
        {
            StringBuilder strBuilder = new StringBuilder();
            string cache = "";
            for (int i = 0; i < code.Length; i++)
            {
                if (i != code.Length - 1)
                {
                    if ((code[i + 1] == code[i] && commands.Contains(code[i])) || (Char.IsDigit(code[i]) && Char.IsDigit(code[i + 1])))
                    {
                        cache += code[i];
                        continue;
                    }
                }
                
                if (cache.Length != 0)
                {
                    cache += code[i];
                    AppendString(cache, strBuilder);
                    cache = "";
                }
                
                else if (commands.Contains(code[i]) || Char.IsDigit(code[i]))
                    AppendString(code[i].ToString(), strBuilder);
                
                else
                    strBuilder.Append(code[i]);
            }
            return strBuilder.ToString();
        }
}
