using AppCd.Shared.Modelo;
using Microsoft.EntityFrameworkCore;

namespace AppCd.Server.Data
{
    public class PersonaContexto : DbContext
    {
        public PersonaContexto(DbContextOptions<PersonaContexto> options) : base(options) 
        { 
        
        }    

      public  DbSet<Persona> Personas { get; set; }
        public DbSet<Precio>? Precios { get; set; }
        public DbSet<Stock>? Stocks { get; set; }
    }
}
