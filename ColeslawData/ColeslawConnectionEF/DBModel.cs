using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class GpuContext : DbContext
{
    public DbSet<Gpu> Gpus { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<GpuStatus> GpuStatuses { get; set; }
    public DbSet<DocType> DocTypes { get; set; }
    public DbSet<BusinessPartnerType> BusinessPartnerTypes { get; set; }
    public DbSet<BusinessPartner> BusinessPartners { get; set; }
    public DbSet<Document> Documents { get; set; }

    public string DbPath { get; }

    public GpuContext()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var conn = ConfigurationManager.ConnectionStrings[0].ToString();


        options.UseSqlServer($"{conn}");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Document>()
            .Property(b => b.Date)
            .HasDefaultValueSql("getdate()");
        modelBuilder.Entity<Gpu>()
            .ToTable(tb => tb.HasTrigger("SomeTrigger"));

        modelBuilder.Entity<Warehouse>()
            .ToTable(tb => tb.HasTrigger("SomeTrigger"));

        modelBuilder.Entity<Document>()
            .ToTable(tb => tb.HasTrigger("SomeTrigger"));

        modelBuilder.Entity<Gpu>()
            .Property(e => e.GpuId)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<Document>()
            .Property(e => e.DocumentId)
            .ValueGeneratedOnAdd();
    }
}

public class Document
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DocumentId { get; set; }
    public int Quantity { get; set; }
    public DateTime Date { get; set; }
    public int BusinessPartnerId { get; set; }
    public int GpuId { get; set; }
    public int WarehouseId { get; set; }
    public int DocTypeId { get; set; }
    [ForeignKey("FK_Document_BusinessPartnerId")]
    public BusinessPartner BusinessPartner { get; set; }
    [ForeignKey("GpuId")]
    public Gpu Gpu { get; set; }
    [ForeignKey("WarehouseId")]
    public Warehouse Warehouse { get; set; }
    [ForeignKey("DocTypeId")]
    public DocType DocType { get; set; }
}
[Index(nameof(Name))]
public class BusinessPartner
{
    public int BusinessPartnerId { get; set; }

    [Unicode(true)]
    [MaxLength(40)]
    public string Name { get; set; }
    public string? Address { get; set; }
    public int BusinessPartnerTypeId { get; set; }
    [ForeignKey("BusinessPartner")]
    public BusinessPartnerType Type { get; set; }
}
[Index(nameof(Name))]
public class BusinessPartnerType
{
    public int BusinessPartnerTypeId { get; set; }

    [Unicode(true)]
    [MaxLength(40)]
    public string Name { get; set; }

}
[Index(nameof(Name))]
public class DocType
{
    public int DocTypeId { get; set; }

    [Unicode(true)]
    [MaxLength(20)]
    public string Name { get; set; }
}

public class GpuStatus
{
    public int Id { get; set; }
    public string Quantity { get; set; }
    public int WarehouseId { get; set; }
    public int GpuId { get; set; }

    [ForeignKey("WarehouseId")]
    public Warehouse Warehouse{ get; set; }
    [ForeignKey("GpuId")]
    public Gpu Gpu{ get; set; }
}
[Index(nameof(Make),nameof(Model), IsUnique = true)]
public class Gpu
{
    public int GpuId { get; set; }
    
    [MaxLength(15)]
    public string Make { get; set; }
   
    [MaxLength(15)]
    public string Model { get; set; }

    public List<GpuStatus> GpuStatuses { get; } = new();
}
[Index(nameof(City))]
public class Warehouse
{
    public int WarehouseId { get; set; }
 
    [MaxLength(15)]
    public string City { get; set; }
    public List<GpuStatus> GpuStatuses { get; } = new();
}