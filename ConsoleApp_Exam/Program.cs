using ConsoleApp_Exam.Exceptions;
using ConsoleApp_Exam.Models;
using System;

namespace ConsoleApp_Exam
{
    #region .
    //User user = new User("wshgfdhkS", "edvghefhF", "21336782");
    //Console.WriteLine(user.Username);
    //Blog blog = new Blog("titlehasgcjhsgf", "descriptionakhsdfgvhsfv");
    //BlogDatabase.Blogs.Add(blog);
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int input;
            EXCEPTION:
                Console.WriteLine("<========User Menu========>");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("\nEnter : ");

                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ExMessage)
                {
                    Console.WriteLine("\n" + ExMessage.Message + "\n");
                    goto EXCEPTION;
                }
                switch (input)
                {
                    case 1:
                    ENTERNAME:
                        Console.Write("Enter Your Name : ");
                        string Name = Console.ReadLine();
                    ENTERSURNAME:
                        Console.Write("Enter Your Surname : ");
                        string Surname = Console.ReadLine();
                    ENTERPASSWORD:
                        Console.Write("Enter Your Password : ");
                        string Password = Console.ReadLine();
                        try
                        {
                            User user = new User(Name, Surname, Password);
                            UserService.Register(user);
                        }
                        catch (InvalidNameException ExMessageName)
                        {
                            Console.WriteLine("\n" + ExMessageName.Message + "\n");
                            goto ENTERNAME;
                        }
                        catch (InvalidSurNameException ExMessageSurname)
                        {
                            Console.WriteLine("\n" + ExMessageSurname.Message + "\n");
                            goto ENTERSURNAME;
                        }
                        catch (InvalidPasswordException ExMessagePassword)
                        {
                            Console.WriteLine("\n" + ExMessagePassword.Message + "\n");
                            goto ENTERPASSWORD;
                        }
                        break;
                    case 2:
                        ENTERUSERNAME:
                        Console.Write("Enter Username : ");
                        string username = Console.ReadLine();
                        Console.Write("Enter Password : ");
                        string password = Console.ReadLine();
                        UserService.Login(username, password);
                        if (UserService.Login(username, password) == false)
                        {
                            Console.WriteLine("Username or Password is Incorrect");
                            Console.WriteLine("Menu donmek ucun 0 duymesine , Logine davam etmek ucun ise 1 duymesine basin");
                            string exit = Console.ReadLine();
                            if (exit == "0")
                            {
                                break;
                            }
                            else if (exit == "1")
                            {
                                goto ENTERUSERNAME;
                            }
                            else
                            {
                                Console.WriteLine("Duzgun secim edin!!!");
                            }
                            break;
                        }
                        else
                        {
                            int inputblog;
                            EXCEPTIONBLOG:
                            Console.WriteLine("<==========Blog Menu==========>");
                            Console.WriteLine("1. Blog elave et");
                            Console.WriteLine("2. Blog sil");
                            Console.WriteLine("3. Blog detail");
                            Console.WriteLine("4. Butun bloglara bax");
                            Console.WriteLine("5. Bloglari filterle");
                            Console.WriteLine("0. Proqramı bitir");
                            Console.WriteLine("\nEnter: \n");
                            try
                            {
                                inputblog = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception ExMessage)
                            {
                                Console.WriteLine("\n" + ExMessage.Message + "\n");
                                goto EXCEPTIONBLOG;
                            }

                            switch(inputblog)
                            {





                            }

                        }
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("\nDuzgun secim edin\n");
                        break;
                }
            } while (true);
        }
    }
}