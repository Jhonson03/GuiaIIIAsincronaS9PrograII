//Ejercicio 1

//Por algunos entornos que no reconocen la ñ le puse years

int[] years = new int[] { 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021 };

foreach (int i in years)
{
    bool Bisiesto = DateTime.IsLeapYear(i);

    Console.WriteLine($"{i} {(Bisiesto ? "es" : "no es")} bisiesto");
}
