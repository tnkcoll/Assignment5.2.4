namespace Assignment5._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userWord = GetWordFromUser("Enter a word to see if it is a Palindrome");
            
            //Send the user's word, zero, and the last index in the string array userWord to the IsPalindrome method.
            bool isPal = IsPalindrome(userWord, 0, userWord.Length - 1); 
            
            if (isPal)
            {
                Console.WriteLine($"{userWord} is a Palindrome.");
            }
            else
            {
                Console.WriteLine($"{userWord} is not a Palindrome.");
            }
        }

        static string GetWordFromUser(string s)
        {
            string? userInput = "";

            do
            {
                Console.WriteLine(s);

                //The trim method removes all spaces prior to the first word and after the last word of the user's input string.
                userInput = Console.ReadLine().Trim();
            } while (userInput == "");

            //Change all the letters in the string to lowercase because an uppercase A and a lowercase a have different values.
            return userInput.ToLower();
        }

        static bool IsPalindrome(string s, int begin, int end)
        {
            //Check to see if the end integer is a zero or a negative number. This tells the computer if the user's word is a single letter.
            if (begin >= end)
            {
                return true;
            }

            //Check to see if the letters at each index have the same value.
            if (s[begin] != s[end])
            {
                return false;
            }

            //Recursively call the IsPalindrome method but move one index to the right of the first half of the word and one index left of the last half of the word.
            return IsPalindrome(s, begin + 1, end - 1);
        }
    }
}
