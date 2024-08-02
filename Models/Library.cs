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




        public void AddVehicle()
        {
            Console.Clear();
            Console.WriteLine("Write the vehicle's Id:");
            var Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the vehicle's placa:");
            var Placa = Console.ReadLine();
            Console.WriteLine("Wrote the vehicle's tipe:");
            var Type = Console.ReadLine();
            Console.WriteLine("Write the vehicle's engine number:");
            var EngineNumber = Console.ReadLine();
            Console.WriteLine("Write the vehicle's serial number:");
            var SerialNumber = Console.ReadLine();
            Console.WriteLine("Write the vehicle's people capacity id:");
            var PeopleCapacity = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("the vehicle's people capacity id:");
            Console.WriteLine("Write the vehicle's owner:");
            var Owner = Console.ReadLine();
            var vehicle = new Vehicle(Id, Placa, Type, EngineNumber, SerialNumber, PeopleCapacity, Owner);
            Vehicles.Add(vehicle);

        }
        public void AddDriver()
        {
            Console.Clear();
            Console.WriteLine("Write the driver's name:");
            var Name = Console.ReadLine();
            Console.WriteLine("Write the driver's lastname:");
            var LastName = Console.ReadLine();
            Console.WriteLine("What is the document type of the driver?:");
            var DocumentType = Console.ReadLine();
            Console.WriteLine("Write the driver's document number:");
            var DocumentNumber = Console.ReadLine();
            Console.WriteLine("place the driver's birthtime");
            Console.WriteLine("Write the year of birth: ");
            var inputYYYY = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Write the month:");
            var inputMM = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Write the day of birth:");
            var inputDD = Convert.ToInt16(Console.ReadLine());
            var newDate = new DateOnly(inputYYYY, inputMM, inputDD);
            Console.WriteLine("Write the driver's email:");
            var Email = Console.ReadLine();
            Console.WriteLine("Write the driver's phone number:");
            var PhoneNumber = Console.ReadLine();
            Console.WriteLine("Write the driver's address:");
            var Address = Console.ReadLine();
            Console.WriteLine("Write the driver's License number:");
            var LicenseNumber = Console.ReadLine();
            Console.WriteLine("Write the driver's License category:");
            var LicenseCategory = Console.ReadLine();
            Console.WriteLine("Write the driver's Driving experience:");
            var DrivingExperience = Convert.ToInt32(Console.ReadLine());
            var newDriver = new Driver(Name, LastName, DocumentType, DocumentNumber, newDate, Email, PhoneNumber, Address, LicenseNumber, LicenseCategory, DrivingExperience);
            Drivers.Add(newDriver);
        }
        // public void AddCustomer(Customer customer)
        // {
        //     Customers.Add(customer);
        // }
        // public void DeleteVehicle(string placa)
        // {
        //     Vehicles.RemoveAll(v => v.Placa == placa);
        // }
        // public void DeleteDriver(string identificationNumber)
        // {
        //     // Drivers.RemoveAll(d => d.IdentificationNumber() == identificationNumber);
        // }
        // public void DeleteCustomer(string identificationNumber)
        // {
        //     // Customers.RemoveAll(c => c.IdentificationNumber == identificationNumber);
        // }
        // public void UpdateVehicle(string placa, string newPlaca, int newPeopleCapacity, string newOwner)
        // {
        //     // Vehicle vehicleToUpdate = Vehicles.FirstOrDefault(v => v.Placa == placa);
        //     // if (vehicleToUpdate != null)
        //     // {
        //     //     vehicleToUpdate.Placa = newPlaca;
        //     //     vehicleToUpdate.PeopleCapacity = newPeopleCapacity.ToString();
        //     //     vehicleToUpdate.Owner = newOwner;
        //     // }

        // }
        // public void UpdateDriver(string identificationNumber, string newLicenseNumber, string newLicenseCategory, int newDrivingExperience)
        // {
        //     Driver driverToUpdate = Drivers.FirstOrDefault(d => d.IdentificationNumber == identificationNumber);
        //     if (driverToUpdate != null)
        //     {
        //         driverToUpdate.LicenseNumber = newLicenseNumber;
        //         driverToUpdate.LicenseCategory = newLicenseCategory;
        //         driverToUpdate.DrivingExperience = newDrivingExperience;
        //     }

        // }
        // public void UpdateCustomer(string identificationNumber, string newMemberShipLevel, string newPrefereedPaymentMethod)
        // {
        //     Customer customerToUpdate = Customers.FirstOrDefault(c => c.IdentificationNumber == identificationNumber);
        //     if (customerToUpdate != null)
        //     {
        //         customerToUpdate.MemberShipLevel = newMemberShipLevel;
        //         customerToUpdate.PrefereedPaymentMethod = newPrefereedPaymentMethod;
        //     }
        // }

    //     public Vehicle GetVehicleByPlaca(string placa)
    //     {
    //         return Vehicles.FirstOrDefault(v => v.Placa == placa);
    //     }

    //     // public Driver GetDriverByIdentificationNumber(string identificationNumber)
    //     // {
    //     //     return Drivers.FirstOrDefault(d => d.IdentificationNumber == identificationNumber);
    //     // }

    //     // public Customer GetCustomerByIdentificationNumber(string identificationNumber)
    //     // {
    //     //     return Customers.FirstOrDefault(c => c.IdentificationNumber == identificationNumber);
    //     // }
    //     public List<Vehicle> GetVehiclesByOwner(string owner)
    //     {
    //         return Vehicles.Where(v => v.Owner == owner).ToList();
    //     }

    //     public List<Driver> GetDriversByLicenseCategory(string licenseCategory)
    //     {
    //         return Drivers.Where(d => d.LicenseCategory == licenseCategory).ToList();
    //     }
    }
}


