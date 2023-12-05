using Avalonia;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace BugPage.ViewModels
{
    public class RegPageViewModel : PageViewModelBase 
    { 


        private string? _Email;
        [Required]
        [EmailAddress]
        public string? Email
        {
            get { return _Email; }
            set { this.RaiseAndSetIfChanged(ref _Email, value); }
        }
        private string? _Password;
        [Required]
        public string? Password
        {
            get { return _Password; }
            set { this.RaiseAndSetIfChanged(ref _Password, value); }
        }
        public override bool CanNavigateNext
        {
            get => true;
            protected set => throw new NotSupportedException();
        }
        public override bool CanNavigatePrevious
        {
            get => false;
            protected set => throw new NotSupportedException();
        }
    }

}
