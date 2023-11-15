using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.OOP;

// Abstract
public interface IUserManager // : Object
{
    public void SendForgotPasswordEmail(User user);
    public void ChangePassword(User user, string newPassword);
}
