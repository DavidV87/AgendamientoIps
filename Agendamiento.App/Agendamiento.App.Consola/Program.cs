using System;
using Agendamiento.App.Dominio;
using Agendamiento.App.Persistencia;

namespace Agendamiento.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());
        private static IRepositorioMedico _repoMedico = new RepositorioMedico(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
            //BuscarPaciente(3);
            //ModificarPaciente(3);
            //BuscarPaciente(3);
            //EliminarPaciente(3);
            //BuscarPaciente(3);
            //AddMedico();
            BuscarPaciente(2);
            BuscarMedico(4);
            
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

        private static void EliminarPaciente(int idPaciente)
        {
            _repoPaciente.DeletePaciente(idPaciente);
            Console.WriteLine("Paciente elminiado de BD");
        }

        private static void ModificarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            paciente.Nombre="Elkin David";
            paciente.Apellido ="Valencia Bonilla";
            paciente.NumeroTelefono="3184016384";
            paciente.Genero=Genero.Masculino;
            paciente.Direccion="cra 27B 124 90";
            paciente.Ciudad=Ciudad.Manizales;            
            _repoPaciente.UpdatePaciente(paciente);
        }

        private static void AddMedico()
        {
            var medico =new Medico
            {
                Nombre="Ramiro",
                Apellido="Ramirez",
                NumeroTelefono="3246267759",
                Genero=Genero.Masculino,
                Direccion="AV 2Oeste 34 190",
                Ciudad=Ciudad.Pereira,
                TarjetaPro="TP04295302",
                //SedeIps="jhuijk",
                Especialidad=Especialidad.Cardiología
            };
            _repoMedico.AddMedico(medico);
            Console.WriteLine("Aca ingresamos el medico bien");
        }
        private static void BuscarMedico(int idMedico)
        {
            Console.WriteLine("Aca empieza a buscar el medico");
            var medico = _repoMedico.GetMedico(idMedico);
            Console.WriteLine("Nombre: "+medico.Nombre);
            Console.WriteLine("Aca termina de buscar el medico");
            
        }     
    }
}
