using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operations
{
    internal class User
    {
        private string? FullName
        {
            get;
            set;
        }
        private string? Email
        {
            get;
            set;
        }
        private string? PhoneNumber
        {
            get;
            set;
        }

        private static List<User> users = new List<User>();

        public void StartApp()
        {
            Console.WriteLine("Welcome to CRUD Operations Application!");

            bool runApp = true;
            while (runApp)
            {
                Thread.Sleep(1500);
                Console.WriteLine(
                    "\n══════════════════════════════════════════════════════════\n");
                Console.WriteLine(
                    "1-Add User\n2-Update Data of User\n3-Delete User\n4-Print All Users\n5-Clear Console \n6-Exit");
                Console.WriteLine(
                    "\n══════════════════════════════════════════════════════════\n");

                Console.Write("Enter your choice: ");
                ushort choice;
                if (ushort.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddUser();
                            break;
                        case 2:
                            UpdateUser();
                            break;
                        case 3:
                            DeleteUser();
                            break;
                        case 4:
                            PrintAllUsers();
                            break;
                        case 5:
                            Console.WriteLine("Clearing The Console...");
                            Thread.Sleep(1500);
                            Console.Clear();
                            break;
                        case 6:
                            runApp = false;
                            Console.WriteLine("Exiting Application...");
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid Choice!");
                            Console.ResetColor();
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.ResetColor();
                }
            }
        }
        private void AddUser()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                "\n══════════════════════════════════Add User══════════════════════════════════\n");
            Console.ResetColor();
            Console.Write("Please Enter Full-Name: ");
            string fullName = Console.ReadLine();

            Console.Write("Please Enter Email Address: ");
            string email = Console.ReadLine();

            Console.Write("Please Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();

            // Create New User Object (User Creation)
            User newUser =
                new User { FullName = fullName, Email = email, PhoneNumber = phoneNumber };
            users.Add(newUser);

            // Change Console Text Color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nUser Added Successfully!");
            // Reset Console Text Color to Default
            Console.WriteLine(
                "\n══════════════════════════════════New User Information════════════════════════\n");
            Console.ResetColor();
            DisplayUserInfo(newUser);

            /*
            *  Not Good Method to Add User!
            newUser.FullName = fullName;
            newUser.Email = email;
            newUser.PhoneNumber = phoneNumber; */
        }
        private void UpdateUser()
        {
            // Checking if the users List is Empty at first
            if (users.Count == 0)
            {
                DisplayNoUsersFoundMessage();
                return;
            };

            // Updating User Data By Searching Phone Number
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(
                "\n══════════════════════════════════Update User Data════════════════════════\n");
            Console.ResetColor();
            // let the user choose phone nuber or email
            ushort userChoice;
            Console.WriteLine("Update By:\n1-Phone Number\n2-Email Address");

            if (ushort.TryParse(Console.ReadLine(), out userChoice))
            {
                string userInput = null;
                User foundedUser = null;
                switch (userChoice)
                {
                    case 1:
                        Console.Write("Enter Phone Number to Update User Data: ");
                        userInput = Console.ReadLine();
                        foundedUser = FindUserByPhoneNumber(userInput);
                        break;
                    case 2:
                        Console.Write("Enter Email Address to Update User Data: ");
                        userInput = Console.ReadLine();
                        foundedUser = FindUserByEmailAddress(userInput);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        Console.ResetColor();
                        return;
                }
                if (foundedUser != null)
                {
                    UpdateUserByContactInfo(foundedUser);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("User not found!");
                    Console.ResetColor();
                }
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid choice.");
                Console.ResetColor();
            }
        }

        private void DeleteUser()
        {
            if (users.Count == 0)
            {
                DisplayNoUsersFoundMessage();
                return;
            };

            // Deleting User By Phone Number
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(
                "\n══════════════════════════════════Delete User══════════════════════════════════\n");
            Console.ResetColor();
            Console.Write("Please enter the Phone Number of the user: ");
            string phoneNumber = Console.ReadLine();
            User FoundedUser = FindUserByPhoneNumber(phoneNumber);

            if (FoundedUser != null)
            {
                users.Remove(FoundedUser);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("User Deleted Successfully!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No Users Found!");
            }
            Console.ResetColor();
        }

        private void PrintAllUsers()
        {

            if (users.Count != 0)
            {
                foreach (User user in users)
                {
                    // Get User Index And Add 1 to it then display it
                    Console.WriteLine(
                        "\n══════════════════════════════════════════════════════════\n");
                    Console.WriteLine($"User #{users.IndexOf(user) + 1}\n");

                    DisplayUserInfo(user);

                    Thread.Sleep(1000);
                }
            }
            // If users list is empty (count == 0) then display warning message
            else
            {
                DisplayNoUsersFoundMessage();
                return;
            };
        }

        private User FindUserByPhoneNumber(string phoneNumber)
        {
            return users.FirstOrDefault(temp => temp.PhoneNumber == phoneNumber);
        }
        private User FindUserByEmailAddress(string emailAddress)
        {
            return users.FirstOrDefault(temp => temp.Email == emailAddress);
        }
        private void DisplayUserInfo(User user)
        {
            Console.WriteLine($"Full-Name: {user.FullName}");
            Console.WriteLine($"Email Address: {user.Email}");
            Console.WriteLine($"Phone Number: {user.PhoneNumber}");
        }
        private void DisplayNoUsersFoundMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Warning: No Users Found!");
            Console.ResetColor();
        }
        private void UpdateUserByContactInfo(User contactInfo)
        {
            if (contactInfo != null)
            {
                ushort choice;
                Console.WriteLine("\n1-Full Name\n2-Email\n3-Phone Number");
                Console.Write("Please Choose Number to Update: ");
                if (ushort.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter New Full Name: ");
                            contactInfo.FullName = Console.ReadLine();
                            Console.WriteLine("Full Name updated successfully!");
                            break;
                        case 2:
                            Console.Write("Enter New Email Address: ");
                            contactInfo.Email = Console.ReadLine();
                            Console.WriteLine("Email Address updated successfully!");
                            break;
                        case 3:
                            Console.Write("Enter New Phone Number: ");
                            contactInfo.PhoneNumber = Console.ReadLine();
                            Console.WriteLine("Phone Number updated successfully!");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid Choice!");
                            Console.ResetColor();
                            break;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(
                        "\n══════════════════════════════════User Updated Information════════════════════════\n");
                    Console.ResetColor();
                    DisplayUserInfo(contactInfo);
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.ResetColor();
            }
        }
    }
}
