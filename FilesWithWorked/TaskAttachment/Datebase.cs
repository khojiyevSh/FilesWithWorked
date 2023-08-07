namespace FilesWithWorked.TaskAttachment
{
    public static class Datebase
    {
       public static List<Employee> Employies = new List<Employee>();

        public static void PrintAll()
        {
            foreach (var employee in Employies)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Employee Id : {employee.Id} |" +
                                  $" Employee Name : {employee.Name}   | " +
                                  $"Employee Email : {employee.Email}   | " +
                                  $"Employee Passvord : {employee.Password} |" +
                                  $"Companiya Id : {employee.Company.Id} |" +
                                  $" Companiya Name : {employee.Company.Name}     |" +
                                  $" Companiya Adress : {employee.Company.Adress}     |");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
