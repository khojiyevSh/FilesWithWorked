
namespace FilesWithWorked.UserWriteFilesJson
{
    public class Users
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Company Company { get; set; }

        public Users(Company company)
        {
            Company = company;
        }
    }
}
