using Avalonia.Controls;
using Avalonia.Interactivity;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BugPage.ViewModels
{
    public class MainPageViewModel : PageViewModelBase
    {

        private string _description = string.Empty;
        private bool _IsPaneOpen = false;
        public ReactiveCommand<Unit, Unit> PaneButton { get; }

        public bool IsPaneOpen
        {
            get { return _IsPaneOpen; }
        }
        public MainPageViewModel()
        {
            PaneButton = ReactiveCommand.Create(() => { _IsPaneOpen = !_IsPaneOpen; });
        }
        public string Description
        {
            get => _description;
            set => this.RaiseAndSetIfChanged(ref _description, value);
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
