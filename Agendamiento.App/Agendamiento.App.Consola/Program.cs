using System;
using Agendamiento.App.Dominio;
using Agendamiento.App.Persistencia;

namespace Agendamiento.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
            BuscarPaciente(1);
        }
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre="Elkin",
                Apellido ="Valencia",
                NumeroTelefono="3184016384",
                Genero=Genero.Masculino,
                Direccion="cra 27B 124 90",
                Ciudad=Ciudad.Armenia
            };
            _repoPaciente.AddPaciente(paciente);

        }

        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine("Nombre: "+paciente.Nombre+" "+paciente.Apellido+"  Género: "+paciente.Genero);
        }   
    }
}
