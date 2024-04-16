namespace WebApplication1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class CustomerData
    {
        public static List<Customer> Customers = new List<Customer>
    {
        new Customer { Id = 1, FirstName = "Nada", LastName = "Alshaibani", Email = "nada@gmail.com", PhoneNumber = "12345" },
        new Customer { Id = 2, FirstName = "Aseel", LastName = "Abdulghafour", Email = "aseel@gmail.com", PhoneNumber = "98765" },
        new Customer { Id = 3, FirstName = "Razan", LastName = "Alshatti", Email = "razan@gmail.com", PhoneNumber = "64336" }
    };
    }
}
