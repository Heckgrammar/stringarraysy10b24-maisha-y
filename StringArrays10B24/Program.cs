namespace StringArrays10B2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string[] word1 = { "h", "e", "l", "l", "o" };
                string[] pre1 = { "h", "e" };
                string[] word2 = { "w", "o", "r", "l", "d" };
                string[] pre2 = { "w", "o", "r", "l", "d" };
                string[] word3 = { "t", "e", "s", "t" };
                string[] pre3 = { "t", "e", "s", "t", "i", "n", "g" };
                Console.WriteLine(Prefix(word1, pre1));
                Console.WriteLine(Prefix(word2, pre2));
                Console.WriteLine(Prefix(word3, pre3));
            }
            static bool Prefix(string[] word, string[] pre)
            {
                if (pre.Length > word.Length)
                {
                   return false;
                }
                for (int i = 0; i < pre.Length; i++)
                {
                    if (word[i] != pre[i])
                    {
                        return false;
                    }
                }
                return true;

            }

        }

    }
}


