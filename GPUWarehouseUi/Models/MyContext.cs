using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace GPUWarehouseUi.Models
{
    internal class MyContext : DbContext
    {
        public DbSet<Gpu> Blogs { get; set; }
    }

    [Table("Gpu")]
    public class Gpu
    {
        [Required]
        public int GpuId { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Mocel { get; set; }
    }
}
