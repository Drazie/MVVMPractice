using System;
using System.Collections.ObjectModel;
using MVVMPractice.Model;
using MVVMPractice.View;
using Xamarin.Forms;

namespace MVVMPractice.ViewModel
{
    public class ExperienceViewModel : NotifyPropertyChanged
    {
        public ExperienceViewModel()
        {
            Experience = GetExperience();
        }

        PersonalInfo previousJobs = new PersonalInfo();


        ObservableCollection<Job> experience;
        public ObservableCollection<Job> Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }

        public ObservableCollection<Job> result = new ObservableCollection<Job>();
        private ObservableCollection<Job> GetExperience()
        {
            var experience = previousJobs.jobs;
            
            foreach (Job e in experience)
            {
                result.Add(e);
            }

            return result;
        }

        Job selectedJob;
        public Job SelectedJob
        {
            get
            {
                return selectedJob;
            }
            set
            {
                selectedJob = value; 
                OnPropertyChanged();
            }
        }

        public Command JobSelectionCommand => new Command(GetJobDetails);
        int selectedIndex;
        public int SelectedIndex
        {
            get
            {
                return selectedIndex;
            }
            set
            {
                selectedIndex = value;
                OnPropertyChanged();
            }
        }
        

        private void GetJobDetails()
        {
            //int i = result.IndexOf(selectedJob);            //capturing the index of the job selected
            //selectedIndex = i;
            var navigation = Application.Current.MainPage as NavigationPage;          
                                                                                        //how to navigate 
            if (selectedJob != null)
            {
                selectedIndex = result.IndexOf(selectedJob);
                var viewModel = new JobDetailsViewModel();
                var page = new JobDetailsPage { BindingContext = viewModel };
                SelectedJob = null;
                navigation.PushAsync(page, true);
            }
        }

    }
}
