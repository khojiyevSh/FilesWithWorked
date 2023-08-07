namespace FilesWithWorked.UserWritefiles
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Company Company { get; set; }

        public User(Company company)
        {
            Company = company;
        }

        public User(string content)
        {
            var fields = content.Split('|');
            Id = int.Parse(fields[0]);
            Name = fields[1];
            Email = fields[2];
            Password = fields[3];
            Company = new Company();
            Company.Id = int.Parse(fields[4]);
            Company.Id = int.Parse(fields[4]);
            Company.Name = fields[5];
        }

        public override string ToString()
        {
            return $"{Id} | {Name} | {Email} | {Password} | {Company.Id} | {Company.Name} ";
        }
    }
}
