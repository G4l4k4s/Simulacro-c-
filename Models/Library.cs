using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroC_.Models
{
    public static class Library
    {
        public static List<Vehicle> Vehicles { get; set; }
        public static List<Driver> Drivers { get; set; }
        public static List<Customer> Customers { get; set; }

        


        public static void AddVehicle()
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
            //
            Console.WriteLine("Write the vehicle's capacity:");
            int numero;
            if(!int.TryParse(Console.ReadLine(), out numero)){
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }
            int numerovall = Validations.ValidateCapacity(numero);

            //
            Console.WriteLine("the vehicle's people capacity identification:");
            string indent = Console.ReadLine();
            var driver = Vehicle.Qwqeq(indent);
            

            var vehicle = new Vehicle(Id, Placa, Type, EngineNumber, SerialNumber,numerovall, AddDriver());
            Vehicles.Add(vehicle);

        }
        public static Driver AddDriver()
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

            return newDriver;
        }
        public static void AddCustomer( )
        {
            Console.Clear();
            Console.WriteLine("Write the customer's name:");
            var Name = Console.ReadLine();
            Console.WriteLine("Write the customer's lastname:");
            var LastName = Console.ReadLine();
            Console.WriteLine("What is the document type of the customer?:");
            var DocumentType = Console.ReadLine();
            Console.WriteLine("Write the customer's document number:");
            var DocumentNumber = Console.ReadLine();
            Console.WriteLine("place the customer's birthtime");
            Console.WriteLine("Write the year of birth: ");
            var inputYYYY = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Write the month:");
            var inputMM = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Write the day of birth:");
            var inputDD = Convert.ToInt16(Console.ReadLine());
            var newDate = new DateOnly(inputYYYY, inputMM, inputDD);
            Console.WriteLine(" Write the   customer's  email address:");
            var Email = Console.ReadLine();
            Console.WriteLine("Write the customer's phone number:");
            var PhoneNumber = Console.ReadLine();
            Console.WriteLine("Write the customer's address:");
            var Address = Console.ReadLine();
            Console.WriteLine("Write the customer's membership level:");
            var MemberShipLevel = Console.ReadLine();
            Console.WriteLine("Write the customer's preferred payment method:");
            var PreferredPaymentMethod = Console.ReadLine();
            var newCustomer = new Customer(Name, LastName, DocumentType, DocumentNumber, newDate, Email, PhoneNumber, Address, MemberShipLevel, PreferredPaymentMethod);
            Customers.Add(newCustomer);
        }

        public static void ShowAllVehicles()
        {   

            Console.Clear();
            Console.WriteLine("Vehicles:");
            Console.WriteLine("hola mundo");
            foreach (var item in Vehicles)
            {
                Console.WriteLine($"Id: {item.Id}\n Placa: {item.Placa}\n Type: {item.Type}\n Engine Number: {item.EngineNumber}\n Serial Number: {item.SerialNumber}\n People Capacity: {item.PeopleCapacity}\n Driver: {item.Owner.GetName()}");
                Console.WriteLine();
            }
            Console.ReadKey();

        }

        public static void ShowAllDrivers()
        {
            Console.Clear();
            Console.WriteLine("Drivers:");
            foreach (var item in Drivers)
            {
                Console.WriteLine($"Name: {item.GetName()}\n Last Name: {item.GetLastName()}\n Document Type: {item.GetDocumentTipe()}\n Document Number: {item.GetIdentificationNumber()}\n Birth Date: {item.GetBirthDay()}\n Email: {item.GetEmail()}\n Phone Number: {item.GetPhoneNumber()}\n Address: {item.GetAddress()}\n License Number: {item.LicenseNumber}\n License Category: {item.LicenseCategory}\n Driving Experience: {item.DrivingExperience}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }



    }
}


