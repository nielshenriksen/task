namespace WordCountLib
{
    public class Core
    {
        private Dictionary<string, int> words = new Dictionary<string, int>();

        public Core()
        {
            ForceCaseSensitive = false;
        }

        public Core(bool forceCaseSensitive)
        {
            ForceCaseSensitive = forceCaseSensitive;
        }

        /// <summary>
        /// Reset the list
        /// </summary>
        public void Clear()
        {
            words = new Dictionary<string, int>();
            ForceCaseSensitive = false;
        }

        /// <summary>
        /// Force the text to be case sensitive or not
        /// </summary>
        public bool ForceCaseSensitive { get; set; }

        /// <summary>
        /// Add a text string to the wordlist.
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Number of words found</returns>
        public int AddText(string text)
        {
            var found = text.Split(" ");
            var foundWords = 0;

            foreach (var word in found) {
                // we dont count space
                if(String.IsNullOrEmpty(word)) continue;

                foundWords++;

                if (words.ContainsKey(word)) {
                    words[word]++;
                }
                else {
                    words.Add(word, 1);
                }
            }

            return foundWords;
        }

        /// <summary>
        /// returns the count for how many times a word is found
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public int Count(string word)
        {
            if(!words.ContainsKey(word)) { return 0; }

            return words[word];
        }

        /// <summary>
        /// Output the entire list of words and how many time its in the list
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var sortedWords = words.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            var response = "";
            foreach (var word in sortedWords) {
                response += $"{word.Key} {word.Value}\r\n";
            }

            return response;
        }
    }
}
