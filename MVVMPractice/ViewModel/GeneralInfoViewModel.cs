using System;
using MVVMPractice.Model;

namespace MVVMPractice.ViewModel
{
    public class GeneralInfoViewModel
    {
        public GeneralInfoViewModel()
        {
            personalInfo = GetPersonalInfo();
        }

        private PersonalInfo personalInfo;
        public PersonalInfo PersonalInfo
        {
            get
            {
                return personalInfo;
            }
            set
            {
                personalInfo = value;
            }
        }

        private PersonalInfo GetPersonalInfo()
        {
            return new PersonalInfo
            {
                AboutMe = "All I do is balling"
            };
        }

    }
}
