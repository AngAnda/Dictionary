
using Dicitionary.Models;
using Dicitionary.ViewModels;
using Dictionary.Repository;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Dictionary.ViewModels
{
    public class QuizPageViewModel : BaseViewModel
    {

        private readonly IWordRepository _wordRepository;
        static int numberOfWords = 5;

        private ObservableCollection<Word> _words;

        public ObservableCollection<Word> Words
        {
            get => _words;
            set
            {
                _words = value;
                NotifyPropertyChanged(nameof(Words));
            }
        }

        private bool _showDescription;

        public bool ShowDescription
        {
            get => _showDescription;
            set
            {
                _showDescription = value;
                NotifyPropertyChanged(nameof(ShowDescription));
            }
        }

        private int _currentIndex;

        public int CurrentIndex
        {
            get => _currentIndex;
            set
            {
                if(CurrentIndex < Words.Count - 1)
                {
                    _currentIndex = value;
                    NotifyPropertyChanged(nameof(CurrentIndex));
                    NotifyPropertyChanged(nameof(CurrentWord));
                }
               
            }
        }

        public Word CurrentWord
        {
            get => Words[CurrentIndex];
        }   

        public string RightButtonContent
        {
            get => (CurrentIndex == numberOfWords) ? "Finish" : "Next";
        }
  
        public QuizPageViewModel()
        {
            _wordRepository = new WordRepository();
            Words = _wordRepository.GetWords();
            CurrentIndex = 0;
            ShowDescription = true;

            NextWordCommand = new RelayCommand(_ => CurrentIndex++, _ => CurrentIndex < numberOfWords);   
            PreviousWordCommand = new RelayCommand(_ => CurrentIndex--, _ => CurrentIndex > 0);
        }

        public ICommand NextWordCommand { get; set; }

        public ICommand PreviousWordCommand { get; set; }

    }
}
