using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MAUIApp.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {

        ///***Implemented by CommuntiyToolkit MVVM
        //public event PropertyChangedEventHandler? PropertyChanged;
        // protected void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
        //  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        [ObservableProperty]
        string text;

        [ICommand]
        void Add()
        {
            Text = string.Empty;
        }

    }
}
