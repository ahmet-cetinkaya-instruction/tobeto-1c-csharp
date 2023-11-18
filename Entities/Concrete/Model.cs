using Core.Entities;

namespace Entities.Concrete;

public class Model : Entity<int>
{
    public int BrandId { get; set; } // foreign key
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
}
