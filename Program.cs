namespace Assignment_5._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                foreach (var arg in args)
                {
                    Console.WriteLine($"{arg} : {IsPalindrome(arg, 0, arg.Length - 1)} : {IsPalindrome(arg)}");
                }
            }
            else
            {
                string[] words = { "", "a", "qq", "ada", "bob", "charlie", "madam", "adam", "racecar", "race car" };
                foreach (var word in words)
                {
                    Console.WriteLine($"{word} : {IsPalindrome(word, 0, word.Length - 1)} : {IsPalindrome(word)}");
                }
            }
        }
        static bool IsPalindrome(string palindrome)
        {
            return palindrome.Length > 1 ? palindrome[0] == palindrome[palindrome.Length - 1] && IsPalindrome(palindrome.Substring(1, palindrome.Length - 2)) : true;
        }
        static bool IsPalindrome(string palindrome, int left, int right)
        {
            return left >= right ? true : palindrome[left] == palindrome[right] && IsPalindrome(palindrome, left + 1, right - 1);
        }
    }
}
