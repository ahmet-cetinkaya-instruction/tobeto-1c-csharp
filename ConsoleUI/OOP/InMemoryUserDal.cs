using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.OOP;
public class InMemoryUserDal : IUserDal
{
    // Generic // Jenerik
    private List<User> _users = new(); // Field

    public User Add(User user)
    {
        _users.Add(user);
        return user;
    }

    public User? GetByEmail(string email)
    {
       User? user = _users.Find(user => user.Email == email);
       return user;
    }

    public User Update(User user)
    {
        User? userFromList = GetByEmail(user.Email);
        if (userFromList != null)
        {
            userFromList.Email = user.Email;
            userFromList.Password = user.Password;
        }
        return userFromList;
    }
}
