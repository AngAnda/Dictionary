using Dicitionary.Models;
using Dictionary.Repository;
using System.Collections.Generic;
using System.ComponentModel;

namespace Dicitionary.ViewModels
{
    public class AdministrationViewModel : INotifyPropertyChanged
    {
        private List<Word> _words;

        private IWordRepository wordRepository;
        public List<Word> Words
        {
            get { return _words; }
            set
            {
                _words = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Words)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public AdministrationViewModel()
        {
            Words = new WordRepository().GetWords();
        }

        public void AddWord(Word word)
        {
            wordRepository.AddWord(word);
            Words = wordRepository.GetWords();
        }

        public void DeleteWord(Word word)
        {
            wordRepository.DeleteWord(word);
            Words = wordRepository.GetWords();
        }

        public void UpdateWord(Word word)
        {
            wordRepository.UpdateWord(word);
            Words = wordRepository.GetWords();
        }
    }
}
