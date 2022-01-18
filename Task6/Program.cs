using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Alina0510", "Alina", "Horkovaya", 17);
            Console.WriteLine("Login: {0}\nName: {1}\nSurname: {2}\nAge: {3}\nRegistration Date: {4}",
                user.Login, user.Name, user.Surname, user.Age, user.RegistrationDate);
        }
    }
}
