using System.Collections.Generic;
using System.Text;

namespace UniqueMorseCodeWords
{
    public static class Solution
    {
        public static int UniqueMorseRepresentations(string[] words)
        {
            HashSet<string> morseCodesCollection = new HashSet<string>();

            foreach (var word in words)
            {
                morseCodesCollection.Add(WordToMorseCodeTransformationUsingString(word));
            }

            return morseCodesCollection.Count;
        }

        public static string WordToMorseCodeTransformationUsingDict(string word)
        {
            const int maxCapacityOfMorseCodeForOneLetter = 4;

            StringBuilder morseCode = new StringBuilder(word.Length * maxCapacityOfMorseCodeForOneLetter);

            Dictionary<char, string> morseAlphabet = new Dictionary<char, string>()
            {
                { 'a', ".-"   },
                { 'b', "-..."  },
                { 'c', "-.-." },
                { 'd', "-.."  },
                { 'e', "."    },
                { 'f', "..-." },
                { 'g', "--."  },
                { 'h', "...." },
                { 'i', ".."   },
                { 'j', ".---" },
                { 'k', "-.-"  },
                { 'l', ".-.." },
                { 'm', "--"   },
                { 'n', "-."   },
                { 'o', "---"  },
                { 'p', ".--." },
                { 'q', "--.-" },
                { 'r', ".-."  },
                { 's', "..."  },
                { 't', "-"    },
                { 'u', "..-"  },
                { 'v', "...-" },
                { 'w', ".--"  },
                { 'x', "-..-" },
                { 'y', "-.--" },
                { 'z', "--.." }
            };

            foreach (char c in word)
            {
                morseCode.Append(morseAlphabet[c]);
            }

            return morseCode.ToString();
        }

        public static string WordToMorseCodeTransformationUsingString(string word)
        {
            const int maxCapacityOfMorseCodeForOneLetter = 4;

            StringBuilder morseCode = new StringBuilder(word.Length * maxCapacityOfMorseCodeForOneLetter);

           string[] morseAlphabet = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            foreach (char c in word)
            {
                morseCode.Append(morseAlphabet[c - 97]);
            }

            return morseCode.ToString();
        }

    }
}
