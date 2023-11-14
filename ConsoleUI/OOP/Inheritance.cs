// See https://aka.ms/new-console-template for more information

// Inheritance

namespace ConsoleUI.OOP;

// Concrete -> Abstract
public abstract class Human // : Object
{
    protected abstract bool Telemetry { get; set; }

    // public abstract void GetTelemetryData();
    // abstract keyword bizim için soyutluğu ifade ediyor.
    // Dolayısıyla program tarafında kullanabilmek somut karşılığı oluşturulması gerekiyor.

    public virtual void GetTelemetryData()
    {
        if (Telemetry == false)
            return;

        Console.WriteLine("Sistemde 30 saniye durdu.");
    }
}

public class User : Human // Tekli miras
{
    public string Email { get; set; }
    protected string Password { get; private set; }
    protected override bool Telemetry { get; set; } = true;

    public void ForgetPassword()
    {
        Console.WriteLine(
            "Şifre yenileme bağlantısı gönderildi."
            );
    }

    public void SetPassword(string newPassword) // Encapsulation örneği
    {
        this.Password = HashPassword(newPassword);
    }

    public override void GetTelemetryData()
    {
        if (Telemetry == false)
            return;

        base.GetTelemetryData();
        Console.WriteLine(
            "Kullanıcı, sayfayı yeniledi."
            );
    }

    private string HashPassword(string newPassword)
    {
        return newPassword + "Hash123XYZ";
    }
}

public class Customer : User // is-a ilişkisi // Çok düzeyli miras
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //public void CheckPasswordStrong()
    //{
    //    Console.WriteLine(Password);
    //    SetPassword("");
    //    //Password = 'yeniSifre';
    //}
}

public class Seller : User
{
    public string Name { get; set; }
}

public class Product
{

}
