using System;
namespace MVVMPractice.Model
{
    public class PersonalInfo
    {
        public PersonalInfo()
        {
        }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public string Image { get; set; }
        public string InstagramLink { get; set; }
        public string FacebookLink { get; set; }
        public string GithubLink { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AboutMe { get; set; }
        public string[] MyFields { get; set; }
        public string[] HardSkills { get; set; }
        public string[] SoftSkills { get; set; }
        public string[] Languages { get; set; }
        public string[] Hobbies { get; set; }
        public Job[] Jobs { get; set; }
        public string[] PersolanGoals { get; set; }

    }
}
