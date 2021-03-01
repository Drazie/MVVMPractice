using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MVVMPractice.ViewModel
{
    public class LandingViewModel
    {
        public LandingViewModel()
        {
        }
        ObservableCollection<Button> buttons;
        public ObservableCollection<Button> Buttons
        {
            get
            {
                return buttons;
            }
            set
            {
                buttons = value;
                
            }
        }
    }
}
