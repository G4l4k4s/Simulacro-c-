using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroC_.Models
{
    public class Customer : User
    {
        public string MemberShipLevel { get; set; }
        public string PrefereedPaymentMethod { get; set; }

        public Customer(string name, string lastName, string tipeDocument, string identificationNumber, DateOnly dateOfBirth, string email, string phoneNumber, string address, string memberShipLevel, string prefereedPaymentMethod) : base(name, lastName, tipeDocument, identificationNumber, dateOfBirth, email, phoneNumber, address)
        {
            MemberShipLevel = memberShipLevel;
            PrefereedPaymentMethod = prefereedPaymentMethod;
        }

        public void UpdateMembershipLevel()
        {
            // Update membership level based on customer behavior and preferences
            // Example: Implement a rule-based system or machine learning algorithm
            // to determine the most suitable membership level for the customer
            // and update the MemberhipLevel property accordingly
            // ...
            // Implement your membership level logic here
            // ...
            // Example:
            if (PrefereedPaymentMethod == "Credit Card")
            {
                MemberShipLevel = "Gold";
            }
            else if (PrefereedPaymentMethod == "PayPal")
            {
                MemberShipLevel = "Platinum";
            }
            else
            {
                MemberShipLevel = "Standard";
            }
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void GetName()
        {
            Name = Name.ToUpper();
            Console.WriteLine(Name);
        }

        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }

        public void GetLastName()
        {
            LastName = LastName.ToLower();
            Console.WriteLine(LastName);
        }

        public void SetIdentificationNumber(string identificationNumber)
        {
            IdentificationNumber = identificationNumber;
        }

        public void GetIdentificationNumber()
        {
            Console.WriteLine(IdentificationNumber);
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