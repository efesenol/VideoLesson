using VideoLesson.Entities;
using Microsoft.EntityFrameworkCore;

namespace VideoLesson.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
        
        
       
    }

}