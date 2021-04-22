using System;
namespace MVVMPractice.Model
{
    public class PersonalInfo
    {
        public PersonalInfo()
        {
        }
        public string firstName = "Kostya";
        public string secondName = "Didenko";
        public int age = 21;
        public string profileImage { get; set; }
        public string instagramLink = "https://www.instagram.com/didenkostya/";
        public string facebookLink = "https://www.facebook.com/kostya.didenko.9/";
        public string githubLink = "https://github.com/Drazie";
        public string phoneNumber = "+380673274321";
        public string email = "front.kd19@gmail.com";
        public string aboutMe = "";
        public string[] myFields = { ".Net", "C#", "Xamarin", "JavaScript", "SQL" };
        public string[] hardSkills = { "" };
        public string[] softSkills = { "" };
        public string[] languages = { "English", "Ukrainian", "Russian", "Chinese" };
        public string[] hobbies = { "Basketball", "Calligraphy", "E-Skate" };
        public Job[] jobs =
        {
            new Job
            {
                JobTitle = "Support Engineer",
                CompanyName = "Perimeter81",
                StartDate = new DateTime(2020, 12, 30 ),   //yy, mm, dd
                EndDate = new DateTime(2021, 05, 30 ),
                isCurrentlyWorking = true,
                Responsibilities = "My main responsibility was to resolve the users inquiries on the networking issues with vpn platoform"
            },
            new Job
            {
                JobTitle = "Support Manager",
                CompanyName = "MacPaw",
                StartDate = new DateTime(2020, 06, 20 ),
                EndDate = new DateTime(2020, 12, 25 ),
                isCurrentlyWorking = false,
                Responsibilities = "Resolving users inquiries on the MacPaw apps, like CleanMyMac X, Gemini and others."
            },
            new Job
            {
                JobTitle = "Project Manager",
                CompanyName = "ATOM",
                StartDate = new DateTime(2018, 11, 20 ),    //yy, mm, dd
                EndDate = new DateTime(2020, 03, 10 ),
                isCurrentlyWorking = false,
                Responsibilities = "Building the roadmap for the project of the offline University in Kyiv. " +
                "With the team we were arranging numerous events for graduates and IT specialists. " +
                "I was also helping creating the Programmer course for the ATOM students alongside the professionals"
            },
            new Job
            {
                JobTitle = "Copywriter",
                CompanyName = "Evopaper",
                StartDate = new DateTime(2017, 08, 1 ),
                EndDate = new DateTime(2019, 02, 03 ),
                isCurrentlyWorking = false,
                Responsibilities = "Creating texts for the product adds, managing the product blog page, creating selling texts for the " +
                "SlicePlanner Kickstarter campaign."
            }
        };


        /*
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
        */


    }

}
