using System;
using System.Text;

namespace WeekSevenAssignments
{
    public static class AssignmentSevenFour
    {
        public static void SevenFour()
        {
            int big;
            int medium;
            int small;
            bool exit = false;
            int input;
            int size;
            bool result;

            Console.WriteLine("This is a parking lot system please answer the prompts as instructed");
            Console.Write("How many Large parking spot are in the lot: ");
            big = InputValidation.Ints.GetNum();

            Console.Write("How many medium parking spots are in the lot: ");
            medium = InputValidation.Ints.GetNum();

            Console.Write("How many small parking spots are in the lot: ");
            small = InputValidation.Ints.GetNum();

            ParkingSystem parkingSystem = new ParkingSystem(big, medium, small);

            while (!exit)
            {
                Console.WriteLine("Enter '1' to add a car or '2' to exit");
                input = InputValidation.Ints.GetNum();

                switch (input)
                {
                    case 1:
                        Console.Write("Enter '1' for big car, '2' for medium car, '3' for small car: ");
                        size = InputValidation.Ints.GetNum();
                        result = parkingSystem.addCar(size);

                        switch (result)
                        {
                            case true:
                                Console.WriteLine("Car Parked");
                                break;
                            case false:
                                Console.WriteLine("Car can not be parked do to space limitations");
                                break;
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, press enter to continue");
                        continue;
                        break;
                }
            }
        }
    }

    public class ParkingSystem
    {
        #region Properties
        public int BigSpaces { get; set; }
        public int MediumSpaces { get; set; }
        public int SmallSpaces { get; set; }
        #endregion

        public ParkingSystem(int big = 0, int medium = 0, int small = 0)
        {
            BigSpaces = big;
            MediumSpaces = medium;
            SmallSpaces = small;
        }

        public bool addCar(int carType)
        {
            switch (carType)
            {
                case 1:
                    if (this.BigSpaces == 0)
                        return false;
                    else
                        BigSpaces--;
                    break;
                case 2:
                    if (this.MediumSpaces == 0)
                        return false;
                    else
                        MediumSpaces--;
                    break;
                case 3:
                    if (this.SmallSpaces == 0)
                        return false;
                    else
                        MediumSpaces--;
                    break;
            }
            return true;
        }
    }

}