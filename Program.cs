using System;
namespace StudentRegisterApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            User user1 = new User("Irada", "Feyzullayeva","45if", User.RegistrationMonth.December);
            User user2 = new User("Ulker", "Feyzullayeva", "56wd", User.RegistrationMonth.April);
            User user3 = new User("Valida", "Feyzullayeva", "udjf47", User.RegistrationMonth.March);
            User user4 = new User("Nisa", "Huseynova", "qssc5", User.RegistrationMonth.September);
            User user5 = new User("Alovset", "Gambarov", "dc52", User.RegistrationMonth.July);
            Console.WriteLine(user1.GetDetails());
            Console.WriteLine(user2.GetDetails());
            Console.WriteLine(user3.GetDetails());
            Console.WriteLine(user4.GetDetails());
            Console.WriteLine(user5.GetDetails());
        }
    }
}