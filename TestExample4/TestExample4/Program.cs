using Microsoft.VisualBasic;
using System;
public class Exercise4
{
    public static void Main()
    {
        string username, password;
        int ctr = 0, dd = 0;
        do {
            Console.Write("Input a username: ");
            username = Console.ReadLine();
            Console.Write("Input a password: ");

            password = Console.ReadLine();
            if (username == "username" && password == "password")
            {
                dd = 1;
                ctr = 3;
            }
            else
            {
                dd = 0;
                ctr++;
            }
        }

        while ((username != "username" || password != "password") && (ctr != 3));
        if (dd == 0)
        {
            Console.Write("\nLogin attempt more than three times.Try later!\n\n");
        }
        else
    if (dd == 1)
        {
            Console.Write("\nPassword entered is Successful!\n\n");
        }
        }
    }     
