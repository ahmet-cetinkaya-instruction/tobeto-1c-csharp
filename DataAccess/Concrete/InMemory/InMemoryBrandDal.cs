using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryBrandDal : IBrandDal
{
    private readonly List<Brand> _brands = new();

    public List<Brand> GetList()
    {
        return _brands;
    }

    public Brand? GetById(int id)
    {
        Brand? brand = _brands.FirstOrDefault(brandToCompare => brandToCompare.Id == id);
        // Eğer bulamazsa referans tiplerin varsayılan değeri olan null değerini dönüyor olacak.

        return brand;
    }

    public Brand Add(Brand brand)
    {
        Brand? brandThatHasMaxIdValue = _brands.MaxBy(brandToSelectKey => brandToSelectKey.Id);
        int nextIdValue;
        if (brandThatHasMaxIdValue != null)
            nextIdValue = brandThatHasMaxIdValue.Id + 1;
        else
            nextIdValue = 1;
        brand.Id = nextIdValue;

        brand.CreatedAt = DateTime.UtcNow;

        //brand.Id = (_brands.MaxBy(brandToSelectKey => brandToSelectKey.Id)?.Id ?? 0) + 1;
        _brands.Add(brand);

        return brand;
    }
}
