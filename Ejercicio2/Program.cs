//Ejercicio2

double prestamo = 3000; 
int plazoMeses = 6;    
DateTime fechaActual = DateTime.Now;

Console.WriteLine($"Fecha de inicio del préstamo: {fechaActual.ToString("dd-MM-yyyy")}");
Console.WriteLine($"Monto del préstamo: {prestamo}$");
Console.WriteLine($"Plazo del préstamo: {plazoMeses} meses");
Console.WriteLine("\nFechas de pago y cuotas:");

double cuota = prestamo / plazoMeses;

for (int i = 1; i <= plazoMeses; i++)
{
    fechaActual = fechaActual.AddMonths(1);
    Console.WriteLine($"{fechaActual.ToString("dd-MM-yyyy")}: ${cuota.ToString("0.00")}");
}