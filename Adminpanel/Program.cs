using System;
using WindowsFormsApp1.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace Adminpanel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Консоль администратора");
            Console.ResetColor();

            while (true)
            {
                Console.WriteLine(" Если хотите добавить нового пользователя нажмите -1- ");
                Console.WriteLine(" Если хотите удалить пользователя нажмите -2- ");
                Console.WriteLine(" Выход -3- ");
                string useranswer = Console.ReadLine();
                switch (useranswer)
                {
                    case "1":
                        Console.Write("Введите логин пользователя: ");
                        string login = Console.ReadLine();
                        Console.Write("Введите пароль пользователя: ");
                        string paswd = Console.ReadLine();
                        Console.WriteLine("Выберете права пользователя:");
                        Console.WriteLine("Нажмите -1- для роли администратор.");
                        Console.Write("Нажмите -2- для роли пользователя. Выбор роли: ");
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

                        using (DataUsersContext db = new DataUsersContext())
                        {
                            User user = new User()
                            {
                                UserName = login,
                                UserPassword = BCrypt.Net.BCrypt.HashString(paswd),
                                UserRight = role
                            };

                            db.Add(user);
                            db.SaveChanges();
                        }
                        break;

                    case "2":
                        Console.Write("Введите логин пользователя, которого нужно удалить: ");
                        string loginDELETE = Console.ReadLine();
                        using (DataUsersContext db = new DataUsersContext())
                        {
                            User user = db.Users.Where(u => u.UserName == loginDELETE);
                            if(user != null)
                            {
                                db.Users.Remove(user);
                                db.Entry(user).State = EntityState.Deleted;
                                db.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("Ошибка. Такого пользователя не существует!!!");
                            }
                        }
                            break;

                    default:
                        break;
                }
        
                Console.WriteLine("Хотите добавить нового пользователя?: Да/Нет");
                string answeruser = Console.ReadLine().ToLower();
                if (answeruser == "нет")
                {
                    break;
                }
            }
            
        }
    }
}
