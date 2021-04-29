using System;
using System.Linq;

namespace PigLatin
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput = GetInput("Please input a word or sentence to translate to pig Latin");

            string translation = IsVowels(userInput); // just reworked vowels to display
            Console.WriteLine(translation);
            //trying to figure out a way to display all methods in main
            //Became very confused how to rework without redoing the entire project
        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }

        public static string IsVowels(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            word = word.ToLower();
            foreach (char c in vowels)
            {
                foreach (char w in word)
                {
                    if (w == c)
                    {
                        word = word + "way";
                        break;
                    }
                    else//consonant
                    {
                        for (int i = 0; i < word.Length; i++)
                        {
                            //Console.WriteLine(word.Substring(i,1)); testing
                            if (word.Substring(i, 1) == "a" || word.Substring(i, 1) == "e" || word.Substring(i, 1) == "i" || word.Substring(i, 1) == "o" || word.Substring(i, 1) == "u")
                            {
                                //Console.WriteLine(word.Substring(0,i));//move to end testing
                                //Console.WriteLine(word.Substring(i));//move to beginning testing
                                word = word.Substring(i) + word.Substring(0, i) + "ay";
                                break; // found our word. Need to exit loop
                            }
                        }
                    }
                }
            }
            return word;
            
             // return c.ToString() == vowels.ToString();
        }

        public static string ToPigLatin(string word)
        {
            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
            word = word.ToLower();
            foreach(char c in specialChars)
            {
                foreach(char w in word)
                {
                    if (w == c)
                    {
                        Console.WriteLine("That word has special characters, we will return it as is");
                        return word;
                    }
                }
                
            }
            
            //Did not find use in this code. Not as organized to follow.

            //bool noVowels = true;
            //foreach(char letter in word)
            //{
            //    if (IsVowel(letter))
            //    {
            //        noVowels = false;
            //    }
            //}

            //if (noVowels)
            //{
            //    return word; 
            //}

            //char firstLetter = word[0];
            //string output = "placeholder";
            //if (IsVowel(firstLetter) == true)
            //{
            //    output = word + "way";//fixed speling bug from "ay" to "way"
            //}
            //else
            //{
            //    int vowelIndex = -1;
            //    //Handle going through all the consonants
            //    for (int i = 0; i <= word.Length; i++)
            //    {
            //        if (IsVowel(word[i]) == true)
            //        {
            //            vowelIndex = i;
            //            break;
            //        }
            //    }

            //    string sub = word.Substring(vowelIndex + 1);
            //    string postFix = word.Substring(0, vowelIndex -1);

            //    output = sub + postFix + "ay";
            //}

            return word;
        }
    }
}
