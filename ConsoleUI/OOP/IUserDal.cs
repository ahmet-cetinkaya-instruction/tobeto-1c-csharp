using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.OOP;

public interface IUserDal
{
    public User? GetByEmail(string email);
    public User Add(User user);
    public User Update(User user);
}
