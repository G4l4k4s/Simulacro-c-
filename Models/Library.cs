using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroC_.Models
{
    public class Library
    {
        public List<Vehicle> Vehicles { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Customer> Customers { get; set; }


        public Library()
        {
            Vehicles = new List<Vehicle>();
            Drivers = new List<Driver>();
            Customers = new List<Customer>();
    
        }

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }
        public void AddDriver(Driver driver)
        {
            Drivers.Add(driver);
        }
        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }
        public void DeleteVehicle(string placa)
        {
            Vehicles.RemoveAll(v => v.Placa == placa);
        }
        public void DeleteDriver(string identificationNumber)
        {
            // Drivers.RemoveAll(d => d.IdentificationNumber() == identificationNumber);
        }
        public void DeleteCustomer(string identificationNumber)
        {
            // Customers.RemoveAll(c => c.IdentificationNumber == identificationNumber);
        }
        public void UpdateVehicle(string placa, string newPlaca, int newPeopleCapacity, string newOwner)
        {
            Vehicle vehicleToUpdate = Vehicles.FirstOrDefault(v => v.Placa == placa);
            if (vehicleToUpdate != null)
            {
                vehicleToUpdate.Placa = newPlaca;
                vehicleToUpdate.PeopleCapacity = newPeopleCapacity.ToString();
                vehicleToUpdate.Owner = newOwner;
            }
    
        }
        // public void UpdateDriver(string identificationNumber, string newLicenseNumber, string newLicenseCategory, int newDrivingExperience)
        // {
        //     Driver driverToUpdate = Drivers.FirstOrDefault(d => d.IdentificationNumber == identificationNumber);
        //     if (driverToUpdate!= null)
        //     {
        //         driverToUpdate.LicenseNumber = newLicenseNumber;
        //         driverToUpdate.LicenseCategory = newLicenseCategory;
        //         driverToUpdate.DrivingExperience = newDrivingExperience;
        //     }
    
        // }
        // public void UpdateCustomer(string identificationNumber, string newMemberShipLevel, string newPrefereedPaymentMethod)
        // {
        //     Customer customerToUpdate = Customers.FirstOrDefault(c => c.IdentificationNumber == identificationNumber);
        //     if (customerToUpdate!= null)
        //     {
        //         customerToUpdate.MemberShipLevel = newMemberShipLevel;
        //         customerToUpdate.PrefereedPaymentMethod = newPrefereedPaymentMethod;
        //     }
        // }

        // public Vehicle GetVehicleByPlaca(string placa)
        // {
        //     return Vehicles.FirstOrDefault(v => v.Placa == placa);
        // }

        // public Driver GetDriverByIdentificationNumber(string identificationNumber)
        // {
        //     return Drivers.FirstOrDefault(d => d.IdentificationNumber == identificationNumber);
        // }

        // public Customer GetCustomerByIdentificationNumber(string identificationNumber)
        // {
        //     return Customers.FirstOrDefault(c => c.IdentificationNumber == identificationNumber);
        // }

        public List<Vehicle> GetVehiclesByOwner(string owner)
        {
            return Vehicles.Where(v => v.Owner == owner).ToList();
        }   

        public List<Driver> GetDriversByLicenseCategory(string licenseCategory)
        {
            return Drivers.Where(d => d.LicenseCategory == licenseCategory).ToList();
        }   
    }
}