using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_InheritanceAndPolymorphism_
{
    internal interface IOpportunity
    {
        string GetCompanyName();
        void SetCompanyName(string value);
        string GetOpportunityDescription();
        void SetOpportunityDescription(string value);
        string GetDepartment();
        void SetDepartment(string value);
        DateOnly GetStartDate();
        void SetStartDate(DateOnly value);
    }
}
