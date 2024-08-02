
using SimulacroC_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



Library.Customers = new List<Customer>();
Library.Drivers = new List<Driver>();
Library.Vehicles = new List<Vehicle>();
//    ----------------------------------------------------------------

    Driver driver1 = new Driver("juan", "perez", "CC", "123456789", new DateOnly(1994, 5, 15), "conductor@gmail.com", "123456", "cas 222", "12312424", "a2", 3);
    Driver driver2 = new Driver("pedro", "gonzales", "CC", "987654321", new DateOnly(1990, 10, 25), "conductor@gmail.com", "987654", "calle 111", "12312312", "a1", 5);
    Driver driver3 = new Driver("luis", "martinez", "CC", "345678901", new DateOnly(1988, 7, 10), "conductor@gmail.com", "345678", "avenida 333", "12312313", "a3", 7);

    Library.Drivers.Add(driver1);
    Library.Drivers.Add(driver2);
    Library.Drivers.Add(driver3);
    //    ----------------------------------------------------------------

    Customer customer1 = new Customer("jose", "lopez", "CC", "123456789", new DateOnly(1996, 3, 15), "cliente@gmail.com", "123456", "calle 333", "Gold", "efectivo");
    Customer customer2 = new Customer("maria", "garcia", "CC", "987654321", new DateOnly(1992, 8, 10), "cliente@gmail.com", "987654", "calle 222", "Platinum", "Credit Card ");
    Customer customer3 = new Customer("ana", "ramirez", "CC", "345678901", new DateOnly(1990, 4, 20), "cliente@gmail.com", "345678", "avenida 111", "Standard", "transferencia");

    Library.Customers.Add(customer1);
    Library.Customers.Add(customer2);
    Library.Customers.Add(customer3);   
    //   ----------------------------------------------------------------
    //   ----------------------------------------------------------------
    Vehicle vehicle1 = new Vehicle(1, "ab2c", "motorcicle", "123fgh", "19292", 12, driver1);
    Vehicle vehicle2 = new Vehicle(2, "cde3", "motorcycle", "456ijk", "19293", 15, driver2);
    Vehicle vehicle3 = new Vehicle(3, "efg4", "motorcycle", "678lmn", "19294", 18, driver3);
    Library.Vehicles.Add(vehicle1);
    Library.Vehicles.Add(vehicle2);
    Library.Vehicles.Add(vehicle3);
    //   ----------------------------------------------------------------



    var While = true;

while (While)
{
    Console.Clear();
    Insterface.Header();
    Console.WriteLine("Welcome to Simulacro");
    Console.WriteLine("What you gonna do?");
    Console.WriteLine("1. Show vehicle List");
    Console.WriteLine("2. show driver List");
    Console.WriteLine("3. create new driver");
    Console.WriteLine("4. create new vehicle");

    var options = Console.ReadLine();
    switch (options.ToLower())
    {   
        case "1":
            Library.ShowAllVehicles();
            Console.ReadKey();
            break;
        case "2":
            Library.ShowAllDrivers();
            Console.ReadKey();
            break;
        case "3":
            Library.AddDriver();
            break;
        case "4":
            Library.AddVehicle();
            break;

        
        default:
        break;

    }
}

