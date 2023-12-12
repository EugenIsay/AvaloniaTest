using ReactiveUI;
using System;

namespace BugPage.ViewModels
{
    public class MainPageViewModel : PageViewModelBase
    {
        public void PaneButton()
        {
            IsPaneOpen = !IsPaneOpen;
        }
        private bool _IsPaneOpen = false;
        public bool IsPaneOpen
        {
            get { return _IsPaneOpen; }
            set { this.RaiseAndSetIfChanged(ref _IsPaneOpen, value); }
        }
        public override bool CanNavigateNext
        {
            get => false;
            protected set => throw new NotSupportedException();
        }
        public override bool CanNavigatePrevious
        {
            get => true;
            protected set => throw new NotSupportedException();
        }
    }
}
