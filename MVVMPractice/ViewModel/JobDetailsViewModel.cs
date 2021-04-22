using System;
using System.Collections.ObjectModel;
using MVVMPractice.Model;

namespace MVVMPractice.ViewModel
{
    public class JobDetailsViewModel : ExperienceViewModel
    {
        public JobDetailsViewModel()
        {
            GetJobIndex();

        }

        PersonalInfo jobToDisplay = new PersonalInfo();
        Job jobItem;
        


        public void GetJobIndex()
        {
            jobItem = jobToDisplay.jobs[SelectedIndex];

        }

        public Job JobItem
        {
            get
            {
                return jobItem;
            }
            set
            {
                jobItem = value;
            }
        }

       
    }
}
