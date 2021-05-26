using System;
using Практическая_работа_5;
namespace Практическая_работа_6
{
    class Program
    {
        static void Main(string[] args)
        {
        a:
            Console.WriteLine("Меню\nВыберите нужное действие\n1 - Показать Информацию о студентах.\n2 - Добавить студента.\n3 - Удалить студента." +
                "\n4 - Изменить студента. \n5 - Поиск студентов \n6 - Выход");
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                Console.WriteLine("Выберите нужное действие\n1 - Вся информация о студентах.\n2 - Список студентов с инициалами\n3 - Список студентов старше 18." +
                        "\n4 - Список студентов младше 18.");
                    int Cc = Convert.ToInt32(Console.ReadLine());
                    if (Cc == 1)
                    {
                        Student.Smotr();
                        Console.ReadLine();                       
                    }
                    else if (Cc == 2)
                    {
                        Student.Iniz();
                        Console.ReadLine();
                    }
                    else if (Cc == 3)
                    {
                        Student.Years2();
                        Console.ReadLine();
                    }
                    else if (Cc == 4)
                    {
                        Student.Years();
                        Console.ReadLine();
                    }
                    goto a;
                case 2:
                    Console.WriteLine(" 1.Введите ID студента \n 2.Введите ФИО студента \n 3.Введите групу студента \n 4.Введите дату рождения студента");
                    int id = Convert.ToInt32(Console.ReadLine());
                    string fio = Console.ReadLine();
                    string group = Console.ReadLine();
                    string data = Console.ReadLine();
                    Student.Dobavlen(id, fio, group, data);
                    goto a;
                case 3:
                    Console.WriteLine("Введите ID студента для удаления \n");
                    id = Convert.ToInt32(Console.ReadLine());
                    Student.Udalit(id);
                    goto a;
                case 4:
                    Student.Izmen();
                    Console.ReadLine();
                    goto a;
                case 5:
                    id = Convert.ToInt32(Console.ReadLine());

                    Student.PoiskID(id);
                    Console.ReadLine();
                    goto a;
                case 6:
                    break;
            }
        }
    }
}

