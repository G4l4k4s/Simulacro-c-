using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroC_.Models
{
    public class User
    {
        protected Guid userId;
        protected string? Name {get; set;}
        protected string? LastName {get; set;}
        protected string? TipeDocument {get; set;}
        protected string? IdentificationNumber {get; set;}
        protected DateTime DateOfBirth {get; set;}
        protected string? Email {get; set;}
        protected string? PhoneNumber {get; set;}
        protected string? Address {get; set;}
        
        
        protected User(string name, string lastName, string tipeDocument, string identificationNumber, DateTime dateOfBirth, string email, string phoneNumber, string address)
        {
            userId = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            TipeDocument = tipeDocument;
            IdentificationNumber = identificationNumber;
            DateOfBirth = dateOfBirth;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        protected virtual string ShowDetails()
        {
            return $"{Name} {LastName}";
        }

        protected virtual int CalculateAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }

        protected virtual int ShowAge()
        {
            return CalculateAge();
        }
    }
}