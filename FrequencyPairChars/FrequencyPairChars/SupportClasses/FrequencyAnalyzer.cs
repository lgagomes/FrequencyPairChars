using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyPairChars.SupportClasses
{
    public class FrequencyAnalyzer
    {
        private string _text;
        private Dictionary<string, int> _frequencies;
        public StringBuilder syllables;
        public StringBuilder frequencyCounter;

        public FrequencyAnalyzer()
        {
            _frequencies = new Dictionary<string, int>();
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
            _frequencies.OrderBy(x => x.Value).Select(x => x.Key);
            foreach (KeyValuePair<string, int> item in _frequencies)
            {
                frequencyCounter.Append($"{item.Key} {item.Value}{Environment.NewLine}");
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

            for (int i = 0; i < text.Length-1; i++)
            {
                if(text[i] != ' ' && text[i + 1] != ' ')
                {
                    string actualSyllable = ($"{text[i]}{text[i + 1]}");

                    syllables.Append($"{actualSyllable}{Environment.NewLine}");                    

                    if (_frequencies.ContainsKey(actualSyllable))
                    {
                        _frequencies[actualSyllable]++;
                    }
                    else
                    {
                        _frequencies[actualSyllable] = 1;
                    }
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
