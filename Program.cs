using Tarea_Automovil;

class Program
{
    static void Main()
    {
        Vehiculo automovil = new Automovil("Toyota", "Corolla", 2022, 4);
        Vehiculo camioneta = new Camioneta("Ford", "Ranger", 2021, 1000);

        Console.WriteLine("Información del Automóvil:");
        Console.WriteLine(automovil.GetInformation());
        automovil.RunAction();

        Console.WriteLine("\nInformación de la Camioneta:");
        Console.WriteLine(camioneta.GetInformation());
        camioneta.RunAction();
    }
}
