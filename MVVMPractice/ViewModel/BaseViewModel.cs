using System;
using System.ComponentModel;

namespace MVVMPractice.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertChanged(string item)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(item));
        }
    }
}
