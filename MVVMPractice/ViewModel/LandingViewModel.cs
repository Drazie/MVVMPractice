using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MVVMPractice.Model;
using MVVMPractice.View;
using Xamarin.Forms;

namespace MVVMPractice.ViewModel
{
    public class LandingViewModel : NotifyPropertyChanged
    {
        public LandingViewModel()
        {
            
            Sections = GetMainSections();
            SelectedSection = null;
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
                OnPropertyChanged();
            }
        }

        MainSection aboutMe = new MainSection { SectionName = "About Me" };
        MainSection projects = new MainSection { SectionName = "Projects" };
        MainSection skills = new MainSection { SectionName = "Skills" };
        MainSection experience = new MainSection { SectionName = "Experience" };
        MainSection goals = new MainSection { SectionName = "Goals" };
        MainSection contact = new MainSection { SectionName = "Contact" };


        

        public Command SelectionCommand => new Command(DisplaySection);
        
        private void DisplaySection()
        {
            if(selectedSection != null)
            {
                NavigateFromLandingPage(selectedSection);
            }
            
        }

        private ObservableCollection<MainSection> GetMainSections()
        {

            return new ObservableCollection<MainSection>
            {
                aboutMe, projects, skills, experience, goals, contact
                /*
                new MainSection{ SectionName = "General" },
                new MainSection{ SectionName = "Projects" },
                new MainSection{ SectionName = "Skills" },
                new MainSection{ SectionName = "Experience" },
                new MainSection{ SectionName = "Goals" },
                new MainSection{ SectionName = "Contact" }
                */
            };
        }

        private void NavigateFromLandingPage(MainSection chosenSection)   // figuring out what section was pressed 
        {                                                                 // and navigating it + resetting the selectedSection
            MainSection section = chosenSection;
            var navigation = Application.Current.MainPage as NavigationPage;
            switch (section.SectionName)
            {
                case "About Me":
                    var aboutMeViewModel = new AboutMeViewModel();
                    var aboutMePage = new AboutMe { BindingContext = aboutMeViewModel };
                    SelectedSection = null;
                    navigation.PushAsync(aboutMePage, true);
                    break;
                case "Projects":
                    var projectsViewModel = new ProjectsViewModel();
                    var projectsPage = new ProjectsPage { BindingContext = projectsViewModel };
                    SelectedSection = null;
                    navigation.PushAsync(projectsPage, true);
                    break;
                case "Skills":
                    var skillsViewModel = new SkillsViewModel();
                    var skillsPage = new SkillsPage { BindingContext = skillsViewModel };
                    SelectedSection = null;
                    navigation.PushAsync(skillsPage, true);
                    break;
                case "Experience":
                    var experienceViewModel = new ExperienceViewModel();
                    var experiencePage = new ExperiencePage { BindingContext = experienceViewModel };
                    SelectedSection = null;
                    navigation.PushAsync(experiencePage, true);
                    break;
                case "Goals":
                    var goalsViewModel = new GoalsViewModel();
                    var goalsPage = new GoalsPage { BindingContext = goalsViewModel };
                    SelectedSection = null;
                    navigation.PushAsync(goalsPage, true);
                    break;
                case "Contact":
                    var contactViewModel = new ContactViewModel();
                    var contactPage = new ContactPage { BindingContext = contactViewModel };
                    SelectedSection = null;
                    navigation.PushAsync(contactPage, true);
                    break;
            }

            //var viewModel = new GeneralInfoViewModel();
            //var sectionPage = new GeneralInfoPage { BindingContext = viewModel };
            //SelectedSection = null;

            //var navigation = Application.Current.MainPage as NavigationPage;
            //navigation.PushAsync(sectionPage, true);
        }
    }
}
