using Microsoft.EntityFrameworkCore;

namespace CalendarFormula1.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {

        }
    }
}
