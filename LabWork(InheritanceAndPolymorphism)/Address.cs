namespace LabWork_InheritanceAndPolymorphism_
{
    internal class Address
    {
        public string AddressName { get; set; }
        public string Street { get; set; }
        public string CityorTown { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }


        public Address(string name, string street, string cityOrTown, string province, string postalCode)
        {
            AddressName = name;
            Street = street;
            CityorTown = cityOrTown;
            Province = province;
            PostalCode = postalCode;
        }
    }
}
