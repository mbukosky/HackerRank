using System.Linq;

namespace HackerRank
{
    public class Palindrome
    {
        //http://www.geeksforgeeks.org/dynamic-programming-set-17-palindrome-partitioning/
        public static bool IsPalindrome(string word)
        {
            if (word == null)
                return false;

            for (int i = 0; i < word.Length / 2; i++)
            {
                int opp_idx = word.Length - 1 - i;
                if (word[i] != word[opp_idx])
                    return false;
            }

            return true;
        }

        public static bool IsPalindrome(string word, int i, int j)
        {
            return IsPalindrome(word.Substring(i, j - i + 1));
        }

        public static int MinPalindromePartitions(string word)
        {
            return MinPartition(word, 0, word.Length - 1);
        }

        private static int MinPartition(string word, int i, int j)
        {
            if (i == j)
                return 0;
            else if (IsPalindrome(word, i, j))
                return 0;
            else
                return Enumerable.Range(i, j - i + 1)
                    .Select(k => MinPartition(word, i, k) + 1 + MinPartition(word, k + 1, j))
                    .Min();
        }
    }
}
