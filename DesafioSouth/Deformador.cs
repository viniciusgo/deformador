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
            var letra = match.Value[0];
            if (letra == 'z')
                letra = 'a';
            else if (letra == 'Z')
                letra = 'A';
            else
                letra = (char)((int)letra + 1);

            letra = vogais.Contains(letra) ? $"{letra}".ToUpper()[0] : letra;

            return $"{letra}";
        }

        public static string Deformar(string entrada)
        {
            if (entrada == null)
                throw new ArgumentNullException("entrada");

            if (string.IsNullOrWhiteSpace(entrada))
                throw new ArgumentException("entrada");

            var matchEvaluator = new MatchEvaluator(Evaluator);
            return Regex.Replace(entrada, "[a-z]", matchEvaluator, RegexOptions.IgnoreCase);
        }
    }
}
