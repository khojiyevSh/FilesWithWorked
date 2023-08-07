namespace FilesWithWorked.TaskAttachment
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public static Company CompanyoToFind(int companyId, List<Company> companies)
        {
            var company = companies.FirstOrDefault(x => x.Id == companyId);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                
                Console.WriteLine($"Companiya Id : {company.Id} |" +
                                  $" Companiya Name : {company.Name}     |" +
                                   $" Companiya Adress : {company.Adress}     |");
                
                Console.ResetColor();
                Console.WriteLine();

            return company;
        }
    }
}
