using BugPage.Models;
using BugPage.Views;
using ReactiveUI;
using System;
using System.ComponentModel.DataAnnotations;

namespace BugPage.ViewModels
{
    public class RegPageViewModel : PageViewModelBase
    {
        public void Reg2() 
        {
            Reg2Available = true;
            Users.Add(new User { });
        }
        public void Confirm() 
        {
            new MainWindowViewModel().Next();
        }
        public RegPageViewModel()
        {
            this.WhenAnyValue(x => x.Email, x => x.Password).Subscribe(_ => UpdateCanReg1());
            //this.WhenAnyValue(x => x.Code)
            //    .Subscribe(_ => UpdateCanReg3());
        }
        private bool _reg1available = false;
        public bool Reg1Available
        {
            get { return _reg1available; }
            set { this.RaiseAndSetIfChanged(ref _reg1available, value); }
        }

        private bool _reg2available = false;
        public bool Reg2Available
        {
            get { return _reg2available; }
            set { this.RaiseAndSetIfChanged(ref _reg2available, value); }
        }
        private string? _code;
        [Required]
        public string? Code
        {
            get { return _code; }
            set { this.RaiseAndSetIfChanged(ref _Email, value); }
        }

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

        private bool _CanNavigateNext;
        public override bool CanNavigateNext
        {
            get { return _CanNavigateNext; }
            protected set { this.RaiseAndSetIfChanged(ref _CanNavigateNext, value); }
        }

        public override bool CanNavigatePrevious
        {
            get => false;
            protected set => throw new NotSupportedException();
        }
        private void UpdateCanReg1()
        {
            Reg1Available =
                    !string.IsNullOrEmpty(_Email)
                && _Email.Contains("@")
                && !string.IsNullOrEmpty(_Password);
        }
        //private void UpdateCanReg3()
        //{
        //    Reg1Available =
        //            !string.IsNullOrEmpty(Code);
        //}

    }
}
