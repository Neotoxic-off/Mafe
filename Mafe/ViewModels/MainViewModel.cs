using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace Mafe.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private Models.MainModel _mainModel = new Models.MainModel()
        {
            State = Models.MainModel.States.Stopped,
            StateMessage = "Start"
        };

        [RelayCommand]
        private void StateHandler()
        {
            Dictionary<Models.MainModel.States, (Models.MainModel.States, string)> bind = new Dictionary<Models.MainModel.States, (Models.MainModel.States, string)>()
            {
                { Models.MainModel.States.Running, (Models.MainModel.States.Stopped, "Start") },
                { Models.MainModel.States.Stopped, (Models.MainModel.States.Running, "Stop") }
            };
            (Models.MainModel.States, string) result = bind[MainModel.State];

            MainModel.State = result.Item1;
            MainModel.StateMessage = result.Item2;
        }
    }
}
