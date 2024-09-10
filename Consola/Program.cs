using Dominio;
using Dominio.Models;
using System;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sistema s = Sistema.GetInstancia();
            Socio sos = s.GetPersonas()[5] as Socio;
            Console.WriteLine(sos.FechaUtlimoPago);
            Console.WriteLine(sos.MesesDeuda());
            Console.WriteLine(sos.MontoDeuda());
            foreach (Socio soc in s.GetSociosCumplenEsteMes()) {
                Console.WriteLine(soc.FechaNacimiento);
            }
            Console.ReadKey();
        }
    }
}
