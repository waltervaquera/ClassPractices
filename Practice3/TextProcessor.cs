using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice3
{
    internal class TextProcessor
    {
        public event EventHandler ProcessingCompleted;

        public void ProcessText(string filePath)
        {
            try
            {
                string text = File.ReadAllText(filePath);
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine($"File not found: {exception}");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Something wrong happened: {exception}");
            }
        }

        private int CountWords(string text)
        {
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words.Count();
        }

        private Dictionary<char, int> CountCharacterFrequency(string text)
        {
            char[] characters = text.ToCharArray();

            Dictionary<char, int> characterFrequency = characters
                .GroupBy(character => character)
                .ToDictionary(group => group.Key, group => group.Count());

            return characterFrequency;
        }

        private string FindLongestWord(string text)
        {
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words.OrderByDescending(word => word.Length).First();
        }

        protected virtual void OnProcessingCompleted(EventArgs e)
        {

        }
    }
}
