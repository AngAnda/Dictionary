using Dicitionary.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Dictionary.Repository
{
    public interface IWordRepository
    {
        List<Word> GetWords();

        void SaveWord(List<Word> word);

        void AddWord(Word word);

        void DeleteWord(Word word);

        void UpdateWord(Word word);
        ObservableCollection<string> GetCategories();

    }
}
