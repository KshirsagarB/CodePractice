using System.Text;

namespace CodingPractice
{
    public class CodePractice
    {
        public static void Main(string[] args)
        {
            int[] intArr = [3,4,5,2,1];
            SumofEvenNumbers(intArr);

            //findallsubstring("abcd");

            //removeduplicate("csharpcorner");

            //Countcharacter("hello world");

            //ReverseWordOrder("Welcome to Csharp corner");

            //ReverseString("hello");

            //chkPalindrome("madam");

            //if (FindPrime(13))
            //{
            //    Console.WriteLine("Prime");
            //}
            //else
            //{
            //    Console.WriteLine("Not Prime");
            //}
        }

        #region Sum of even numbers from an array
        internal static void SumofEvenNumbers(int[] intArr)
        {
            int sum = 0;
            //Sum of int numbers
            foreach (var num in intArr)
            {
                if (num % 2 == 0)
                    sum += num;
            }
            var sum1 = intArr.Where(x => x % 2 == 0).Sum(x => x);
            Console.WriteLine(sum1);
        } 
        #endregion

        #region Given number is prime or not
        internal static bool FindPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var squareRoot = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= squareRoot; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
        #endregion

        #region Find all substrings from input string
        internal static void findallsubstring(string str)
        {
            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
        }
        #endregion

        #region Remove Duplicate characters from string
        //    input: csharpcorner, output: csharpone
        internal static void removeduplicate(string str)
        {
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
        }
        #endregion

        #region Print characters and their occurance count in given string
        //input: hello world;
        internal static void Countcharacter(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }

            }
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }
        #endregion

        #region Reverse the word order of input string
        //input: Welcome to Csharp corner, output: corner Csharp to Welcome
        internal static void ReverseWordOrder(string str)
        {
            int i;
            StringBuilder reverseSentence = new StringBuilder();

            int Start = str.Length - 1;
            int End = str.Length - 1;

            while (Start > 0)
            {
                if (str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverseSentence.Append(str[i]);
                        i++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }

            for (i = 0; i <= End; i++)
            {
                reverseSentence.Append(str[i]);
            }
            Console.WriteLine(reverseSentence.ToString());
        }
        #endregion

        #region Reverse the characters of given string
        //input: hello, output: olleh
        internal static void ReverseString(string str)
        {

            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }
        #endregion

        #region Palindrome or not
        internal static void chkPalindrome(string str)
        {
            bool flag = false;
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }
            if (flag)
            {
                Console.WriteLine("Palindrome");
            }
            else
                Console.WriteLine("Not Palindrome");
        } 
        #endregion
    }
}
