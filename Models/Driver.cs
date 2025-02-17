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

        public void UpdateLicenseCategory()
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

        public void AddExperience()
        {
            // Add experience to the driver's driving experience
            // Example: Implement a rule-based system or machine learning algorithm
            // to determine the additional experience the driver should receive
            // and update the DrivingExperience property accordingly
            // ...
            // Implement your experience logic here
            // ...
            // Example:

            DrivingExperience += 1;
            UpdateLicenseCategory();
            Console.WriteLine($"Driver {Name} {LastName} has been updated. Driving experience: {DrivingExperience}");
            Console.WriteLine($"License Category: {LicenseCategory}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return base.NameReturned();
        }

        public string SetLastName(string lastName)
        {
            return base.LastNameReturned();
        }

        public string GetDocumentTipe()
        {
            return base.typeDocumentReturned();
        }

        public string GetLastName()
        {
            return base.LastNameReturned();
        }

        public DateOnly GetBirthDay()
        {
            return base.dateOfBirth();
        }

        public void SetIdentificationNumber(string identificationNumber)
        {
            IdentificationNumber = identificationNumber;
        }

        public string GetIdentificationNumber()
        {
            return base.numeroDocumento();
        }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public string GetEmail()
        {
            return base.EmailReturned();
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        public string GetPhoneNumber()
        {
            return base.PhoneNumberReturned();
        }

        public void SetAddress(string address)
        {
            Address = address;
        }   

        public string GetAddress()
        {
            return base.AdreessReturned();
        }
    }
}