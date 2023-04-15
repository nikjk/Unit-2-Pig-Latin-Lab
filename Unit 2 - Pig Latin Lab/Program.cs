using System;

namespace PigLatinTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goAgain = true;
            do
            {


                Console.WriteLine("Enter a sentence to convert to PigLatin:");
                string sentence = Console.ReadLine();
                string pigLatin = ToPigLatin(sentence);
                Console.WriteLine(pigLatin);


                static string ToPigLatin(string sentence)
                {

                    const string vowels = "AEIOUaeio";
                    List<string> pigWords = new List<string>();

                    foreach (string word in sentence.Split(' '))
                    {
                        string firstLetter = word.Substring(0, 1);
                        string restOfWord = word.Substring(1, word.Length - 1);
                        int currentLetter = vowels.IndexOf(firstLetter);

                        if (currentLetter == -1)
                        {
                            pigWords.Add(restOfWord + firstLetter + "ay");
                        }
                        else
                        {
                            pigWords.Add(word + "way");
                        }
                    }
                    return string.Join(" ", pigWords);
                }

                Console.Write("Do you want to translate another word? (Y/N): ");
                string choice = Console.ReadLine().ToUpper();

                if (choice != "Y")
                {
                    goAgain = false;
                }

                Console.WriteLine();

            } while (goAgain);

            Console.WriteLine("Goodbye!");
        }
    }

}
