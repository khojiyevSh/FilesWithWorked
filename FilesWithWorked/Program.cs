
/*DriveInfo[] driveInfo = DriveInfo.GetDrives();

foreach (DriveInfo drive in driveInfo)
{
    Console.WriteLine($" Name : {drive.Name}");
    Console.WriteLine($" Type : {drive.DriveType}");

    if (drive.IsReady)
    {
        Console.WriteLine($" Size : {drive.TotalSize}");
        Console.WriteLine($" Free Size : {drive.TotalFreeSpace}");
        Console.WriteLine($" Lebal : {drive.VolumeLabel}");
    }
    Console.WriteLine();
}
*/

/*string DDisk = "D:\\cicko ustanofka";

if (Directory.Exists(DDisk))
{
    Console.WriteLine("Sub directoryes ");
    string[] strings = Directory.GetDirectories(DDisk);

    foreach (string s in strings)
    {
        Console.WriteLine(s);
    }

    Console.WriteLine();

    Console.WriteLine("Files");
    string[] strings1 = Directory.GetFiles(DDisk);
    foreach (string s in strings1)
    {
        Console.WriteLine(s);
    }

}

var directoryInfo = new DirectoryInfo(DDisk);

if (directoryInfo.Exists)
{
    Console.WriteLine("Sub directoryes ");
    DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
    foreach(var dir in directoryInfos)
    {
        Console.WriteLine(dir.FullName);
    }

    Console.WriteLine();

    Console.WriteLine("Files");
    FileInfo[] directoryInfos1 = directoryInfo.GetFiles();
    foreach(var dir in directoryInfos1)
    {
        Console.WriteLine(dir.FullName);
    }
}*/

/*
string ddisk = "D:\\test";

string SubCreate = $"test2";


DirectoryInfo dir = new DirectoryInfo(SubCreate);

if (!dir.Exists)
{
    dir.Create();
}

DirectoryInfo dir2 = new DirectoryInfo(ddisk);
if (!dir2.Exists)
{
    dir2.Create();
}
dir2.CreateSubdirectory(SubCreate);*/


/*string create1 = $"D:\\test2";

if (!Directory.Exists(create1))
{
    Directory.CreateDirectory(create1);
}

string SubCreate = $"test2";

string create2 = "D:\\test2\\test2";
if (!Directory.Exists(create2))
{
    Directory.CreateDirectory(create2);
}

Directory.CreateDirectory(SubCreate);
*/

/*string ddisk = "D:\\test";


DirectoryInfo dir = new DirectoryInfo(ddisk);
if (dir.Exists)
{
    dir.Delete(true);
}

string disk = $"D:\\test2";

if (Directory.Exists(disk))
{
    Directory.Delete(disk, true);
}*/


/*string ddisk = "D:\\test";
string newDisk = "D:\\kino\\test2";

if (!Directory.Exists(ddisk))
{
    Directory.CreateDirectory(ddisk);
}



DirectoryInfo directoryInfo  = new DirectoryInfo(ddisk);
if (directoryInfo.Exists && !Directory.Exists(newDisk))
{
    directoryInfo.MoveTo(newDisk);
    Directory.Move(ddisk, newDisk);
}*/




/* User
using FilesWithWorked.UserWritefiles;
using System.Text;

string str = "D:\\kino\\test\\shokh.txt";
List<Company> companies = new List<Company>()
{
 new Company() { Id = 11, Name = "Bepro" },
 new Company() { Id = 22, Name = "Bepro" },
 new Company() { Id = 33, Name = "Bepro" },
 new Company() { Id = 44, Name = "Bepro" }
};

List<User> users = new List<User>()
{
  new User(companies[0]){Id=1,Name="Shokhi",Email="hojiyev@gmail.com",Password="123456" },
  new User(companies[1]){Id=2,Name="Sardor",Email="sardor@gmail.com",Password="12345678"},
  new User(companies[2]){Id=3,Name="Ehzoz",Email="ehzoz@gmail.com",Password="1234"},
  new User(companies[3]){Id=4,Name="Diyor",Email="diyor@gmail.com",Password="aaaaaaaa"}

};

using (StreamWriter writer = new StreamWriter(str, true, Encoding.Unicode))
{
    foreach (User user in users)
    {
        writer.WriteLine(user);
    }
}

using (StreamReader reader = new StreamReader(str))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        var user = new User(line);

        string passwordHide = new string('*', user.Password.Length);

        Console.WriteLine($"Id : {user.Id} | Name : {user.Name} Email : {user.Email} Company Id : {user.Company.Id} Company Name : {user.Company.Name}  Password : {passwordHide}");
    }
}
*/

