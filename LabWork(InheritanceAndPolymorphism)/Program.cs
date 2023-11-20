using LabWork_InheritanceAndPolymorphism_;
using System;
using System.Diagnostics.Metrics;

// implementation

Data data = new();

// Create a list to hold your users (students or employers)
List<User> users = new List<User>();


int AddressIndex = 0;
int opportunityIndex = 0;
Random random = new Random();
Random randomUser = new Random();

for (int i = 0; i < 20; i++)
{
    User user;
    int randomUser1 = randomUser.Next(2);

    if (randomUser1 == 0)
    {
        // Create a Student instance and set its properties
        user = new Student(data.GenerateRandomNumber(8), data.names[i], data.surnames[i]);
    }
    else
    {
        // Create an Employer instance and set its properties
        Employer employer = new Employer('A' + data.GenerateRandomNumber(7), data.names[i], data.surnames[i]);
        Random randomJobPost = new Random();
        for (int numJobpost = 0; numJobpost < randomJobPost.Next(1, 6); numJobpost++)
        {
            int opportunityType = data.GetRandomOpportunityType();
            //Employer employer = user as Employer;
            //if(user is Employer employer)
            if (opportunityType == 0)
                employer.PopulateOpportunity(new JobPost(), opportunityIndex++);
            else if (opportunityType == 1)
                employer.PopulateOpportunity(new Bursary(), opportunityIndex++);
            else if (opportunityType == 2)
                employer.PopulateOpportunity(new Party(), opportunityIndex++);
        }
        user = employer;
    }
    users.Add(user);
    user.SetEmailAddress(data.emails[i]);
    user.SetPhoneNumber(data.telephoneNumbers[i]);
    user.SetIDNumber(data.SAIDs[i]);

    // Calculate the index to use for the addresses
    int AddressNum = random.Next(1, 3);

    for (int j = 0; j < AddressNum; j++)
    {
        if (AddressIndex >= data.streetNames.Count || AddressIndex >= data.cities.Count || AddressIndex >= data.provinces.Count)
            AddressIndex = 0;

        // Create addresses for the user
        Address userAddress = new Address(i < 10 ? "Home" : "Work", data.streetNames[AddressIndex], data.cities[AddressIndex], data.provinces[AddressIndex], data.GenerateRandomNumber(4));

        // Add addresses to the user's Addresses collection
        user.Addresses.Add(userAddress);
        AddressIndex++;
    }
}



// Print the user names, surnames, and addresses
foreach (var user in users)
{
    string fullName = null;
    bool result = user.GetFullName(ref fullName);
    if (result)
        Console.WriteLine($"Name: {fullName}");
    if (user is Student student)
    {
        Console.WriteLine($"Student Number: {student.GetStudentNumber()}");
    }
    else if(user is Employer employer)
    {
        Console.WriteLine($"Staff Number: {employer.GetStaffNumber()}");
    }
    foreach (var address in user.Addresses)
    {
        Console.WriteLine($"  Address: {address.AddressName}, {address.Street}, {address.CityorTown}, {address.Province}, {address.PostalCode}");
        Console.WriteLine(" ");
    }
}

//print the student and jobposts they consume
foreach (var user in users)
{
    if (user is Employer employer)
    {
        foreach (var pst in employer.getOpp())
        {
            foreach (var user1 in users)
            {
                if (user1 is Student student)
                    student.ConsumeOpportunities(pst);
            }
        }
    }
}

















