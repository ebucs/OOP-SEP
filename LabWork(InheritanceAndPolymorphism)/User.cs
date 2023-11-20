using System.Text.RegularExpressions;

namespace LabWork_InheritanceAndPolymorphism_
{
    abstract class User
    {
        // Properties
        private string? FirstName;
        private string? LastName;
        private string? EmailAddress;
        private string? PhoneNumber;
        private string? IDNumber;

        // Create a collection to hold addresses
        public List<Address> Addresses { get; set; }

        // Constructor
        public User(string fName, string lastName)
        {
            FirstName = fName;
            LastName = lastName;
            // Initialize the address collection
            Addresses = new List<Address>();
        }

        // Set Methods
        public bool SetFirstName(string nameText)
        {
            return NameValidator(nameText, ref FirstName);
        }

        public bool SetSurname(string nameText)
        {
            return NameValidator(nameText, ref LastName);
        }

        private bool NameValidator(string text, ref string? val)
        {
            bool containsNumbers = Regex.IsMatch(text, @"\d");
            if (text.Length < 3 || containsNumbers)
            {
                val = null;
                return false;
            }
            val = text;
            return true;
        }


        public bool SetEmailAddress(string emailAddress)
        {
            EmailAddress = emailAddress;
            return true;
        }

        public bool SetPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber) || phoneNumber.Length != 10 || !phoneNumber.StartsWith("0"))
            {
                Console.WriteLine("Error: Phone number must be 10 digits long and start with '0'.");
                return false;
            }

            PhoneNumber = phoneNumber;
            return true;
        }

        public bool SetIDNumber(string idNumber)
        {
            if (string.IsNullOrWhiteSpace(idNumber) || idNumber.Length != 13)
            {
                Console.WriteLine("Error: ID number must be exactly 13 digits long.");
                return false;
            }

            IDNumber = idNumber;
            return true;
        }

        // Get Methods
        public string GetFirstName()
        {
            return FirstName ?? "";
        }


        public bool GetFullName(ref string? fullName)
        {
            if (FirstName != null && LastName != null)
            {
                fullName = FirstName + ' ' + LastName;
                return true;
            }
            else
            {
                fullName = null;
                return false;
            }
        }



        public string GetEmailAddress()
        {
            return EmailAddress ?? "";
        }

        public string GetPhoneNumber()
        {
            return PhoneNumber ?? "";
        }

        public string GetIDNumber()
        {
            return IDNumber ?? "";
        }

        // Abstract Method for User Validation
        public abstract bool ValidateUser();
    }


}

