using System;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();
            string putUser;
            string firstName, lastName, disease;
            int age;

            while (true)
            {
                Console.WriteLine("1. Добавить пациента в систему.");
                Console.WriteLine("2. Отсортировать всех больних по фамилии.");
                Console.WriteLine("3. Отсортировать всех больних по возрасту.");
                Console.WriteLine("4. Вывести больных с определённым заболеванием.\n");
                Console.Write("Введите номер команды: ");

                putUser = Console.ReadLine().Replace(" ", "");

                switch (putUser)
                {
                    case "1":
                        Console.Write("Введите имя: ");
                        firstName = Console.ReadLine(); //TODO Сделать проверку
                        Console.Write("Введите фамилию: ");
                        lastName = Console.ReadLine(); //TODO Сделать проверку
                        Console.Write("Введите возраст: ");
                        age = Convert.ToInt32(Console.ReadLine()); //TODO Сделать проверку
                        Console.Write("Введите заболевание: ");
                        disease = Console.ReadLine();
                        Console.WriteLine();
                        hospital.AddPatient(firstName, lastName, age, disease);
                        break;

                    case "2":
                        hospital.OrderByLastname();
                        break;

                    case "3":
                        hospital.OrderByAge();
                        break;

                    case "4":
                        Console.Write("Введите заболевание: ");
                        disease = Console.ReadLine().ToLower().Replace(" ", "");
                        hospital.FindWithDisease(disease);
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
