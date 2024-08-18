using System;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace WeekSixAssignments
{
    public class Displays
    {
        public enum Menus { Main, Six_One, SixOne_One, SixOne_Two, SixOne_Three, Six_Two, SixTwo_One, SixTwo_Two, SixThree, SixFour, SixChallenges, SixChallenge_One, SixChallenge_Two };

        public static int Display(Menus menu)
        {
            bool exit = false;
            
            int returnNum = -1;
            while (!exit)
            {
                try
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;

                    switch (menu)
                    {
                        case Menus.Main:
                            main();
                            break;
                        case Menus.Six_One:
                            Six_One();
                            break;
                        case Menus.SixOne_One:
                            SixOne_One();
                            break;
                        case Menus.SixOne_Two:
                            SixOne_Two();
                            break;
                        case Menus.SixOne_Three:
                            SixOne_Three();
                            break;
                        case Menus.Six_Two:
                            Six_Two();
                            break;
                        case Menus.SixTwo_One:
                            SixTwo_One();
                            break;
                        case Menus.SixTwo_Two:
                            SixTwo_Two();
                            break;
                        case Menus.SixThree:
                            SixThree();
                            break;
                        case Menus.SixFour:
                            SixFour();
                            break;
                        case Menus.SixChallenges:
                            SixChallenges();
                            break;
                        case Menus.SixChallenge_One:
                            SixChallenge_One();
                            break;
                        case Menus.SixChallenge_Two:
                            SixChallenge_Two();
                            break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    int exitNum = 1;

                    if (Program.MenuOptions.ContainsKey(menu))
                    {
                        ITuple menuOptions = Program.MenuOptions[menu] as ITuple;

                        for (int i = 1; i <= menuOptions.Length; i++)
                        {
                            if (menuOptions[i - 1] != null)
                            {
                                Console.WriteLine($"{i} - {menuOptions[i - 1]}");
                                exitNum++;
                            }
                        }

                        Console.WriteLine($"{exitNum} - Exit");
                        Console.Write("Please enter the number that correlates to the option you would like: ");
                        returnNum = ValidateMenuSelection(Console.ReadLine(), exitNum);
                    }
                    exit = true;
                }
                catch (Exception e)
                { MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            return returnNum;
        }

        #region Page Titles
        private static void main()
        {
            Console.WriteLine("+======================================================================================================+\r\n" +
                "| __        __        _      ____  _           _            _                                  _       |\r\n" +
                "| \\ \\      / /__  ___| | __ / ___|(_)_  __    / \\   ___ ___(_) __ _ _ __  _ __ ___   ___ _ __ | |_ ___ |\r\n" +
                "|  \\ \\ /\\ / / _ \\/ _ \\ |/ / \\___ \\| \\ \\/ /   / _ \\ / __/ __| |/ _` | '_ \\| '_ ` _ \\ / _ \\ '_ \\| __/ __||\r\n" +
                "|   \\ V  V /  __/  __/   <   ___) | |>  <   / ___ \\\\__ \\__ \\ | (_| | | | | | | | | |  __/ | | | |_\\__ \\|\r\n" +
                "|    \\_/\\_/ \\___|\\___|_|\\_\\ |____/|_/_/\\_\\ /_/   \\_\\___/___/_|\\__, |_| |_|_| |_| |_|\\___|_| |_|\\__|___/|\r\n" +
                "|                                                             |___/                                    |\r\n" +
                "+======================================================================================================+");
        }

        public static void Six_One()
        {
            Console.WriteLine("+==========================================================================================+\r\n" +
                "|     _            _                                  _     ____  _        ___             |\r\n" +
                "|    / \\   ___ ___(_) __ _ _ __  _ __ ___   ___ _ __ | |_  / ___|(_)_  __ / _ \\ _ __   ___ |\r\n" +
                "|   / _ \\ / __/ __| |/ _` | '_ \\| '_ ` _ \\ / _ \\ '_ \\| __| \\___ \\| \\ \\/ /| | | | '_ \\ / _ \\|\r\n" +
                "|  / ___ \\\\__ \\__ \\ | (_| | | | | | | | | |  __/ | | | |_   ___) | |>  < | |_| | | | |  __/|\r\n" +
                "| /_/   \\_\\___/___/_|\\__, |_| |_|_| |_| |_|\\___|_| |_|\\__| |____/|_/_/\\_(_)___/|_| |_|\\___||\r\n" +
                "|                    |___/                                                                 |\r\n" +
                "+==========================================================================================+");
        }

        public static void SixOne_One()
        {
            Console.WriteLine("+==========================================================================+\r\n" +
                "|  ____  _        ___               ____            _      ___             |\r\n" +
                "| / ___|(_)_  __ / _ \\ _ __   ___  |  _ \\ __ _ _ __| |_   / _ \\ _ __   ___ |\r\n" +
                "| \\___ \\| \\ \\/ /| | | | '_ \\ / _ \\ | |_) / _` | '__| __| | | | | '_ \\ / _ \\|\r\n" +
                "|  ___) | |>  < | |_| | | | |  __/ |  __/ (_| | |  | |_  | |_| | | | |  __/|\r\n" +
                "| |____/|_/_/\\_(_)___/|_| |_|\\___| |_|   \\__,_|_|   \\__|  \\___/|_| |_|\\___||\r\n" +
                "|                                                                          |\r\n" +
                "+==========================================================================+");
        }

        public static void SixOne_Two()
        {
            Console.WriteLine("+============================================================================+\r\n" +
                "| ____  _        ___               ____            _     _____               |\r\n" +
                "|/ ___|(_)_  __ / _ \\ _ __   ___  |  _ \\ __ _ _ __| |_  |_   _|_      _____  |\r\n" +
                "|\\___ \\| \\ \\/ /| | | | '_ \\ / _ \\ | |_) / _` | '__| __|   | | \\ \\ /\\ / / _ \\ |\r\n" +
                "| ___) | |>  < | |_| | | | |  __/ |  __/ (_| | |  | |_    | |  \\ V  V / (_) ||\r\n" +
                "||____/|_/_/\\_(_)___/|_| |_|\\___| |_|   \\__,_|_|   \\__|   |_|   \\_/\\_/ \\___/ |\r\n" +
                "+============================================================================+");
        }

        public static void SixOne_Three()
        {
            Console.WriteLine("+==================================================================================+\r\n" +
                "| ____  _        ___               ____            _     _____ _                   |\r\n" +
                "|/ ___|(_)_  __ / _ \\ _ __   ___  |  _ \\ __ _ _ __| |_  |_   _| |__  _ __ ___  ___ |\r\n" +
                "|\\___ \\| \\ \\/ /| | | | '_ \\ / _ \\ | |_) / _` | '__| __|   | | | '_ \\| '__/ _ \\/ _ \\|\r\n" +
                "| ___) | |>  < | |_| | | | |  __/ |  __/ (_| | |  | |_    | | | | | | | |  __/  __/|\r\n" +
                "||____/|_/_/\\_(_)___/|_| |_|\\___| |_|   \\__,_|_|   \\__|   |_| |_| |_|_|  \\___|\\___||\r\n" +
                "+==================================================================================+");
        }

        public static void Six_Two()
        {
            Console.WriteLine("+============================================================================================+\r\n" +
                "|     _            _                                  _     ____  _      _____               |\r\n" +
                "|    / \\   ___ ___(_) __ _ _ __  _ __ ___   ___ _ __ | |_  / ___|(_)_  _|_   _|_      _____  |\r\n" +
                "|   / _ \\ / __/ __| |/ _` | '_ \\| '_ ` _ \\ / _ \\ '_ \\| __| \\___ \\| \\ \\/ / | | \\ \\ /\\ / / _ \\ |\r\n" +
                "|  / ___ \\\\__ \\__ \\ | (_| | | | | | | | | |  __/ | | | |_   ___) | |>  < _| |  \\ V  V / (_) ||\r\n" +
                "| /_/   \\_\\___/___/_|\\__, |_| |_|_| |_| |_|\\___|_| |_|\\__| |____/|_/_/\\_(_)_|   \\_/\\_/ \\___/ |\r\n" +
                "|                    |___/                                                                   |\r\n" +
                "+============================================================================================+");
        }

        public static void SixTwo_One()
        {
            Console.WriteLine("+===========================================================================+\r\n" +
                  "| ____  _      _____                 ____            _      ___             |\r\n" +
                  "|/ ___|(_)_  _|_   _|_      _____   |  _ \\ __ _ _ __| |_   / _ \\ _ __   ___ |\r\n" +
                  "|\\___ \\| \\ \\/ / | | \\ \\ /\\ / / _ \\  | |_) / _` | '__| __| | | | | '_ \\ / _ \\|\r\n" +
                  "| ___) | |>  < _| |  \\ V  V / (_) | |  __/ (_| | |  | |_  | |_| | | | |  __/|\r\n" +
                  "||____/|_/_/\\_(_)_|   \\_/\\_/ \\___/  |_|   \\__,_|_|   \\__|  \\___/|_| |_|\\___||\r\n" +
                  "+===========================================================================+");
        }

        public static void SixTwo_Two()
        {
            Console.WriteLine("+==============================================================================+\r\n" +
                "| ____  _      _____                 ____            _     _____               |\r\n" +
                "|/ ___|(_)_  _|_   _|_      _____   |  _ \\ __ _ _ __| |_  |_   _|_      _____  |\r\n" +
                "|\\___ \\| \\ \\/ / | | \\ \\ /\\ / / _ \\  | |_) / _` | '__| __|   | | \\ \\ /\\ / / _ \\ |\r\n" +
                "| ___) | |>  < _| |  \\ V  V / (_) | |  __/ (_| | |  | |_    | |  \\ V  V / (_) ||\r\n" +
                "||____/|_/_/\\_(_)_|   \\_/\\_/ \\___/  |_|   \\__,_|_|   \\__|   |_|   \\_/\\_/ \\___/ |\r\n" +
                "+==============================================================================+");
        }

        public static void SixThree()
        {
            Console.WriteLine("+========================================+\r\n" +
                "| ____  _      _____ _                   |\r\n" +
                "|/ ___|(_)_  _|_   _| |__  _ __ ___  ___ |\r\n" +
                "|\\___ \\| \\ \\/ / | | | '_ \\| '__/ _ \\/ _ \\|\r\n" +
                "| ___) | |>  < _| | | | | | | |  __/  __/|\r\n" +
                "||____/|_/_/\\_(_)_| |_| |_|_|  \\___|\\___||\r\n" +
                "+========================================+");
        }

        public static void SixFour()
        {
            Console.WriteLine("+=====================================+\r\n" +
                "| ____  _        _____                |\r\n" +
                "|/ ___|(_)_  __ |  ___|__  _   _ _ __ |\r\n" +
                "|\\___ \\| \\ \\/ / | |_ / _ \\| | | | '__||\r\n" +
                "| ___) | |>  < _|  _| (_) | |_| | |   |\r\n" +
                "||____/|_/_/\\_(_)_|  \\___/ \\__,_|_|   |\r\n" +
                "+=====================================+");
        }

        public static void SixChallenges()
        {
            Console.WriteLine("+===========================================================================================+\r\n" +
                "|__        __        _      ____  _         ____ _           _ _                            |\r\n" +
                "|\\ \\      / /__  ___| | __ / ___|(_)_  __  / ___| |__   __ _| | | ___ _ __   __ _  ___  ___ |\r\n" +
                "| \\ \\ /\\ / / _ \\/ _ \\ |/ / \\___ \\| \\ \\/ / | |   | '_ \\ / _` | | |/ _ \\ '_ \\ / _` |/ _ \\/ __||\r\n" +
                "|  \\ V  V /  __/  __/   <   ___) | |>  <  | |___| | | | (_| | | |  __/ | | | (_| |  __/\\__ \\|\r\n" +
                "|   \\_/\\_/ \\___|\\___|_|\\_\\ |____/|_/_/\\_\\  \\____|_| |_|\\__,_|_|_|\\___|_| |_|\\__, |\\___||___/|\r\n" +
                "|                                                                           |___/           |\r\n" +
                "+===========================================================================================+");
        }

        public static void SixChallenge_One()
        {
            Console.WriteLine("+===================================================================================+\r\n" +
                "|  ____ _           _ _                         _          _        ___             |\r\n" +
                "| / ___| |__   __ _| | | ___ _ __   __ _  ___  | |    __ _| |__    / _ \\ _ __   ___ |\r\n" +
                "|| |   | '_ \\ / _` | | |/ _ \\ '_ \\ / _` |/ _ \\ | |   / _` | '_ \\  | | | | '_ \\ / _ \\|\r\n" +
                "|| |___| | | | (_| | | |  __/ | | | (_| |  __/ | |__| (_| | |_) | | |_| | | | |  __/|\r\n" +
                "| \\____|_| |_|\\__,_|_|_|\\___|_| |_|\\__, |\\___| |_____\\__,_|_.__/   \\___/|_| |_|\\___||\r\n" +
                "|                                  |___/                                            |\r\n" +
                "+===================================================================================+");
        }

        public static void SixChallenge_Two()
        {
            Console.WriteLine("+======================================================================================+\r\n" +
                "|  ____ _           _ _                         _          _       _____               |\r\n" +
                "| / ___| |__   __ _| | | ___ _ __   __ _  ___  | |    __ _| |__   |_   _|_      _____  |\r\n" +
                "|| |   | '_ \\ / _` | | |/ _ \\ '_ \\ / _` |/ _ \\ | |   / _` | '_ \\    | | \\ \\ /\\ / / _ \\ |\r\n" +
                "|| |___| | | | (_| | | |  __/ | | | (_| |  __/ | |__| (_| | |_) |   | |  \\ V  V / (_) ||\r\n" +
                "| \\____|_| |_|\\__,_|_|_|\\___|_| |_|\\__, |\\___| |_____\\__,_|_.__/    |_|   \\_/\\_/ \\___/ |\r\n" +
                "|                                  |___/                                               |\r\n" +
                "+======================================================================================+");
        }
        #endregion

        #region Methods
        private static int ValidateMenuSelection(string input, int exitNum)
        {
            int numReturn;

            numReturn = Convert.ToInt32(input);
            if (numReturn == exitNum) { return -1; }

            return numReturn;
        }
        #endregion
    }
}








//        public static void AssignmentSixOneDisplay()
//        {
//            try
//            {
//                Console.Clear();
//                Console.ForegroundColor = ConsoleColor.Blue;
//                Console.WriteLine(@"+==========================================================================================+");
//                Console.WriteLine(@"|     _            _                                  _     ____  _        ___             |");
//                Console.WriteLine(@"|    / \   ___ ___(_) __ _ _ __  _ __ ___   ___ _ __ | |_  / ___|(_)_  __ / _ \ _ __   ___ |");
//                Console.WriteLine(@"|   / _ \ / __/ __| |/ _` | '_ \| '_ ` _ \ / _ \ '_ \| __| \___ \| \ \/ /| | | | '_ \ / _ \|");
//                Console.WriteLine(@"|  / ___ \\__ \__ \ | (_| | | | | | | | | |  __/ | | | |_   ___) | |>  < | |_| | | | |  __/|");
//                Console.WriteLine(@"| /_/   \_\___/___/_|\__, |_| |_|_| |_| |_|\___|_| |_|\__| |____/|_/_/\_(_)___/|_| |_|\___||");
//                Console.WriteLine(@"|                    |___/                                                                 |");
//                Console.WriteLine(@"+==========================================================================================+");

//                Console.ForegroundColor = ConsoleColor.Green;
//                Console.WriteLine("1 - Part One\n2 - Part Two\n3 - Part Three");
//                Console.Write("Please enter a number correlating to a part or \"exit\" to exit: ");
//                string input = Console.ReadLine().ToUpper();
//                int validatedInput = validateInput(input, 3);
//                switch (validatedInput)
//                {
//                    case 1:
//                        SixOne.SixOneOne();
//                        break;
//                    case 2:
//                        SixOne.SixOneTwo();
//                        break;
//                    case 3:
//                        SixOne.SixOneThree();
//                        break;
//                    case -1:
//                        return;
//                        break;
//                }
//            }
//            catch (Exception e)
//            { MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
//        }

//        public static void AssignmentSixTwoDisplay()
//        {
//            try
//            {
//                Console.Clear();
//                Console.ForegroundColor = ConsoleColor.Blue;
//                Console.WriteLine(@"+============================================================================================+");
//                Console.WriteLine(@"|     _            _                                  _     ____  _      _____               |");
//                Console.WriteLine(@"|    / \   ___ ___(_) __ _ _ __  _ __ ___   ___ _ __ | |_  / ___|(_)_  _|_   _|_      _____  |");
//                Console.WriteLine(@"|   / _ \ / __/ __| |/ _` | '_ \| '_ ` _ \ / _ \ '_ \| __| \___ \| \ \/ / | | \ \ /\ / / _ \ |");
//                Console.WriteLine(@"|  / ___ \\__ \__ \ | (_| | | | | | | | | |  __/ | | | |_   ___) | |>  < _| |  \ V  V / (_) ||");
//                Console.WriteLine(@"| /_/   \_\___/___/_|\__, |_| |_|_| |_| |_|\___|_| |_|\__| |____/|_/_/\_(_)_|   \_/\_/ \___/ |");
//                Console.WriteLine(@"|                    |___/                                                                   |");
//                Console.WriteLine(@"+============================================================================================+");

//                Console.ForegroundColor = ConsoleColor.Green;
//                Console.WriteLine("1 - Part One\n2 - Part Two");
//                Console.Write("Please enter a number correlating to a part or \"exit\" to exit: ");
//                string input = Console.ReadLine().ToUpper();
//                int validatedInput = validateInput(input, 3);
//                switch (validatedInput)
//                {
//                    case 1:
//                        SixTwo.SixTwoOne();
//                        break;
//                    case 2:
//                        SixTwo.SixTwoTwo();
//                        break;
//                    case -1:
//                        return;
//                        break;
//                }
//            }
//            catch (Exception e)
//            { MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
//        }

//        private static int validateInput(string input, int range)
//        {
//            if (input.Length > 1 && input != "EXIT") { throw new ArgumentOutOfRangeException("Please only enter a number or \"exit\""); }

//            if (input == "EXIT") { return -1; }

//            int userInputNumber;
//            bool isNumber = Int32.TryParse(input, out userInputNumber);
//            if (!isNumber) { throw new ArgumentOutOfRangeException("Please only enter a number or \"exit\""); }

//            if (userInputNumber < 1 || userInputNumber > range) { throw new ArgumentOutOfRangeException("Number must be between 1 and 5"); }
//            else { return userInputNumber; }
//        }


//        public static void AssignemntSixTwoOneTitle()
//        {
//            Console.ForegroundColor = ConsoleColor.Blue;
//            Console.WriteLine("+===========================================================================+\r\n" +
//                "| ____  _      _____                 ____            _      ___             |\r\n" +
//                "|/ ___|(_)_  _|_   _|_      _____   |  _ \\ __ _ _ __| |_   / _ \\ _ __   ___ |\r\n" +
//                "|\\___ \\| \\ \\/ / | | \\ \\ /\\ / / _ \\  | |_) / _` | '__| __| | | | | '_ \\ / _ \\|\r\n" +
//                "| ___) | |>  < _| |  \\ V  V / (_) | |  __/ (_| | |  | |_  | |_| | | | |  __/|\r\n" +
//                "||____/|_/_/\\_(_)_|   \\_/\\_/ \\___/  |_|   \\__,_|_|   \\__|  \\___/|_| |_|\\___||\r\n" +
//                "+===========================================================================+");
//        }

//        public static void AssignementSixTwoTwoTitle()
//        {
//            Console.ForegroundColor = ConsoleColor.Blue;
//            Console.WriteLine("+==============================================================================+\r\n" +
//                "| ____  _      _____                 ____            _     _____               |\r\n" +
//                "|/ ___|(_)_  _|_   _|_      _____   |  _ \\ __ _ _ __| |_  |_   _|_      _____  |\r\n" +
//                "|\\___ \\| \\ \\/ / | | \\ \\ /\\ / / _ \\  | |_) / _` | '__| __|   | | \\ \\ /\\ / / _ \\ |\r\n" +
//                "| ___) | |>  < _| |  \\ V  V / (_) | |  __/ (_| | |  | |_    | |  \\ V  V / (_) ||\r\n" +
//                "||____/|_/_/\\_(_)_|   \\_/\\_/ \\___/  |_|   \\__,_|_|   \\__|   |_|   \\_/\\_/ \\___/ |\r\n" +
//                "+==============================================================================+");
//        }

//        public static void AssignementsSixThreeTitle()
//        {
//            Console.Clear();
//            Console.ForegroundColor = ConsoleColor.Blue;
//            Console.WriteLine("+========================================+\r\n" +
//                "| ____  _      _____ _                   |\r\n" +
//                "|/ ___|(_)_  _|_   _| |__  _ __ ___  ___ |\r\n" +
//                "|\\___ \\| \\ \\/ / | | | '_ \\| '__/ _ \\/ _ \\|\r\n" +
//                "| ___) | |>  < _| | | | | | | |  __/  __/|\r\n" +
//                "||____/|_/_/\\_(_)_| |_| |_|_|  \\___|\\___||\r\n" +
//                "+========================================+");
//            Console.ForegroundColor = ConsoleColor.Green;
//        }

//        public static void AssignmentSixFourTitle()
//        {
//            Console.Clear();
//            Console.ForegroundColor = ConsoleColor.Blue;
//            Console.WriteLine("+=====================================+\r\n" +
//                "| ____  _        _____                |\r\n" +
//                "|/ ___|(_)_  __ |  ___|__  _   _ _ __ |\r\n" +
//                "|\\___ \\| \\ \\/ / | |_ / _ \\| | | | '__||\r\n" +
//                "| ___) | |>  < _|  _| (_) | |_| | |   |\r\n" +
//                "||____/|_/_/\\_(_)_|  \\___/ \\__,_|_|   |\r\n" +
//                "+=====================================+");
//            Console.ForegroundColor = ConsoleColor.Green;
//        }
//    }
//}