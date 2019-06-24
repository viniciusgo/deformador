using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DesafioSouth
{
    public class Deformador
    {
        private static string vogais = "aeiou";

        private static string Evaluator(Match match)
        {
            var letter = match.Value[0];
            if (letter == 'z')
                letter = 'a';
            else if (letter == 'Z')
                letter = 'A';
            else
                letter = (char)((int)letter + 1);

            letter = vogais.Contains(letter) ? $"{letter}".ToUpper()[0] : letter;

            return $"{letter}";
        }

        public static string Deformar(string entrada)
        {
            if (entrada == null)
                throw new ArgumentNullException("entrada");

            if (string.IsNullOrWhiteSpace(entrada))
                throw new ArgumentException("entrada");

            var matchEvaluator = new MatchEvaluator(Evaluator);
            var result = Regex.Replace(entrada, "[a-z]", matchEvaluator, RegexOptions.IgnoreCase);
            return result;
        }
    }
}
