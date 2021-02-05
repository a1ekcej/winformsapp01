using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsApp1.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace Adminpanel
{
    class Qwerty
    {
        // приветствие
        public void HelloApp()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Консоль администратора");
            Console.ResetColor(); 
        }

        public string AnswerUser(string str)
        {
            str = Console.ReadLine();
            return str
        }
        // Задать вопрос
        public void QuestionFirst()
        {
            Console.WriteLine(" Если хотите добавить нового пользователя нажмите -1- ");
            Console.WriteLine(" Если хотите удалить пользователя нажмите -2- ");
            Console.WriteLine(" Выход -3- ");
            Console.Write("Выбор операции: ");
            AnswerUser();
             ((useranswer != "1") || ((useranswer != "2")) || (useranswer != "3"))
            {
                Console.Write("Не верно выбрана команда. Повторите ввод: ");
            }
            
        }
        // Задать вопрос
    }
}
bool qwerty = true;
while (qwerty)
{
  
    string useranswer = Console.ReadLine();
    switch (useranswer)
    {
        // Добавить пользователя
        case "1":
            Console.Write("Введите логин пользователя: ");
            string login = Console.ReadLine();
            Console.Write("Введите пароль пользователя: ");


            string paswd = "";
            while (true)
            {
                ConsoleKeyInfo c = Console.ReadKey();

                if (c.Key == ConsoleKey.Enter)
                    break;
                if (c.Key == ConsoleKey.Backspace)
                {
                    if (paswd.Length > 0)
                        paswd = paswd.Remove(paswd.Length - 1);
                }
                else
                    paswd += c.KeyChar;
                foreach (char ch in paswd)
                    Console.Write('*');
            }
            Console.WriteLine("Выберете права пользователя:");
            Console.WriteLine("Нажмите -1- для роли администратор.");
            Console.Write("Нажмите -2- для роли пользователя. Выбор роли: ");
            Console.WriteLine("Выберите роль: ");
            string role = Console.ReadLine();
            switch (role)
            {
                case "1":
                    role = "admin";
                    break;

                case "2":
                    role = "user";
                    break;
                default:
                    break;
            }

            using (DataContext db = new DataContext())
            {
                User user = new User()
                {
                    UserName = login,
                    UserPassword = BCrypt.Net.BCrypt.HashString(paswd),
                    UserRight = role
                };

                db.Add(user);
                db.SaveChanges();
                Console.WriteLine($"Пользователь добавлен в базу данных!");
                Console.WriteLine("--------------------------------------------");
            }
            break;
        // Удалить пользователя
        case "2":
            Console.Write("Введите логин пользователя, которого нужно удалить: ");
            string loginDELETE = Console.ReadLine();

            if (MessageBox.Show($"Вы действительно хотите удалить пользователя {loginDELETE}", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (DataContext db = new DataContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.UserName == loginDELETE);
                    db.Users.Remove(user);
                    db.SaveChanges();
                    Console.WriteLine($"Пользователь {loginDELETE} удален!");
                    Console.WriteLine("--------------------------------------------");
                }
            }
            break;
        // Выйти из консоли
        case "3":
            qwerty = false;
            break;

        default:
            Console.WriteLine("Ошибка. попробуйте еще раз: ");
            break;
    }
}