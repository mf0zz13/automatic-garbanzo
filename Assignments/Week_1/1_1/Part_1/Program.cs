using System;

namespace WeekOne
{
    class OneOne_1
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                string name = null;
                string address = null;
                int age = 0;

                try
                {
                    Console.WriteLine("Welcome to Assignment One Part One\nPlease enter the following information.");

                    // Getting the users first name. 
                    Console.Write("First Name: ");
                    name = Console.ReadLine();

                    // Verifying that the user only entered letters.
                    foreach(char letter in name)
                    {
                        switch(Char.IsLetter(letter))
                        {
                            case false:
                                throw new FormatException("Names can only conatin letters."); 
                                break;
                        }
                    }

                    // Getting the users age.
                    Console.Write("Age: ");
                    string ageInput = Console.ReadLine();

                    // Verifying that the users input is a number.
                    foreach(char number in ageInput)
                    {
                        switch(Char.IsNumber(number))
                        {
                            case false:
                                throw new FormatException("Age can only conatin numbers.");
                                break;
                        }
                    }

                    // Converting the input to a number.
                    age = Convert.ToInt32(ageInput);
                    
                    // Verifying that the input is not less than zero and not more than the most years a human has lived.
                    switch (age)
                    {
                        case int i when age < 0:
                        case int j when age > 122:
                            throw new IndexOutOfRangeException("Age must be between 0 and 122.");
                            break;
                    }

                    // Getting the users address.
                    Console.Write("Address: ");
                    address = Console.ReadLine();

                    // Outputting the users name, age, and address
                    Console.Clear();
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Age: {age}");
                    Console.WriteLine($"Address: {address}");
                    Console.WriteLine("\nHit any key to exit");
                    Console.ReadLine();
                    exit = true;
                }
                catch (Exception e)
                {
                    // If exception is throw, the error is displayed to the user prior to continuing. 
                    Console.WriteLine($"{e.Message}\nHit Any Key To Continue");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}