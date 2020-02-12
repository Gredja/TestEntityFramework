using FirstApp.Classes;
using FirstApp.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FirstApp.Context
{
    public sealed partial class EfcContext : DbContext
    {
        public EfcContext()
        {

        }

        public EfcContext(DbContextOptions<EfcContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            // Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Sex> Sex { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MWW-020;Database=EFC;Trusted_Connection=True;");

            optionsBuilder.UseLoggerFactory(MyLoggerFactory);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter((category, level) => category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Information)
                .AddProvider(new MyLoggerProvider());
        });
    }
}
