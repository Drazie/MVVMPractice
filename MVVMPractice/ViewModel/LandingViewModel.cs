using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MVVMPractice.Model;
using MVVMPractice.View;
using Xamarin.Forms;

namespace MVVMPractice.ViewModel
{
    public class LandingViewModel
    {
        public LandingViewModel()
        {
            Sections = GetMainSections();
        }

        ObservableCollection<MainSection> sections;
        public ObservableCollection<MainSection> Sections
        {
            get
            {
                return sections;
            }
            set
            {
                sections = value;
            }
        }

        private MainSection selectedSection;
        public MainSection SelectedSection
        {
            get
            {
                return selectedSection;
            }
            set
            {
                selectedSection = value;
            }
        }

        public Command SelectionCommand => new Command(DisplaySection);

        private void DisplaySection()
        {
            if(selectedSection != null)
            {
                var viewModel = new SectionViewModel();
                var sectionPage = new SectionPage();

                var navigation = Application.Current.MainPage as NavigationPage;
                navigation.PushAsync(sectionPage, true);
            }
        }

        private ObservableCollection<MainSection> GetMainSections()
        {
            return new ObservableCollection<MainSection>
            {
                new MainSection{ SectionName = "General" },
                new MainSection{ SectionName = "Projects" },
                new MainSection{ SectionName = "Skills" },
                new MainSection{ SectionName = "Experience" },
                new MainSection{ SectionName = "Goals" },
                new MainSection{ SectionName = "Contact" }
            };
        }
    }
}
