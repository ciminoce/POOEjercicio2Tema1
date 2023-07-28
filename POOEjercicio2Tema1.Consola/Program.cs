using POOEjercicio2Tema1.Entidades;

namespace POOEjercicio2Tema1.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int dia = 29;
            int mes = 2;
            int anio = 2022;
            if (ValidadorFechas.Validar(dia,mes, anio))
            {
                Console.WriteLine($"{dia:00}/{mes:00}/{anio:0000} es fecha válida");
            }
            else
            { 
                Console.WriteLine($"{dia:00}/{mes:00}/{anio:0000} no es fecha válida");
            }
        }
    }
}