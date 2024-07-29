using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_ADV02.Q04
{
    public class FirstNonRepeatedCharacter
    {
        public static int GetFirstNonRepeatedCharacterIndex(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return -1;
            }

            Dictionary<char, (int Count, int Index)> charMap = new Dictionary<char, (int Count, int Index)>();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (charMap.ContainsKey(c))
                {
                    charMap[c] = (charMap[c].Count + 1, charMap[c].Index);
                }
                else
                {
                    charMap[c] = (1, i);
                }
            }

            foreach (var entry in charMap)
            {
                if (entry.Value.Count == 1)
                {
                    return entry.Value.Index;
                }
            }

            return -1;
        }

    }
}
