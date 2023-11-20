using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_InheritanceAndPolymorphism_
{
    class Bursary : IOpportunity
    {
        private string CompanyName;
        private string bursaryDescription;
        private string department;
        private DateOnly startDate;
        private decimal BursaryValue;


        public Bursary()
        {
            Data data = new Data();
            BursaryValue = data.GenerateRandomAmount(2);
        }


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
            return bursaryDescription;
        }

        public void SetOpportunityDescription(string value)
        {
            bursaryDescription = value;
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

        public decimal GetBursaryValue()
        {
            return BursaryValue;
        }

        public void SetBursaryValue(decimal value)
        {
            BursaryValue = value;
        }
    }
}
