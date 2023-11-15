using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.OOP;

public interface IMailService
{
    public void SendEmail(string email, string body);
}
