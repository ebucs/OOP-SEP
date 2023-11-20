namespace LabWork_InheritanceAndPolymorphism_
{
    class Employer : User
    {
        private readonly string StaffNumber;
        public string Position;
        private List<IOpportunity> Opportunities;// { get; set; }

        public Employer(string staffNumber, string fName, string lastName) : base(fName, lastName)
        {
            Position = "Software Dev"; // You can set the default position here if needed.
            // Validate and set the staff number during initialization
            if (SetStaffNumber(staffNumber))
            {
                StaffNumber = staffNumber;
            }
            else
            {
                throw new ArgumentException("Invalid staff number.");
            }
            Opportunities = new List<IOpportunity>();
        }

        public IEnumerable<IOpportunity> getOpp()
        {
            return Opportunities;
        }

        public void PopulateOpportunity(IOpportunity opportunity, int opportunityIndex)
        {
            Data data = new();
            opportunity.SetCompanyName(data.companyNames[opportunityIndex]);
            opportunity.SetOpportunityDescription(data.JobDescription[opportunityIndex]);
            opportunity.SetDepartment(data.department[opportunityIndex]);
            opportunity.SetStartDate(data.startDates[opportunityIndex]);
            switch (opportunity)
            {
                case JobPost jobpost:
                    jobpost.SetRate(data.rates[opportunityIndex]);
                    break;

                case Bursary bursary:
                    bursary.SetBursaryValue(data.GenerateRandomAmount(5));
                    break;

                case Party party:
                    party.SetEntranceFee(data.GenerateRandomAmount(3));
                    break;

                default: break;
            }

            Opportunities.Add(opportunity);
        }
        

        //public IOpportunity CreateOpportunity(int opportunityIndex)
        //{
        //    Data data = new();
        //    IOpportunity newOpportunity = null;

        //    // Randomly decide the type of opportunity (Post, Bursary, or Party)
        //    int opportunityType = data.GetRandomOpportunityType();

        //    if (opportunityType == 0)
        //    {
        //        // Create a new JobPost
        //        JobPost newJobPost = new JobPost();
        //        newJobPost.SetCompanyName(data.companyNames[opportunityIndex]);
        //        newJobPost.SetOpportunityDescription(data.JobDescription[opportunityIndex]);
        //        newJobPost.SetDepartment(data.department[opportunityIndex]);
        //        newJobPost.SetStartDate(data.startDates[opportunityIndex]);
        //        newJobPost.SetRate(data.rates[opportunityIndex]);

        //        newOpportunity = newJobPost;
        //    }
        //    else if (opportunityType == 1)
        //    {
        //        // Create a new Bursary
        //        Bursary newBursary = new Bursary();
        //        newBursary.SetCompanyName(data.companyNames[opportunityIndex]);
        //        newBursary.SetOpportunityDescription(data.JobDescription[opportunityIndex]);
        //        newBursary.SetDepartment(data.department[opportunityIndex]);
        //        newBursary.SetStartDate(data.startDates[opportunityIndex]);

        //        // Use the GenerateRandomAmount method to set the BursaryValue
        //        decimal randomBursaryValue = data.GenerateRandomAmount(5);
        //        newBursary.SetBursaryValue(randomBursaryValue);

        //        newOpportunity = newBursary;
        //    }
        //    else if (opportunityType == 2)
        //    {
        //        // Create a new Party
        //        Party newParty = new Party();
        //        newParty.SetCompanyName(data.companyNames[opportunityIndex]);
        //        newParty.SetOpportunityDescription(data.JobDescription[opportunityIndex]);
        //        newParty.SetDepartment(data.department[opportunityIndex]);
        //        newParty.SetStartDate(data.startDates[opportunityIndex]);

        //        // Use the GenerateRandomAmount method to set the EntranceFee
        //        decimal randomEntranceFee = data.GenerateRandomAmount(2);
        //        newParty.SetEntranceFee(randomEntranceFee);

        //        newOpportunity = newParty;
        //    }

        //    // Add the new opportunity to the list of opportunities
        //    Opportunities.Add(newOpportunity);

        //    return newOpportunity;
        //}


        public bool SetStaffNumber(string staffNumber)
        {
            if (string.IsNullOrWhiteSpace(staffNumber) || staffNumber.Length != 8)
            {
                Console.WriteLine("Error: Staff number must be 8 digits long.");
                return false;
            }

            if (staffNumber[0] != 'A' && staffNumber[0] != 'B')
            {
                Console.WriteLine("Error: Staff number must start with 'A' or 'B'.");
                return false;
            }

            // Check if the remaining characters are digits
            for (int i = 1; i < staffNumber.Length; i++)
            {
                if (!char.IsDigit(staffNumber[i]))
                {
                    Console.WriteLine("Error: Staff number must contain only digits after the first character.");
                    return false;
                }
            }
            return true;
        }

        public string GetStaffNumber()
        {
            return StaffNumber;
        }

        public override bool ValidateUser()
        {
            Console.WriteLine("This confirms that the staff number is confirmed.");
            return true;
        }
    }

}