/*Users
using FilesWithWorked.UserWriteFilesJson;
using System.Text;
using System.Text.Json;

string str = "D:\\kino\\test\\shoh.txt";

List<Company> companies = new List<Company>()
{
new Company() { Id = 11, Name = "Bepro" },
new Company() { Id = 22, Name = "Bepro" },
new Company() { Id = 33, Name = "Bepro" },
new Company() { Id = 44, Name = "Bepro" }
};

List<Users> users = new List<Users>()
{
 new Users(companies[0]){Id=1,Name="Shokhi",Email="hojiyev@gmail.com",Password="123456" },
 new Users(companies[1]){Id=2,Name="Sardor",Email="sardor@gmail.com",Password="12345678"},
 new Users(companies[2]){Id=3,Name="Ehzoz",Email="ehzoz@gmail.com",Password="1234"},
 new Users(companies[3]){Id=4,Name="Diyor",Email="diyor@gmail.com",Password="aaaaaaaa"}

};

using (StreamWriter writer = new StreamWriter(str, true, Encoding.Unicode))
{

   writer.WriteLine(JsonSerializer.Serialize(users));

}

using (StreamReader reader = new StreamReader(str))
{
   var content = reader.ReadToEnd();

   var userList = JsonSerializer.Deserialize<List<Users>>(content);

   foreach (var user in userList)
   {
       string passwordHide = new string('*', user.Password.Length);

       Console.WriteLine($"Id : {user.Id} | Name : {user.Name} Email : {user.Email} Company Id : {user.Company.Id} Company Name : {user.Company.Name}  Password : {passwordHide}");

   }
}*/

/*// Task
 using FilesWithWorked.Task;
using System.Text;
using System.Text.Json;

var papkaTxt = "D:\\kino\\test\\New.txt";


while (true)
{
    Menu();

    var inputNum = int.Parse(Console.ReadLine());

    if (inputNum == 1)
    {
        AddProduct();
        Console.WriteLine();
    }

    if (inputNum == 2)
    {
        using (StreamWriter writer = new StreamWriter(papkaTxt, true, Encoding.Unicode))
        {
            writer.WriteLine(JsonSerializer.Serialize(Datebase.Products));
            Datebase.Products.Clear();
            Console.WriteLine("Sussacefull");
            Console.WriteLine();
        }
    }

    if (inputNum == 3)
    {
        using (StreamReader reader = new StreamReader(papkaTxt))
        {
            string texts;
            while ((texts = reader.ReadLine()) != null)
            {
                var list = JsonSerializer.Deserialize<List<Product>>(texts);
                foreach (var mas in list)
                {
                    Console.WriteLine($"{mas.Id}|{mas.Name}|{mas.Categores.Id}|{mas.Categores.Name}|{mas.Purchases.Prise}|{mas.Purchases.PurchaseDatetime.ToShortDateString()}");

                }
            }
            Console.WriteLine();
        }

    }

    if (inputNum >= 4)
    {
        break;
    }
}

void Menu()
{
    Console.WriteLine(" 1.Add Product\n 2.Write to txt\n 3.To See\n 4.Exit");
}

void AddProduct()
{
    var category = new Category();
    var purchase = new Purchase();

    Console.Write("Product Id : ");
    var productId = int.Parse(Console.ReadLine());

    Console.Write("Product name : ");
    var productName = Console.ReadLine();

    Console.Write("Product Category Id : ");
    var productCategoryId = int.Parse(Console.ReadLine());

    Console.Write("Product Category Name : ");
    var productCategoryName = Console.ReadLine();

    Console.Write("Product Purchase Prise : ");
    var productPurchasePrise = int.Parse(Console.ReadLine());

    Console.Write("Product Purchase Date : ");
    var productPurchaseDate = Convert.ToDateTime(Console.ReadLine());

    category.Id = productCategoryId;
    category.Name = productCategoryName;
    purchase.Prise = productPurchasePrise;
    purchase.PurchaseDatetime = productPurchaseDate;

    var productProduct = new Product(productId, productName, category, purchase);

    Datebase.Products.Add(productProduct);
}

*/



