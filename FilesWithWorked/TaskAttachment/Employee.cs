namespace FilesWithWorked.TaskAttachment
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Company Company { get; set; }

        public Employee()
        {
            
        }

        public Employee(Employee employee, Company company)
        {
            Company = company;
            Id = employee.Id;
            Name = employee.Name;
            Email = employee.Email;
            Password = employee.Password;
        }

        public static Employee EmployeoToFind(int employeeId, List<Employee> employees)
        {
            var employee = employees.FirstOrDefault(x=>x.Id == employeeId);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine($"Employee Id : {employee.Id} | " +
                                  $"Employee Name : {employee.Name}   |" +
                                  $" Employee Email : {employee.Email}   |" +
                                  $" Employee Passvord : {employee.Password} |");

                Console.ResetColor();
                Console.WriteLine();

                return employee;
        }
    }
}
