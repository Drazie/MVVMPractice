using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MVVMPractice.Model;

namespace MVVMPractice.ViewModel
{
    public class NotifyPropertyChanged : INotifyPropertyChanged
    {
        public NotifyPropertyChanged()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyChanged = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyChanged));
        }
    }
}
