
namespace WebEstudiante.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<WebEstudiante.Models.Student> Students { get; set; }
    }
}