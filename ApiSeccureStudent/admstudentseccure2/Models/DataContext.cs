namespace admstudentseccure2.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<admstudentseccure2.Models.Student> Students { get; set; }
    }
}