using System;

class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please add personal information:");
        name();
        surname();
        fatherName();
        fin();
        phoneNumber();
        position();
        salary();
    }
    private static void name()
    {

        Console.WriteLine("Pleace insert name:");
        string name = Console.ReadLine();
        name = name.ToLower();
        if ($"{name[0]}" == $"{name[0]}".ToUpper())
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }

        if (name.Length > 1 && name.Length < 20)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);

        }
    }
    private static void surname()
    {

        Console.WriteLine("pleace insert surname :");
        string surname = Console.ReadLine();
        surname = surname.ToLower();
        if ($"{surname[0]}" == $"{surname[0]}".ToUpper())
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
        if (surname.Length > 1 && surname.Length <= 35)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
    private static void fatherName()
    {

        Console.WriteLine("pleace insert father name:");
        string fatherName = Console.ReadLine();
        fatherName = fatherName.ToLower();
        if ($"{fatherName[0]}" == $"{fatherName[0]}".ToUpper())
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
        if (fatherName.Length > 1 && fatherName.Length <= 20)
        {
            Console.WriteLine(true);
        }

        else
        {
            Console.WriteLine(false);
        }
    }

    private static void fin()
    {

        Console.WriteLine("pleace insert fin:");
        string fin = Console.ReadLine();
        fin = fin.ToUpper();
        if (fin.Length == 7)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }


    }
    private static void phoneNumber()
    {
        Console.WriteLine("pleace insert phone number:");
        int phone = +994;
        string phoneNumber = phone + Console.ReadLine();
        phoneNumber = phoneNumber.ToUpper();
        if (phoneNumber.Length == 9)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
    private static void position()
    {
        Console.WriteLine("please insert position");
        Console.WriteLine("birini secin: HR ,Audit ,Engineer");
        string position = Console.ReadLine();
        if (position == "HR")
        {
            Console.WriteLine(true);
        }
        else if (position == "Audit")
        {
            Console.WriteLine(true);
        }
        else if (position == "Engineer")
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
    private static void salary()
    {
        Console.WriteLine("aldigi maas: ");
        int salary = Convert.ToInt32(Console.ReadLine());

        if (salary <= 5000 && salary >= 1500)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }

        Console.WriteLine("included in the data system");
    }

}
