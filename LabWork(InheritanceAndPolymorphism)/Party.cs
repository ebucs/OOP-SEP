using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_InheritanceAndPolymorphism_
{
    class Party : IOpportunity
    {
        private string CompanyName;
        private string partyDescription;
        private string department;
        private DateOnly startDate;
        private decimal EntranceFee;


        public Party()
        {
            Data data = new Data();
            EntranceFee = data.GenerateRandomAmount(5);
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
            return partyDescription;
        }

        public void SetOpportunityDescription(string value)
        {
            partyDescription = value;
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

        public decimal GetEntranceFee()
        {
            return EntranceFee;
        }

        public void SetEntranceFee(decimal value)
        {
            EntranceFee = value;
        }
    }
}
