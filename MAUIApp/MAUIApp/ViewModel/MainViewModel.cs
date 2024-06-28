using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MAUIApp.ViewModel
{
    //Utilizes CommuntiyToolkit MVVM
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }
        
        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        //[ICommand]
        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrEmpty(Text)) return;
            //Add Item
            Items.Add(text);
            Text = string.Empty;
        }

    }
}
