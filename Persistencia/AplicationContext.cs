using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class AplicationContext : DbContext
    {

        //Creacion de tablas
        public DbSet<Persona> Personas{ get; set;}
        public DbSet<Empleado> Empleados{ get; set;}
        public DbSet<Cliente> Clientes{ get; set;}
        public DbSet<Directivo> Directivos{ get; set;}
        public DbSet<Categoria> Categorias{ get; set;}

        //Conexion
        private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog =Empresa;Integrated Security = True";
          protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
              if(!optionBuilder.IsConfigured){
                  optionBuilder
                  .UseSqlServer(connectionString);
              }
          }
    }
}