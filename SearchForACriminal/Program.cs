using System;

namespace Search_for_a_criminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseOfCriminals databaseOfCriminals = new DatabaseOfCriminals();
            string putUser;
            string firstName, lastName, nationality;
            int height, weight;
            bool check = true;
            

            while (true)
            {
                Console.WriteLine("1. Добавить преступника в систему.");
                Console.WriteLine("2. Найти преступника по описанию.");
                Console.WriteLine("3. Заключить преступника под стражу.\n");
                Console.Write("Введите номер команды: ");

                putUser = Console.ReadLine().Replace(" ", "");

                switch (putUser)
                {
                    case "1":
                        Console.Write("Введите имя: ");
                        firstName = Console.ReadLine();
                        Console.Write("Введите фамилию: ");
                        lastName = Console.ReadLine();
                        Console.Write("Введите рост: ");
                        height = Convert.ToInt32(Console.ReadLine()); //TODO Сделать проверку
                        Console.Write("Введите вес: ");
                        weight = Convert.ToInt32(Console.ReadLine()); //TODO Сделать проверку
                        Console.Write("Введите национальность: ");
                        nationality = Console.ReadLine();
                        Console.WriteLine();
                        databaseOfCriminals.AddCriminal(firstName, lastName, height, weight, nationality);
                        break;

                    case "2":
                        Console.Write("Введите рост: ");
                        height = Convert.ToInt32(Console.ReadLine()); //TODO Сделать проверку
                        Console.Write("Введите вес: ");
                        weight = Convert.ToInt32(Console.ReadLine()); //TODO Сделать проверку
                        Console.Write("Введите национальность: ");
                        nationality = Console.ReadLine();
                        databaseOfCriminals.Check(height, weight, nationality);
                        break;

                    case "3":
                        Console.Write("Введите имя: ");
                        firstName = Console.ReadLine();
                        Console.Write("Введите фамилию: ");
                        lastName = Console.ReadLine();
                        databaseOfCriminals.TakeIntoCustody(firstName, lastName);
                        break;

                    default:
                        Console.WriteLine("Введите команду ещё раз.");
                        break;
                }

                Console.WriteLine("Для продолжения нажмите любую кнопку.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}
