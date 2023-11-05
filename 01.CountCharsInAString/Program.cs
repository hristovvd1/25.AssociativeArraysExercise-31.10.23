namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> characters = new Dictionary<char, int>();

            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                var character = word[i];

                if (character == ' ')
                {
                    continue;
                }

                if (!characters.ContainsKey(character))
                {
                    characters.Add(character, 0);
                }

                characters[character]++;
            }

            foreach (KeyValuePair<char, int> pair in characters)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
