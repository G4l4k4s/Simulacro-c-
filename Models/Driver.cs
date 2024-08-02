using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SimulacroC_.Models
{
    public class Driver : User
    {
        public string LicenseNumber { get; set; }
        public string LicenseCategory { get; set; } 
        public int DrivingExperience { get; set; }

        public Driver(string name, string lastName, string tipeDocument, string identificationNumber, DateOnly dateOfBirth, string email, string phoneNumber, string address, string licenseNumber, string licenseCategory, int drivingExperience) : base(name, lastName, tipeDocument, identificationNumber, dateOfBirth, email, phoneNumber, address)
        {
            LicenseNumber = licenseNumber;
            LicenseCategory = licenseCategory;
            DrivingExperience = drivingExperience;
        }

        public void UpdateLicenseCategory(String newCategory)
        {
            // Update license category based on driving experience
            // Example: Implement a rule-based system or machine learning algorithm
            // to determine the most suitable license category for the driver
            // and update the LicenseCategory property accordingly
            // ...
            // Implement your license category logic here
            // ...
            // Example:

            if (DrivingExperience >= 10)
            {
                LicenseCategory = "Class A";
            }
            else if (DrivingExperience >= 5)
            {
                LicenseCategory = "Class B";
            }
        }

        public void AddExperience(int years)
        {

        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void GetName()
        {
            Name = Name.ToLower();
            Console.WriteLine(Name);

        }

        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }

        public void GetLastName()
        {
            LastName = LastName.ToUpper();
            Console.WriteLine(LastName);
        }

        public void SetIdentificationNumber(string identificationNumber)
        {
            IdentificationNumber = identificationNumber;
        }

        public void GetIdentificationNumber()
        {
            var identifier = IdentificationNumber;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public void GetEmail()
        {
            Console.WriteLine(Email);
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        public void GetPhoneNumber()
        {
            Console.WriteLine(PhoneNumber);
        }

        public void SetAddress(string address)
        {
            Address = address;
        }   

        public void GetAddress()
        {
            Console.WriteLine(Address);
        }






    }
}