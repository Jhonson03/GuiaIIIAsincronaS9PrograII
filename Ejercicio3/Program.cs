//Ejercicio 3


Console.Write("Por favor, ingrese su fecha de cumpleaños (DD-MM): ");
if (DateTime.TryParse(Console.ReadLine(), out DateTime FechaCumple))
{
    DateTime FechaActual = DateTime.Today;

    if (FechaCumple < FechaActual)
    {
        FechaCumple = FechaCumple.AddYears(1);
    }

    TimeSpan TiempoRes = FechaCumple - FechaActual;

    Console.WriteLine($"Su próximo cumpleaños es el {FechaCumple.ToString("dd-MM-yyyy")}.");

    Console.WriteLine($"Faltan {TiempoRes.Days} días hasta su próximo cumpleaños.");
}
else
{
    Console.WriteLine("Fecha ingresada no válida. Por favor, utilice el formato DD-MM.");
}