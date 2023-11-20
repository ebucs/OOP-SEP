using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_InheritanceAndPolymorphism_
{
    class JobPost : IOpportunity
    {
        private string CompanyName;
        private string jobDescription;
        private string department;
        private DateOnly startDate;
        private string rate;

        public string GetCompanyName()
        {
            return CompanyName;
        }

        public void SetCompanyName(string value)
        {
            CompanyName = value;
        }

        public string GetOpportunityDescription()
        {
            return jobDescription;
        }

        public void SetOpportunityDescription(string value)
        {
            jobDescription = value;
        }

        public string GetDepartment()
        {
            return department;
        }

        public void SetDepartment(string value)
        {
            department = value;
        }

        public DateOnly GetStartDate()
        {
            return startDate;
        }

        public void SetStartDate(DateOnly value)
        {
            startDate = value;
        }

        public string GetRate()
        {
            return rate;
        }

        public void SetRate(string value)
        {
            rate = value;
        }
    }
}
