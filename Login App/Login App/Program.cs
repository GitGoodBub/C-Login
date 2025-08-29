using System;
using System.Collections.Generic;

// This app presents confidentiality by ensuring that only authorized users can access specific actions.

class Program
{
    // Simulated user database
    static Dictionary < string, string > users = new Dictionary < string, string >
    {
        { "adminUser", "admin" },
        { "regularUser", "user" }
    };

    static void Main()
    {
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();

        if (users.ContainsKey(username))
        {
            string role = users[username];
            Console.WriteLine($"Welcome, {username}! Your role is: {role}");

            // Simulate protected actions
            AdminAction(role);
            UserAction(role);
        }
        else
        {
            Console.WriteLine("Access Denied: Unknown user");
        }
    }

    static void AdminAction(string role)
    {
        if (role == "admin")
        {
            Console.WriteLine("Admin Action: Viewing system logs");
        }
        else
        {
            Console.WriteLine("Access Denied: Admins only");
        }
    }

    static void UserAction(string role)
    {
        if (role == "user")
        {
            Console.WriteLine("User Action: Viewing dashboard");
        }
        else
        {
            Console.WriteLine("Access Denied: Users only");
        }
    }
}

