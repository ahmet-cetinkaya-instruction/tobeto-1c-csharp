using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.OOP;
public class MailKitMailService : IMailService
{
    public void SendEmail(string email, string body)
    {
        Console.WriteLine($"MailKit kütüphanesiyle {email} adresine e-posta gönderildi.");
    }
}
