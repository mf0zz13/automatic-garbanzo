using System;
using System.Windows.Forms;

namespace WeekSixAssignments
{
    class program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                int userInput = Displays.MainDisplay();
                switch (userInput)
                {
                    case 1:
                        Displays.AssignmentSixOneDisplay();
                        break;
                    case 2:
                        Displays.AssignmentSixTwoDisplay();
                        break;
                    case 3:
                        SixThree.SixThreeOne();
                        break;
                    case 4:
                        SixFour.SixFourOne();
                        break;
                    case -1:
                        exit = true;
                        break;
                }
            }
        }
    }

}