using FilesWithWorked.TaskAttachment;

List<Employee> employees = new List<Employee>()
{
    new Employee(){Id = 11, Name="Shohjhon", Email="shoh@gmail.com ", Password="12345678 "},
    new Employee(){Id = 22, Name="Ehzozjon", Email="ehzoz@gmail.com", Password="111111111"},
    new Employee(){Id = 33, Name="Sardorbe", Email="sardor@gail.com", Password="22222222 "},
    new Employee(){Id = 44, Name="Diyorbek", Email="diyor@gmail.com", Password="333333333"},
    new Employee(){Id = 55, Name="Nozinjon", Email="nozin@gmail.com", Password="444444444"}
};

List<Company> companies = new List<Company>()
{
    new Company(){Id = 111, Name = "Bepro", Adress = "Chilonzor "},
    new Company(){Id = 222, Name = "Ipamm", Adress = "Yunusobot "},
    new Company(){Id = 333, Name = "Robot", Adress = "YashnaObot"},
    new Company(){Id = 444, Name = "Bepro", Adress = "Olmazor   "},
    new Company(){Id = 555, Name = "Hesaa", Adress = "Chilonzor "}
};

while (true)
{
    Menu();
    var inputNum = int.Parse(Console.ReadLine());
    //Eployee to Company is Attachment
    if (inputNum == 1)
    {

        PrintCompany();

        Console.Write("To wich id Company you attach a Employee :");
        var companyId = int.Parse(Console.ReadLine());

        var company = Company.CompanyoToFind(companyId, companies);

        PrintEmployee();

        Console.Write("To wich id Employee you attach :");
        var employeeId = int.Parse(Console.ReadLine());

        var employee = Employee.EmployeoToFind(employeeId, employees);

        Console.Write("Do you attachment? (Yes/No) : ");
        var inputYesOrNo = Console.ReadLine();

        if(inputYesOrNo.ToLower() == "yes")
        {
          var employies = new Employee(employee, company);

          Datebase.Employies.Add(employies);
            PrintGreen("Succasefull");
            Console.WriteLine();
        }
    }
    // To See All
    else if (inputNum == 2)
    {
        Datebase.PrintAll();
    }
    //Employee to see
    else if (inputNum == 3)
    {
        PrintEmployee();
        Console.WriteLine();
    }
    // Company to See
    else if (inputNum == 4)
    {
        PrintEmployee();
        Console.WriteLine();
    }
    //Break
    else if (inputNum >= 5)
    {
        break;
    }
}


void PrintSyan(string mes)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(mes);
    Console.ResetColor();
}

void PrintGreen(string mes)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(mes);
    Console.ResetColor();
}

void PrintRed(string mes)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(mes);
    Console.ResetColor();
}

void PrintYellow(string mes)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(mes);
    Console.ResetColor();
}

void Menu()
{
    PrintSyan("1.Eployee to Company is Attachment\n " +
              "2.To be attachment See\n " +
              "3.Eployee to see\n " +
              "4.Company to see\n " +
              "5.Exit");
}

void PrintCompany()
{
    foreach (var company in companies)
    {
        PrintYellow($"Companiya Id : {company.Id} |" +
                    $" Companiya Name : {company.Name}     |" +
                    $" Companiya Adress : {company.Adress}     |");
    }
    Console.WriteLine();
}

void PrintEmployee()
{
    foreach (var employee in employees)
    {
        PrintYellow($"Employee Id : {employee.Id} |" +
                    $" Employee Name : {employee.Name}   | " +
                    $"Employee Email : {employee.Email}   | " +
                    $"Employee Passvord : {employee.Password} |");
    }
    Console.WriteLine();
}

