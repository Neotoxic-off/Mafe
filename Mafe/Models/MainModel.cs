using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafe.Models
{
    public partial class MainModel : ObservableObject
    {
        public enum States
        {
            Stopped,
            Running
        }

        [ObservableProperty]
        private States _state;

        [ObservableProperty]
        private string? _stateMessage;
    }
}
