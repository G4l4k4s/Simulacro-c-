using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroC_.Models
{
    public class Customer
    {
        public string MemberShipLevel { get; set; }
        public string PrefereedPaymentMethod {get; set;}

        public Customer()
        {

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
                MemberhipLevel = "Gold";
            }
            else if (PrefereedPaymentMethod == "PayPal")
            {
                MemberhipLevel = "Platinum";
            }
            else
            {
                MemberhipLevel = "Standard";
            }
        }
    }
}