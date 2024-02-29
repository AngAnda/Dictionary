using Dicitionary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Dictionary.Repository
{
    public class WordRepository : IWordRepository
    {
        public List<Word> words;

        private readonly static string path = "words.json";

        public List<Word> GetWords() 
        {
            if(!File.Exists(path))
            {
                return new List<Word>();
            }

            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<Word>>(json);
        }

        public void AddWord(Word word)
        {
            words.Add(word);
            SaveWord(words);
        }

        public void DeleteWord(Word word)
        {
            words.Remove(word);
            SaveWord(words);
        }
        public void UpdateWord(Word word)
        {
            int index = words.FindIndex(w => w.Name == word.Name);
            if (index != -1)
            {
                words[index] = word;
                SaveWord(words); 
            }
        }

        public void SaveWord(List<Word> word)
        {
            try
            {
                string json = JsonConvert.SerializeObject(words, Formatting.Indented);
                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"A apărut o eroare: {ex.Message}");
            }
        }
    }
}
