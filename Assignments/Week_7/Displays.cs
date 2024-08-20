using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WeekSevenAssignments
{
    public enum DisplayWindows { Main, SevenOne, SevenOneOne, SevenOneTwo, SevenTwo, SevenTwoOne, SevenTwoTwo, SevenTwoThree, SevenThree, SevenFour };

    public class Displays
    {
        public static Dictionary<string, (int, string, string, string, string)> switchingWindows = new();

        public static void Initialize()
        {
            switchingWindows.Add("Main", (4, "Assignment 7.1", "Assignment 7.2", "Assignment 7.3", "Assignment 7.4"));
            switchingWindows.Add("SevenOne", (2, "Part One", "Part Two", null, null));
            switchingWindows.Add("SevenTwo", (3, "Part One", "Part Two", "Part Three", null));
        }

        public static void Display(DisplayWindows window = DisplayWindows.Main)
        {
            bool exit = false;
            while (!exit)
            {
                try
                {
                    Console.Clear();
                    TitleSwitch(window);
                    if (switchingWindows.ContainsKey(window.ToString()))
                    {
                        ITuple options = switchingWindows[window.ToString()] as ITuple;

                        int exitNum = 1;
                        for (int i = 0; i < (Int32)options[0]; i++)
                        {
                            Console.WriteLine($"{i + 1} - {options[i + 1]}");
                            exitNum++;
                        }
                        Console.WriteLine($"{exitNum} - Exit");

                        Console.Write("Please enter the number correlating to the option you'd like: ");
                        int userInput = InputValidation.Ints.GetNum();

                        switch (window.ToString())
                        {
                            case "Main":
                                switch (userInput)
                                {
                                    case 1:
                                        Display(DisplayWindows.SevenOne);
                                        break;
                                    case 2:
                                        Display(DisplayWindows.SevenTwo);
                                        break;
                                    case 3:
                                        Display(DisplayWindows.SevenThree);
                                        break;
                                    case 4:
                                        Display(DisplayWindows.SevenFour);
                                        break;
                                    case 5:
                                        exit = true;
                                        break;
                                }
                                break;
                            case "SevenOne":
                                switch (userInput)
                                {
                                    case 1:
                                        Display(DisplayWindows.SevenOneOne);
                                        break;
                                    case 2:
                                        Display(DisplayWindows.SevenOneTwo);
                                        break;
                                    case 3:
                                        exit = true;
                                        break;
                                }
                                break;
                            case "SevenTwo":
                                switch (userInput)
                                {
                                    case 1:
                                        Display(DisplayWindows.SevenTwoOne);
                                        break;
                                    case 2:
                                        Display(DisplayWindows.SevenTwoTwo);
                                        break;
                                    case 3:
                                        Display(DisplayWindows.SevenTwoThree);
                                        break;
                                    case 4:
                                        exit = true;
                                        break;
                                }
                                break;
                        }
                    }
                    else { exit = true; }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private static void TitleSwitch(DisplayWindows window)
        {
            switch (window)
            {
                case DisplayWindows.Main:
                    MainTitle();
                    break;
                case DisplayWindows.SevenOne:
                    SevenOneTitles(0);
                    break;
                case DisplayWindows.SevenOneOne:
                    SevenOneTitles(1);
                    AssignmentSevenOne.PartOne();
                    break;
                case DisplayWindows.SevenOneTwo:
                    SevenOneTitles(2);
                    AssignmentSevenOne.PartTwo();
                    break;
                case DisplayWindows.SevenTwo:
                    SevenTwoTitles(0);
                    break;
                case DisplayWindows.SevenTwoOne:
                    SevenTwoTitles(1);
                    AssignmentSevenTwo.PartOne();
                    break;
                case DisplayWindows.SevenTwoTwo:
                    SevenTwoTitles(2);
                    AssignmentSevenTwo.PartTwo();
                    break;
                case DisplayWindows.SevenTwoThree:
                    SevenTwoTitles(3);
                    AssignmentSevenTwo.PartThree();
                    break;
            }
        }

        #region Window Banners
        private static void MainTitle()
        {
            Console.WriteLine("+===================================================================================================================+\r\n" +
                "|__        __        _      ____                            _            _                                  _       |\r\n" +
                "|\\ \\      / /__  ___| | __ / ___|  _____   _____ _ __      / \\   ___ ___(_) __ _ _ __  _ __ ___   ___ _ __ | |_ ___ |\r\n" +
                "| \\ \\ /\\ / / _ \\/ _ \\ |/ / \\___ \\ / _ \\ \\ / / _ \\ '_ \\    / _ \\ / __/ __| |/ _` | '_ \\| '_ ` _ \\ / _ \\ '_ \\| __/ __||\r\n" +
                "|  \\ V  V /  __/  __/   <   ___) |  __/\\ V /  __/ | | |  / ___ \\\\__ \\__ \\ | (_| | | | | | | | | |  __/ | | | |_\\__ \\|\r\n" +
                "|   \\_/\\_/ \\___|\\___|_|\\_\\ |____/ \\___| \\_/ \\___|_| |_| /_/   \\_\\___/___/_|\\__, |_| |_|_| |_| |_|\\___|_| |_|\\__|___/|\r\n" +
                "|                                                                          |___/                                    |\r\n" +
                "+===================================================================================================================+"
                );
        }

        private static void SevenOneTitles(int option)
        {
            switch (option)
            {
                case 0:
                    Console.WriteLine(
                        "+===========================================================================================================+\r\n" +
                        "| ____                         ___                  _            _                                  _       |\r\n" +
                        "|/ ___|  _____   _____ _ __   / _ \\ _ __   ___     / \\   ___ ___(_) __ _ _ __  _ __ ___   ___ _ __ | |_ ___ |\r\n" +
                        "|\\___ \\ / _ \\ \\ / / _ \\ '_ \\ | | | | '_ \\ / _ \\   / _ \\ / __/ __| |/ _` | '_ \\| '_ ` _ \\ / _ \\ '_ \\| __/ __||\r\n" +
                        "| ___) |  __/\\ V /  __/ | | || |_| | | | |  __/  / ___ \\\\__ \\__ \\ | (_| | | | | | | | | |  __/ | | | |_\\__ \\|\r\n" +
                        "||____/ \\___| \\_/ \\___|_| |_(_)___/|_| |_|\\___| /_/   \\_\\___/___/_|\\__, |_| |_|_| |_| |_|\\___|_| |_|\\__|___/|\r\n" +
                        "|                                                                  |___/                                    |\r\n" +
                        "+===========================================================================================================+"
                        );
                    break;
                case 1:
                    Console.WriteLine(
                        "+=======================================================================================+\r\n" +
                        "| ____                         ___               ____            _      ___             |\r\n" +
                        "|/ ___|  _____   _____ _ __   / _ \\ _ __   ___  |  _ \\ __ _ _ __| |_   / _ \\ _ __   ___ |\r\n" +
                        "|\\___ \\ / _ \\ \\ / / _ \\ '_ \\ | | | | '_ \\ / _ \\ | |_) / _` | '__| __| | | | | '_ \\ / _ \\|\r\n" +
                        "| ___) |  __/\\ V /  __/ | | || |_| | | | |  __/ |  __/ (_| | |  | |_  | |_| | | | |  __/|\r\n" +
                        "||____/ \\___| \\_/ \\___|_| |_(_)___/|_| |_|\\___| |_|   \\__,_|_|   \\__|  \\___/|_| |_|\\___||\r\n" +
                        "+=======================================================================================+"
                        );
                    break;
                case 2:
                    Console.WriteLine(
                        "+==========================================================================================+\r\n" +
                        "| ____                         ___               ____            _     _____               |\r\n" +
                        "|/ ___|  _____   _____ _ __   / _ \\ _ __   ___  |  _ \\ __ _ _ __| |_  |_   _|_      _____  |\r\n" +
                        "|\\___ \\ / _ \\ \\ / / _ \\ '_ \\ | | | | '_ \\ / _ \\ | |_) / _` | '__| __|   | | \\ \\ /\\ / / _ \\ |\r\n" +
                        "| ___) |  __/\\ V /  __/ | | || |_| | | | |  __/ |  __/ (_| | |  | |_    | |  \\ V  V / (_) ||\r\n" +
                        "||____/ \\___| \\_/ \\___|_| |_(_)___/|_| |_|\\___| |_|   \\__,_|_|   \\__|   |_|   \\_/\\_/ \\___/ |\r\n" +
                        "+==========================================================================================+"
                        );
                    break;
            }
        }

        private static void SevenTwoTitles(int option)
        {
            switch (option)
            {
                case 0:
                    Console.WriteLine(
                        "+=============================================================================================================+\r\n" +
                        "| ____                       _____                    _            _                                  _       |\r\n" +
                        "|/ ___|  _____   _____ _ __ |_   _|_      _____      / \\   ___ ___(_) __ _ _ __  _ __ ___   ___ _ __ | |_ ___ |\r\n" +
                        "|\\___ \\ / _ \\ \\ / / _ \\ '_ \\  | | \\ \\ /\\ / / _ \\    / _ \\ / __/ __| |/ _` | '_ \\| '_ ` _ \\ / _ \\ '_ \\| __/ __||\r\n" +
                        "| ___) |  __/\\ V /  __/ | | |_| |  \\ V  V / (_) |  / ___ \\\\__ \\__ \\ | (_| | | | | | | | | |  __/ | | | |_\\__ \\|\r\n" +
                        "||____/ \\___| \\_/ \\___|_| |_(_)_|   \\_/\\_/ \\___/  /_/   \\_\\___/___/_|\\__, |_| |_|_| |_| |_|\\___|_| |_|\\__|___/|\r\n" +
                        "|                                                                    |___/                                    |\r\n" +
                        "+=============================================================================================================+"
                         );
                    break;
                case 1:
                    Console.WriteLine(
                        "+=========================================================================================+\r\n" +
                        "| ____                       _____                 ____            _      ___             |\r\n" +
                        "|/ ___|  _____   _____ _ __ |_   _|_      _____   |  _ \\ __ _ _ __| |_   / _ \\ _ __   ___ |\r\n" +
                        "|\\___ \\ / _ \\ \\ / / _ \\ '_ \\  | | \\ \\ /\\ / / _ \\  | |_) / _` | '__| __| | | | | '_ \\ / _ \\|\r\n" +
                        "| ___) |  __/\\ V /  __/ | | |_| |  \\ V  V / (_) | |  __/ (_| | |  | |_  | |_| | | | |  __/|\r\n" +
                        "||____/ \\___| \\_/ \\___|_| |_(_)_|   \\_/\\_/ \\___/  |_|   \\__,_|_|   \\__|  \\___/|_| |_|\\___||\r\n" +
                        "+=========================================================================================+"
                        );
                    break;
                case 2:
                    Console.WriteLine(
                        "+============================================================================================+\r\n" +
                        "| ____                       _____                 ____            _     _____               |\r\n" +
                        "|/ ___|  _____   _____ _ __ |_   _|_      _____   |  _ \\ __ _ _ __| |_  |_   _|_      _____  |\r\n" +
                        "|\\___ \\ / _ \\ \\ / / _ \\ '_ \\  | | \\ \\ /\\ / / _ \\  | |_) / _` | '__| __|   | | \\ \\ /\\ / / _ \\ |\r\n" +
                        "| ___) |  __/\\ V /  __/ | | |_| |  \\ V  V / (_) | |  __/ (_| | |  | |_    | |  \\ V  V / (_) ||\r\n" +
                        "||____/ \\___| \\_/ \\___|_| |_(_)_|   \\_/\\_/ \\___/  |_|   \\__,_|_|   \\__|   |_|   \\_/\\_/ \\___/ |\r\n" +
                        "+============================================================================================+"
                        );
                    break;
                case 3:
                    Console.WriteLine(
                        "+==================================================================================================+\r\n" +
                        "| ____                       _____                 ____            _     _____ _                   |\r\n" +
                        "|/ ___|  _____   _____ _ __ |_   _|_      _____   |  _ \\ __ _ _ __| |_  |_   _| |__  _ __ ___  ___ |\r\n" +
                        "|\\___ \\ / _ \\ \\ / / _ \\ '_ \\  | | \\ \\ /\\ / / _ \\  | |_) / _` | '__| __|   | | | '_ \\| '__/ _ \\/ _ \\|\r\n" +
                        "| ___) |  __/\\ V /  __/ | | |_| |  \\ V  V / (_) | |  __/ (_| | |  | |_    | | | | | | | |  __/  __/|\r\n" +
                        "||____/ \\___| \\_/ \\___|_| |_(_)_|   \\_/\\_/ \\___/  |_|   \\__,_|_|   \\__|   |_| |_| |_|_|  \\___|\\___||\r\n" +
                        "+==================================================================================================+"
                        );
                    break;
            }
        }
        #endregion
    }
}
