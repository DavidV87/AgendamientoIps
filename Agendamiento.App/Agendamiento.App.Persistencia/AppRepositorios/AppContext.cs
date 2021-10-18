using Microsoft.EntityFrameworkCore;
using Agendamiento.App.Dominio;
namespace Agendamiento.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Paciente> Pacientes {get;set;}
        public DbSet<Medico> Medicos {get;set;}
        public DbSet<Usuario> Usuarios {get;set;}
        public DbSet<SedeIps> Sedesips {get;set;}
        public DbSet<Agenda> Agendas {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
               .UseSqlServer("Server=tcp:agendamientoapp.database.windows.net,1433;Database = BDAgendamientoIps;User ID=Agendamiento ;Password=Agenda123.;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                //optionsBuilder
               //.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BDAgendamientoIps");
            
            }
        }
    }
}
