
using SimulacroC_.Models;


//    ----------------------------------------------------------------
        Vehicle carro1 = new Vehicle(1,"ab2c","motorcicle","123fgh","19292",12,"juan");
        Vehicle carro2 = new Vehicle(2,"cde3","motorcycle","456ijk","19293",15,"pedro");
        Vehicle carro3 = new Vehicle(3,"efg4","motorcycle","678lmn","19294",18,"luis");

        Driver conductor1 = new Driver("juan","perez","CC","123456789",new DateOnly(1994,5,15),"conductor@gmail.com","123456","cas 222", "12312424", "a2", 3);
        Driver conductor2 = new Driver("pedro","gonzales","CC","987654321",new DateOnly(1990,10,25),"conductor@gmail.com","987654","calle 111", "12312312", "a1", 5);
        Driver conductor3 = new Driver("luis","martinez","CC","345678901",new DateOnly(1988,7,10),"conductor@gmail.com","345678","avenida 333", "12312313", "a3", 7);

        Customer cliente1 = new Customer("jose","lopez","CC","123456789",new DateOnly(1996,3,15),"cliente@gmail.com","123456","calle 333", "Gold", "efectivo");
        Customer cliente2 = new Customer("maria","garcia","CC","987654321",new DateOnly(1992,8,10),"cliente@gmail.com","987654","calle 222", "Platinum", "tarjeta credito");
        Customer cliente3 = new Customer("ana","ramirez","CC","345678901",new DateOnly(1990,4,20),"cliente@gmail.com","345678","avenida 111", "Standard", "transferencia");
//   ----------------------------------------------------------------


var While = true;

while (While)
{
    Console.Clear();
    Insterface.Header();
    Console.WriteLine("Welcome to Simulacro");
    Console.WriteLine("What you gonna do?");
    Console.WriteLine("1. Add a new Driver?");
    Console.WriteLine("2. Eliminar empleado");
    Console.WriteLine("3. Mostrar todos los empleados");
    Console.WriteLine("4. Actualizar empleado");
    Console.WriteLine("5. Buscar empleado por CC");
    Console.WriteLine("6. Mostrar empleados por cargo");
    Console.WriteLine("7. Agregar cliente");
    Console.WriteLine("8. Mostrar todos los cliente");
    Console.WriteLine("9. Eliminar clientes");

    var options = Console.ReadLine();
    switch (options.ToLower())
    {   
        case "1":
        
        default:
        break;

    }
}