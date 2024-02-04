using LibBabel.TechnicSupportTicket.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LibBabel.TechnicSupportTicket.Persistance;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TicketDb;Integrated Security=True;";
        optionsBuilder.UseSqlServer(connStr, opt =>
        {
            opt.EnableRetryOnFailure();
        });
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Firm> Firms { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketComment> TicketComments { get; set; }
    public DbSet<TicketTime> TicketTimes { get; set; }
    public DbSet<Parameter> Parameters{ get; set; }


    public override int SaveChanges()
    {
        OnBeforeSave();
        return base.SaveChanges();
    }

    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        OnBeforeSave();
        return base.SaveChanges(acceptAllChangesOnSuccess);
    }

    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
        OnBeforeSave();
        return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        OnBeforeSave();
        return base.SaveChangesAsync(cancellationToken);
    }

    private void OnBeforeSave()
    {
        var addedEntities = ChangeTracker.Entries()
                                         .Where(i => i.State == EntityState.Added)
                                         .Select(i => (BaseModel)i.Entity);

        PrepareAddedEntities(addedEntities);
    }

    private void PrepareAddedEntities(IEnumerable<BaseModel> entities)
    {
        foreach (var entity in entities)
        {
            if (entity.CreateDate == DateTime.MinValue)
                entity.CreateDate = DateTime.Now;
        }
    }
}
