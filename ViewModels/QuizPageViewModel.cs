using Dicitionary.ViewModels;
using Dictionary.Models;
using Dictionary.Repository;
using Dictionary.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Dictionary.ViewModels
{
    public class QuizPageViewModel : BaseViewModel
    {

        static int numberOfWords = 5;


        private readonly RandomWordGenerator _randomWordGenerator;
        private ObservableCollection<WordDto> _words;

        public ObservableCollection<WordDto> Words
        {
            get => _words;
            set
            {
                _words = value;
                NotifyPropertyChanged(nameof(Words));
            }
        }

        public bool ShowDescription
        {
            get { return Words[CurrentIndex].ShowDescription; }
        }

        private int _currentIndex;

        public int CurrentIndex
        {
            get => _currentIndex;
            set
            {
                _currentIndex = value;
                NotifyPropertyChanged(nameof(CurrentIndex));
                NotifyPropertyChanged(nameof(CurrentWord));
                NotifyPropertyChanged(nameof(ShowDescription));
            }
        }

        public WordDto CurrentWord
        {
            get => Words[CurrentIndex];
        }

        public string RightButtonContent
        {
            get => (CurrentIndex == numberOfWords) ? "Finish" : "Next";
        }

        public QuizPageViewModel()
        {
            _randomWordGenerator = new RandomWordGenerator(new WordRepository(), numberOfWords);
            Words = _randomWordGenerator.GenerateRandomWords();
            CurrentIndex = 0;

            NextWordCommand = new RelayCommand(_ => CurrentIndex++, _ => CurrentIndex < numberOfWords - 1);
            PreviousWordCommand = new RelayCommand(_ => CurrentIndex--, _ => CurrentIndex > 0);
        }

        public ICommand NextWordCommand { get; set; }

        public ICommand PreviousWordCommand { get; set; }

    }
}
