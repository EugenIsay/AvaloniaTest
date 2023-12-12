using DynamicData;
using ReactiveUI;
using System;
using System.Windows.Input;

namespace BugPage.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            _CurrentPage = Pages[0];
            //var canNavNext = this.WhenAnyValue(x => x.CurrentPage.CanNavigateNext);
            //var canNavPrev = this.WhenAnyValue(x => x.CurrentPage.CanNavigatePrevious);

            //NavigateNextCommand = ReactiveCommand.Create(NavigateNext, canNavNext);
            //NavigatePreviousCommand = ReactiveCommand.Create(NavigatePrevious, canNavPrev);
        }
        private readonly PageViewModelBase[] Pages =
        {
            new RegPageViewModel(),
            new MainPageViewModel()
        };
        private PageViewModelBase _CurrentPage;
        public PageViewModelBase CurrentPage
        {
            get { return _CurrentPage; }
            private set { this.RaiseAndSetIfChanged(ref _CurrentPage, value); }
        }
        //public ICommand NavigateNextCommand { get; }
        //public ICommand NavigatePreviousCommand { get; }
        private void NavigateNext()
        {
            var index = Pages.IndexOf(CurrentPage) + 1;
            CurrentPage = Pages[index];
        }

        private void NavigatePrevious()
        {
            var index = Pages.IndexOf(CurrentPage) - 1;
            CurrentPage = Pages[index];
        }
        public void Next()
        {
            CurrentPage = Pages[1];
        }

    }
}