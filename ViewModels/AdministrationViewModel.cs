using Dicitionary.Models;
using Dictionary.Repository;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;

namespace Dicitionary.ViewModels
{
    public class AdministrationViewModel : INotifyPropertyChanged
    {
        private List<Word> _words;

        private Word _currentWord;
        public Word CurrentWord
        {
            get { return _currentWord; }
            set
            {
                _currentWord = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentWord)));
            }
        }

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
            AddWordCommand = new RelayCommand(AddWord, CanAddWord);
            DeleteWordCommand = new RelayCommand(DeleteWord, CanDeleteWord);
            UpdateWordCommand = new RelayCommand(UpdateWord, CanUpdateWord);
            CurrentWord = Words.FirstOrDefault();
            wordRepository = new WordRepository();
        }

        private bool CanAddWord(object parameter)
        {
            return !string.IsNullOrWhiteSpace(CurrentWord?.Name) && !string.IsNullOrWhiteSpace(CurrentWord?.Description) && !string.IsNullOrWhiteSpace(CurrentWord?.Category);
        }

        private bool CanDeleteWord(object parameter)
        {
            return CurrentWord != null && _words.Any(w => w == _currentWord);
        }

        private bool CanUpdateWord(object parameter)
        {
            return CurrentWord != null && _words.Any(w => w == _currentWord);
        }

        private void DeleteWord(object parameter)
        {
            wordRepository.DeleteWord(CurrentWord);
            Words = wordRepository.GetWords();
        }

        private void AddWord(object parameter)
        {
            wordRepository.AddWord(CurrentWord);
            Words = wordRepository.GetWords();
        }

        private void UpdateWord(object parameter)
        {
            wordRepository.UpdateWord(CurrentWord);
            Words = wordRepository.GetWords();
        }

        public ICommand AddWordCommand { get; }
        public ICommand DeleteWordCommand { get; }
        public ICommand UpdateWordCommand { get; }

    }
}
