using ConsoleUI.OOP;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//// Inheritance

//User user = new User();
//user.Email = "Test@test.com";
//user.SetPassword("password");
//Console.WriteLine("User");
//Console.WriteLine(user.Email);

//user.GetTelemetryData();

//Customer customer = new Customer();
//customer.Email = "customer@test.com";
//customer.SetPassword("password");

//customer.FirstName = "Ahmet";
//customer.LastName = "Çetinkaya";

//Console.WriteLine("Customer");
//Console.WriteLine(customer.Email);
//Console.WriteLine(customer.FirstName);
//Console.WriteLine(customer.LastName);

//customer.ForgetPassword();

//Seller seller = new Seller();
//seller.Email = "bestseller@test.com";
//seller.SetPassword("password");
//seller.Name = "Best Seller";

//Console.WriteLine("Seller");
//Console.WriteLine(seller.Email);
//Console.WriteLine(seller.Name);

//seller.ForgetPassword();

////User user1 = getActiveUser();
//User user1 = new Customer();
//user1.SetPassword("password");

//Human human1 = new Customer();
////Human human2 = new Customer("Ahmet", "Çetinkaya");
//Human human2 = new Customer(lastName: "Çetinkaya", firstName: "Ahmet"); // Constructor Overloading
//human1.GetTelemetryData();
//human1.GetTelemetryData(bypass: true); // Method Overloading

//IUserDal userDal =
//    new InMemoryUserDal();
////new SqlUserDal();
//// Polymorphisim // Çok biçimlilik

//IMailService mailService = new MailKitMailService();

//IUserManager userManager = new UserManager(userDal, mailService); // Dependency Injection 

//userManager.SendForgotPasswordEmail(seller);

Brand newBrand = new();
newBrand.Name = "Ford";

Brand newBrand2 = new() { Name = "Tesla" };

IBrandDal brandDal = new InMemoryBrandDal();

brandDal.Add(newBrand);
brandDal.Add(newBrand2);

List<Brand> brands = brandDal.GetList();
foreach (Brand brand in brands)
{
    Console.WriteLine($"Id: {brand.Id}");
    Console.WriteLine("Name: " +  brand.Name);
}
