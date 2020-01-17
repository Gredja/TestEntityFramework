using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FirstApp
{
    public partial class EFCContext : DbContext
    {
        public EFCContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public EFCContext(DbContextOptions<EFCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(MyLoggerFactory);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter((category, level) => category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Error)
                .AddProvider(new MyLoggerProvider());
        });
    }
}
