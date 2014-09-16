
namespace HackerRank
{
    public class ReverseTHSolution
    {
        public string Output { get; private set; }

        public ReverseTHSolution(string input)
        {
            char[] word = input.ToCharArray();

            for (int i = 1; i < word.Length; i++)
            {
                int j = i;
                while (j >= 1 && word[j] == 'h' && word[j - 1] == 't')
                {
                    Swap(j, j - 1, word);
                    j--;
                }
            }

            Output = new string(word);
        }

        private static void Swap(int start, int end, char[] word)
        {
            char temp = word[start];
            word[start] = word[end];
            word[end] = temp;
        }
    }
}
