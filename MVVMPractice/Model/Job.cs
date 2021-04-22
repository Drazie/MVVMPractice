using System;
namespace MVVMPractice.Model
{
    public class Job
    {
        public Job()
        {
        }

        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Responsibilities { get; set; }
        public bool isCurrentlyWorking { get; set; }
    }
}
