using BugPage.Models;
using ReactiveUI;
using System.Collections.Generic;

namespace BugPage.ViewModels
{
    public class ViewModelBase : ReactiveObject
    {
        public List<User> Users = new List<User>();
    }
}