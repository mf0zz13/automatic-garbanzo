using System;
using System.Windows.Forms;

namespace WeekSixAssignments
{
    public static class Displays
    {
        public static int MainDisplay()
        {
            int validatedInput = 0;

            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"+======================================================================================================+");
                Console.WriteLine(@"| __        __        _      ____  _           _            _                                  _       |");
                Console.WriteLine(@"| \ \      / /__  ___| | __ / ___|(_)_  __    / \   ___ ___(_) __ _ _ __  _ __ ___   ___ _ __ | |_ ___ |");
                Console.WriteLine(@"|  \ \ /\ / / _ \/ _ \ |/ / \___ \| \ \/ /   / _ \ / __/ __| |/ _` | '_ \| '_ ` _ \ / _ \ '_ \| __/ __||");
                Console.WriteLine(@"|   \ V  V /  __/  __/   <   ___) | |>  <   / ___ \\__ \__ \ | (_| | | | | | | | | |  __/ | | | |_\__ \|");
                Console.WriteLine(@"|    \_/\_/ \___|\___|_|\_\ |____/|_/_/\_\ /_/   \_\___/___/_|\__, |_| |_|_| |_| |_|\___|_| |_|\__|___/|");
                Console.WriteLine(@"|                                                             |___/                                    |");
                Console.WriteLine(@"+======================================================================================================+");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1 - Assignment 6.1\n2 - Assignment 6.2\n3 - Assignment 6.3\n4 - Assignment 6.4\n5 - Week Six Challenge Labs");
                Console.Write("Please enter a number correlating to an assignment or \"exit\" to exit: ");

                string input = Console.ReadLine().ToUpper();
                validatedInput = validateInput(input, 5);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return validatedInput;
        }

        public static void AssignmentSixOneDisplay()
        {
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"+==========================================================================================+");
                Console.WriteLine(@"|     _            _                                  _     ____  _        ___             |");
                Console.WriteLine(@"|    / \   ___ ___(_) __ _ _ __  _ __ ___   ___ _ __ | |_  / ___|(_)_  __ / _ \ _ __   ___ |");
                Console.WriteLine(@"|   / _ \ / __/ __| |/ _` | '_ \| '_ ` _ \ / _ \ '_ \| __| \___ \| \ \/ /| | | | '_ \ / _ \|");
                Console.WriteLine(@"|  / ___ \\__ \__ \ | (_| | | | | | | | | |  __/ | | | |_   ___) | |>  < | |_| | | | |  __/|");
                Console.WriteLine(@"| /_/   \_\___/___/_|\__, |_| |_|_| |_| |_|\___|_| |_|\__| |____/|_/_/\_(_)___/|_| |_|\___||");
                Console.WriteLine(@"|                    |___/                                                                 |");
                Console.WriteLine(@"+==========================================================================================+");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1 - Part One\n2 - Part Two\n3 - Part Three");
                Console.Write("Please enter a number correlating to a part or \"exit\" to exit: ");
                string input = Console.ReadLine().ToUpper();
                int validatedInput = validateInput(input, 3);
                switch (validatedInput)
                {
                    case 1:
                        SixOne.SixOneOne();
                        break;
                    case 2:
                        SixOne.SixOneTwo();
                        break;
                    case 3:
                        SixOne.SixOneThree();
                        break;
                    case -1:
                        return;
                        break;
                }
            }
            catch (Exception e)
            { MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public static void AssignmentSixTwoDisplay()
        {
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"+============================================================================================+");
                Console.WriteLine(@"|     _            _                                  _     ____  _      _____               |");
                Console.WriteLine(@"|    / \   ___ ___(_) __ _ _ __  _ __ ___   ___ _ __ | |_  / ___|(_)_  _|_   _|_      _____  |");
                Console.WriteLine(@"|   / _ \ / __/ __| |/ _` | '_ \| '_ ` _ \ / _ \ '_ \| __| \___ \| \ \/ / | | \ \ /\ / / _ \ |");
                Console.WriteLine(@"|  / ___ \\__ \__ \ | (_| | | | | | | | | |  __/ | | | |_   ___) | |>  < _| |  \ V  V / (_) ||");
                Console.WriteLine(@"| /_/   \_\___/___/_|\__, |_| |_|_| |_| |_|\___|_| |_|\__| |____/|_/_/\_(_)_|   \_/\_/ \___/ |");
                Console.WriteLine(@"|                    |___/                                                                   |");
                Console.WriteLine(@"+============================================================================================+");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1 - Part One\n2 - Part Two");
                Console.Write("Please enter a number correlating to a part or \"exit\" to exit: ");
                string input = Console.ReadLine().ToUpper();
                int validatedInput = validateInput(input, 3);
                switch (validatedInput)
                {
                    case 1:
                        SixTwo.SixTwoOne();
                        break;
                    case 2:
                        break;
                    case -1:
                        return;
                        break;
                }
            }
            catch (Exception e)
            { MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private static int validateInput(string input, int range)
        {
            if (input.Length > 1 && input != "EXIT") { throw new ArgumentOutOfRangeException("Please only enter a number or \"exit\""); }

            if (input == "EXIT") { return -1; }

            int userInputNumber;
            bool isNumber = Int32.TryParse(input, out userInputNumber);
            if (!isNumber) { throw new ArgumentOutOfRangeException("Please only enter a number or \"exit\""); }

            if (userInputNumber < 1 || userInputNumber > range) { throw new ArgumentOutOfRangeException("Number must be between 1 and 5"); }
            else { return userInputNumber; }
        }


        public static void AssignemntSixTwoOneTitle()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("+===========================================================================+\r\n" +
                "| ____  _      _____                 ____            _      ___             |\r\n" +
                "|/ ___|(_)_  _|_   _|_      _____   |  _ \\ __ _ _ __| |_   / _ \\ _ __   ___ |\r\n" +
                "|\\___ \\| \\ \\/ / | | \\ \\ /\\ / / _ \\  | |_) / _` | '__| __| | | | | '_ \\ / _ \\|\r\n" +
                "| ___) | |>  < _| |  \\ V  V / (_) | |  __/ (_| | |  | |_  | |_| | | | |  __/|\r\n" +
                "||____/|_/_/\\_(_)_|   \\_/\\_/ \\___/  |_|   \\__,_|_|   \\__|  \\___/|_| |_|\\___||\r\n" +
                "+===========================================================================+");
        }
    }
}