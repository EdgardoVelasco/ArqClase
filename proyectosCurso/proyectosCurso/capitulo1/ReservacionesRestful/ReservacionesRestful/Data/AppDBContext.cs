using Microsoft.EntityFrameworkCore;
using ReservacionesRestful.Bussiness.Entities;

namespace ReservacionesRestful.Data
{
    /*Esta clase representa al contexto 
     * (Conexión a la base de datos)*/
    public class AppDBContext:DbContext
    {
        public AppDBContext() { }
        public AppDBContext(DbContextOptions<AppDBContext> options)
        :base(options){ }

        /*Declarando Entidades*/
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySQL("server=localhost;port=3306");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*Configurando PK*/
            modelBuilder.Entity<User>()
                .Property(t=>t.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Room>()
                .Property(t=>t.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Reservation>()
                .Property(t=>t.Id)
                .ValueGeneratedOnAdd();

            /*FK*/
            modelBuilder.Entity<Room>()
                            .HasMany(t => t.Reservations)
                            .WithOne(t=>t.Room)
                            .HasForeignKey(r=>r.RoomId);

            base.OnModelCreating(modelBuilder);
        }


    }
}
