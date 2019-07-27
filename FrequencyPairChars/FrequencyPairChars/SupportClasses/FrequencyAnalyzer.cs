using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FrequencyPairChars.SupportClasses
{
    public class FrequencyAnalyzer
    {
        private const double HUNDRED = 100.00;
        private string _text;
        private Dictionary<string, int> _frequencies;
        public StringBuilder syllables;
        public StringBuilder frequencyCounter;

        public FrequencyAnalyzer()
        {
            _frequencies = new Dictionary<string, int>();
        }

        public void Reset()
        {
            _text = string.Empty;
            syllables.Clear();
            frequencyCounter.Clear();
            _frequencies.Clear();
        }

        public void AnalyzeText(string text)
        {
            _text = text.ToUpper();
            _text = RemoveSpecialCharacters(_text);
            GetSyllables(_text);
            UpdateFrequencies();
        }

        private void UpdateFrequencies()
        {
            int counter = 0;

            var orderedFrequencies = from pair in _frequencies
                       orderby pair.Value descending
                       select pair;

            frequencyCounter.AppendLine("Syllable \t Qty. \t   %");
            foreach (KeyValuePair<string, int> item in orderedFrequencies)
            {
                if (counter < HUNDRED)
                {
                    frequencyCounter.AppendLine($"{item.Key} \t {item.Value} \t {(item.Value * HUNDRED) / _frequencies.Count}%");
                    counter++;
                }
                else
                {
                    break;
                }
            }
        }

        private string RemoveSpecialCharacters(string text)
        {
            return text.Replace("Á","A").Replace("À","A").Replace("Ã","A").Replace("Â","A")
                .Replace("É","E").Replace("È","E").Replace("Ê","E")
                .Replace("Í","I").Replace("Ì","I")
                .Replace("Ó","O").Replace("Ò", "O").Replace("Õ", "O").Replace("Ô", "O")
                .Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U");
        }

        private void GetSyllables(string text)
        {
            syllables = new StringBuilder();
            frequencyCounter = new StringBuilder();
            string actualSyllable;

            for (int i = 0; i < text.Length-1; i++)
            {
                if(text[i] != ' ' && text[i + 1] != ' ')
                {
                    actualSyllable = ($"{text[i]}{text[i + 1]}");

                    syllables.Append($"{actualSyllable}{Environment.NewLine}");

                    _frequencies[actualSyllable] = (_frequencies.ContainsKey(actualSyllable))
                        ? _frequencies[actualSyllable] + 1
                        : 1;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
