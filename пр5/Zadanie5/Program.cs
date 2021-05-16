using System;
using System.Collections;
using System.Dynamic;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Collections.Generic;
using System.Data.Common;

namespace Zadanie5
{

    public class Student
    {
        public int ID { get; set; }
        public string FIO { get; set; }
        public string Group { get; set; }
        public string Date { get; set; }
        public Student(int id, string fio, string group, string date) { ID = id; FIO = fio; Group = group; Date = date; }
        public static List<Student> SP = new List<Student>();
        public static void DeleteStudentList(int id_select)
        {
            int check = -1;
            int find_Student_ID = -1;
            Console.WriteLine("Формат вывода: ID|ФИО|Группа|Дата рождения");
            for (int i = 0; i < SP.Count; i++)
            {
                Console.WriteLine("{0}  {1}  {2}  {3} ", SP[i].ID, SP[i].FIO, SP[i].Group, SP[i].Date);
            }
            Console.Write("Введите id студента: ");

            id_select = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < SP.Count; i++)
            {
                if (SP[i].ID == id_select)
                {
                    find_Student_ID = i;
                }
            }
            if (find_Student_ID != -1)
            {
                Console.WriteLine("{0}  {1}  {2}  {3} ", SP[find_Student_ID].ID, SP[find_Student_ID].FIO, SP[find_Student_ID].Group, SP[find_Student_ID].Date);
                Console.Write("Удалить? Для подтвеждения введите 1, для отмены 2: ");
                check = Convert.ToInt32(Console.ReadLine());
                if (check == 1)
                {
                    SP.RemoveAt(find_Student_ID);
                    Console.WriteLine("Студент успешно удален");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Удаление отменено");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("ID Студента не найден!");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();

            }
        } // Метод для удаление студентов из коллекции
        public static void EditStudentList(int id) 
        {
            int id_select = 0;
            int find_Student_ID = -1;
            int Change_Student_param = 0;
            Console.WriteLine("Формат вывода: ID|ФИО|Группа|Дата рождения");
            for (int i = 0; i < SP.Count; i++)
            {
                Console.WriteLine("{0}  {1}  {2}  {3} ", SP[i].ID, SP[i].FIO, SP[i].Group, SP[i].Date);
            }
            Console.Write("Введите id студента: ");
            id_select = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < SP.Count; i++)
            {
                if (SP[i].ID == id_select)
                {
                    find_Student_ID = i;
                }
            }
            if (find_Student_ID != -1)
            {
                Console.WriteLine("1. ФИО");
                Console.WriteLine("2. Группа");
                Console.WriteLine("3. Дата рождения");
                Console.Write("Введите номер изменяемого параметра:");
                Change_Student_param = Convert.ToInt32(Console.ReadLine());
                switch (Change_Student_param)
                {
                    case 1:
                        Console.Write("Введите новое значение ФИО:");
                        SP[find_Student_ID].FIO = Console.ReadLine();
                        Console.WriteLine("Данные успешно отредактированны");
                        Console.WriteLine("{0}  {1}  {2}  {3} ", SP[find_Student_ID].ID, SP[find_Student_ID].FIO, SP[find_Student_ID].Group, SP[find_Student_ID].Date);
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("Введите новое значение Группы:");
                        SP[find_Student_ID].Group = Console.ReadLine();
                        Console.WriteLine("Данные успешно отредактированны");
                        Console.WriteLine("{0}  {1}  {2}  {3} ", SP[find_Student_ID].ID, SP[find_Student_ID].FIO, SP[find_Student_ID].Group, SP[find_Student_ID].Date);
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case 3:
                        Console.Write("Введите новое значение Даты рождения студента (в формате ДД.ММ.ГГГГ):");
                        bool flag = false;
                        string date = Console.ReadLine();
                        while (flag == false)
                        {
                            if (CheckDate(date))
                            {
                                flag = true;
                            }
                            else
                            {
                                Console.WriteLine("Неверная дата, повторите ввод");
                                Console.Write("Введите Дату рождения студента (в формате ДД.ММ.ГГГГ):");
                                date = Console.ReadLine();
                            }
                        }
                        SP[find_Student_ID].Date = date;
                        Console.WriteLine("Данные успешно отредактированы");
                        Console.WriteLine("{0}  {1}  {2}  {3} ", SP[find_Student_ID].ID, SP[find_Student_ID].FIO, SP[find_Student_ID].Group, SP[find_Student_ID].Date);
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
            }
            else
            {
                Console.WriteLine("ID Студента не найден!");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
        }// Метод для редактирования записей в коллекции
        public static void AddStudentList(int id) // Метод для добавления студентов в коллекцию
        {
            string fio = "";
            string group = "";
            string date = "";
            bool flag = false;
            Console.Write("Введите ФИО студента:");
            fio = Console.ReadLine();
            Console.Write("Введите группу студента: ");
            group = Console.ReadLine();
            Console.Write("Введите Дату рождения студента (в формате ДД.ММ.ГГГГ): ");
            date = Console.ReadLine();
            while (flag == false)
            {
                if (CheckDate(date))
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Неверная дата, повторите ввод");
                    Console.Write("Введите Дату рождения студента (в формате ДД.ММ.ГГГГ): ");
                    date = Console.ReadLine();
                }
            }
            SP.Add(new Student(id, fio, group, date));
            Console.WriteLine("Данные успешно сохранены");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }
        static bool CheckDate(string date) // Метод проверки корректности введенной даты
        {
            DateTime dt;
            return DateTime.TryParse(date, out dt);
        }
        static void Main(string[] args)
        {
            int check = -1;
            int command = 0;
            int id = 0;
            int find_Student_ID = -1;
            int Change_Student_param = 0;
            
            while (command != 4)
            {
                
                Console.WriteLine("1. Добавить студента");
                Console.WriteLine("2. Изменить данные студента");
                Console.WriteLine("3. Удалить студента");
                Console.WriteLine("4. Завершить работу программы");
                Console.Write("Введите номер команды:");
                command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        id++;
                        AddStudentList(id);
                        break;
                    case 2:
                        EditStudentList(id);
                        break;
                    case 3:
                        DeleteStudentList(id);
                        break;
                }

            }
        }
    }
}

      
