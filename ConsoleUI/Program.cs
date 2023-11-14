using ConsoleUI.OOP;

// Inheritance

User user = new User();
user.Email = "Test@test.com";
user.SetPassword("password");
Console.WriteLine("User");
Console.WriteLine(user.Email);

user.GetTelemetryData();

Customer customer = new Customer();
customer.Email = "customer@test.com";
customer.SetPassword("password");

customer.FirstName = "Ahmet";
customer.LastName = "Çetinkaya";

Console.WriteLine("Customer");
Console.WriteLine(customer.Email);
Console.WriteLine(customer.FirstName);
Console.WriteLine(customer.LastName);

customer.ForgetPassword();

Seller seller = new Seller();
seller.Email = "bestseller@test.com";
seller.SetPassword("password");
seller.Name = "Best Seller";

Console.WriteLine("Seller");
Console.WriteLine(seller.Email);
Console.WriteLine(seller.Name);

seller.ForgetPassword();
