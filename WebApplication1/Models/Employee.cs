namespace WebApplication1.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }

    public class EmployeeData
    {
        public static List<Employee> Employees = new List<Employee>
    {
        new Employee { EmployeeId = 1, FirstName = "Nada", LastName = "Alshaibani", Email = "nada@gmail.com", Department = "IT" },
        new Employee { EmployeeId = 2, FirstName = "Aseel", LastName = "Abdulghafour", Email = "aseel@gmail.com", Department = "IT" },
        new Employee { EmployeeId = 3, FirstName = "Razan", LastName = "Alshatti", Email = "razan@gmail.com", Department = "IT" }
    };
    
}
}
