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
        /// Force the text to be case sensitive or not
        /// </summary>
        public bool ForceCaseSensitive { get; set; }

        /// <summary>
        /// Add a text string to the wordlist.
        /// </summary>
        /// <param name="text"></param>
        public void AddText(string text)
        {
            var found = text.Split(" ");

            foreach (var word in found) {
                
                // we dont count space
                if(String.IsNullOrEmpty(word)) continue;

                // regex for letters and numbers


                if (words.ContainsKey(word)) {
                    words[word]++;
                }
                else {
                    words.Add(word, 1);
                }
            }

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
            var response = "";
            foreach (var word in words) {
                response += $"{word.Key} {word.Value}";
            }

            return response;
        }
    }
}
