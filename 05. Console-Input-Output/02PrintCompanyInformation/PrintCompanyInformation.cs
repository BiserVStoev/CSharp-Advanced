using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter company address: ");
        string companyAdress = Console.ReadLine();
        Console.WriteLine("Enter phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Enter Fax number: ");
        string faxNumber = Console.ReadLine();
        if (faxNumber == string.Empty)
        {
            faxNumber = "(no fax)";
        }
        Console.WriteLine("Enter web site: ");
        string webSite = Console.ReadLine();
        Console.WriteLine("Enter manager's first name: ");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Enter manager's last name: ");
        string managerLastName = Console.ReadLine();
        Console.WriteLine("Enter manager's age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter manager's phone number: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAdress);
        Console.WriteLine("Tel. " + phoneNumber);
        Console.WriteLine("Fax: " + faxNumber);
        Console.WriteLine("Web site: " + webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3}) ", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}
