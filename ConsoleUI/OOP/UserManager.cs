using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.OOP;

public class UserManager : IUserManager
{
    private IUserDal _userDal;
    private IMailService _mailService;

    public UserManager(IUserDal userDal, IMailService mailService)
    {
        _userDal = userDal;
        _mailService = mailService;
    }

    public void ChangePassword(User user, string newPassword)
    {
        user.Password = hashPassword(newPassword);
        _userDal.Update(user);
    }

    public void SendForgotPasswordEmail(User user)
    {
        _mailService.SendEmail(user.Email, 
            "Şifrenizi yenilemek için şu bağlantıya tıklayın: https://localhost:3000/forgetpassword");
    }

    private string hashPassword(string newPassword)
    {
        return newPassword + "Hash123XYZ";
    }
}
