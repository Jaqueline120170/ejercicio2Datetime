using System;

class Program
{
    static void Main()
    {
        DateTime fechaActual = DateTime.Now;

        int dia = fechaActual.Day;
        int mes = fechaActual.Month;
        int anio = fechaActual.Year;
        int hora = fechaActual.Hour;
        int minutos = fechaActual.Minute;
        int segundos = fechaActual.Second;
        DayOfWeek diaSemana = fechaActual.DayOfWeek;
        int diaDelAnio = fechaActual.DayOfYear;


        Console.WriteLine("Día : " + dia);
        Console.WriteLine("Mes: " + mes);
        Console.WriteLine("Año : " + anio);
        Console.WriteLine("Hora : " + hora);
        Console.WriteLine("Minutos : " + minutos);
        Console.WriteLine("Segundos : " + segundos);
        Console.WriteLine("Día de la semana: " + diaSemana);
        Console.WriteLine("Día del año : " + diaDelAnio);


    }
}

