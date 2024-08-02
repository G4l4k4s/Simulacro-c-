using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroC_.Models
{
    public class Vehicle 
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Type { get; set; }
        public string EngineNumber { get; set; }
        public string SerialNumber { get; set; }
        public int PeopleCapacity { get; set; }
        public Driver Owner { get; set; }


        public Vehicle(int id, string placa, string type, string engineNumber, string serialNumber, int peopleCapacity, Driver owner)
        {
            Id = id;
            Placa = placa;
            Type = type;
            EngineNumber = engineNumber;
            SerialNumber = serialNumber;
            PeopleCapacity = peopleCapacity;
            Owner = owner;
        }
        public void DeleteVehicle()
        {
            Console.WriteLine("Write de placa of the vehicle what you want to delete");
            var placa = Console.ReadLine();
            Library.Vehicles.RemoveAll(a => a.Placa == placa);
            Console.WriteLine($"Vehicle with placa {placa} has been deleted.");
        }

        public static Driver Qwqeq(string GetName)
        {
            return Library.Drivers.FirstOrDefault(x => x.GetIdentificationNumber() == GetName);
        }
    }
}