using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_StringAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)
            Console.WriteLine("please write a sentence.\n");
            string sentence = Console.ReadLine();
            Method1(sentence);

            //2)
            Console.WriteLine("\n");
            Method2("Claim");
            Console.WriteLine("\n");

            //3)
            Console.WriteLine("please write another sentence.\n");
            string vowelSentence = Console.ReadLine();
            Console.WriteLine(Method3(vowelSentence) + " vowels.");

            //4)
            Console.WriteLine("write yet another sentence.\n");
            string anotherSentence = Console.ReadLine();
            Console.WriteLine("write a character to remove.\n");
            string character = Console.ReadLine();
            Console.WriteLine(Method4(anotherSentence, character));


            //5)

            //prompting user
            Console.WriteLine("write one final sentence.\n");
            //declaring string variable
            string finalSentence = Console.ReadLine();
            //calling method to leave out middle character(s)
            Console.WriteLine(Method5(finalSentence));

            //halting the console with a blank user input
            Console.ReadLine();     
            

        }
        public static void Method1(string sentence)
        {
            int count = 0;
            foreach (char item in sentence)
            {
                if (count % 2 == 0)
                {

                    Console.Write(item.ToString().ToLower());
                }
                else
                {
                    Console.Write(item.ToString().ToUpper());
                }
                count++;
            }

        }

        public static void Method2(string word)
        {

            string result = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                result = result + word[i];
            }
            if (word.Equals(result))
            {
                Console.WriteLine("This is palenmdrome");
            }
            else
            {
                Console.WriteLine("This is not a palenmdrome");
            }


        }
        public static int Method3(string vowelSentence)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            int vowelcount = 0;
            foreach (char item in vowelSentence)
            {
                foreach (char vowel in vowels)
                {
                    if (item == vowel)
                    {
                        vowelcount++;
                    }
                }
            }
            return vowelcount;
        }
        public static string Method4(string anotherSentence, string character)
        {
            string characterString = "";
            foreach (char item in anotherSentence)
            {
                if (item != Convert.ToChar(character))
                {
                    characterString = characterString + item;
                }
            }
            return characterString;
        }
        public static string Method5(string finalSentence)
        {
            string returningSentence = "";
            //checking if length of string variable is odd or even
            if (finalSentence.Length % 2 == 0)
            {
                //looping through sentence, checking each character/x value
                for (int x = 0; x < finalSentence.Length; x++)
                {
                    //checking if current x variable matches the index of middle characters
                    if (x != ((finalSentence.Length / 2) - 1) && x != finalSentence.Length / 2)
                    {
                        //writing characters to string
                       returningSentence = returningSentence + finalSentence[x];
                    }
                }
            }
            else
            {
                //declaring middle character
                int median = (finalSentence.Length / 2) - finalSentence.Length % 2;

                //looping through each character
                for (int x = 0; x < finalSentence.Length; x++)
                {
                    //checking each x variable if it is the middle character
                    if (x != median + 1)
                    {
                        //writing the characters to string
                        returningSentence = returningSentence + finalSentence[x];
                    }
                }
            }
            return returningSentence;

        }
    }
}
