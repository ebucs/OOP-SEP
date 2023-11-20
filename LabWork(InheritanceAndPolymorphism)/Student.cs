namespace LabWork_InheritanceAndPolymorphism_
{
    class Student : User
    {
        private readonly string StudentNumber;
        private double Average;

        public Student(string studentNumber, string fName, string lastName) : base(fName, lastName)
        {
            Average = 0.0; // Initialize the average when setting the student number.

            // Validate and set the student number during initialization
            if (SetStudentNumber(studentNumber))
            {
                StudentNumber = studentNumber;
            }
            else
            {
                throw new ArgumentException("Invalid student number.");
            }
        }

        public void ConsumeOpportunities(IOpportunity opportunities)
        {
            string fullName = null;
            bool result = GetFullName(ref fullName);

            if (result)
            {
               // Console.WriteLine(" ");
                Console.WriteLine("\nStudent Name: " + fullName);
                Console.WriteLine("--------------------------");
            }
            else
            {
                Console.WriteLine("Full Name is not available.");
            }

            Console.WriteLine("Opportunity:\n");

            Console.WriteLine("Company Name: " + opportunities.GetCompanyName());
            Console.WriteLine("Opportunity Description: " + opportunities.GetOpportunityDescription());
            Console.WriteLine("Department: " + opportunities.GetDepartment());
            Console.WriteLine("Start Date: " + opportunities.GetStartDate().ToShortDateString());

            // Check the type of opportunity and display additional information accordingly
            if (opportunities is JobPost jobPost)
            {
                Console.WriteLine("Opportunity Type: Job Post");
                Console.WriteLine("Rate: " + jobPost.GetRate());
            }
            else if (opportunities is Bursary bursary)
            {
                Console.WriteLine("Opportunity Type: Bursary");
                Console.WriteLine("Bursary Value: " + bursary.GetBursaryValue());
            }
            else if (opportunities is Party party)
            {
                Console.WriteLine("Opportunity Type: Party");
                Console.WriteLine("Entrance Fee: " + party.GetEntranceFee());
            }

            Console.WriteLine();    
        }


        public bool SetStudentNumber(string studentNumber)
        {
            string studentNumberStr = studentNumber;

            if (studentNumberStr.Length != 8)
            {
                Console.WriteLine("Error: Student number must be 8 digits long.");
                return false;
            }

            // Check if the student number contains only digits
            foreach (char c in studentNumberStr)
            {
                if (!char.IsDigit(c))
                {
                    Console.WriteLine("Error: Student number must contain only digits.");
                    return false;
                }
            }
            return true;
        }

        public string GetStudentNumber()
        {
            return StudentNumber;
        }

        public override bool ValidateUser()
        {
            Console.WriteLine("This confirms that the student number is confirmed.");
            return true;
        }

    }

}
