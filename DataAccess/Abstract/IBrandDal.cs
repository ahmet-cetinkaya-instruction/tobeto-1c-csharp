using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IBrandDal
{
    public List<Brand> GetList();
    public Brand? GetById(int id);
    public Brand Add(Brand brand);
}
