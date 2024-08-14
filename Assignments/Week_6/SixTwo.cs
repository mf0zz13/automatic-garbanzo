using System;

namespace WeekSixAssignments
{
    public static class SixTwo
    {
        public static void SixTwoOne()
        {
            Console.Clear();
            Displays.AssignemntSixTwoOneTitle();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("How many elements would you like to be able to hold in your stack: ");
            int numVals = ValidateNumInput(Console.ReadLine().ToUpper());
            if (numVals == -1) { return; }
            CustomStack<int> stack = new CustomStack<int>(numVals);

            int userInput = 0;
            while (userInput != -1)
            {
                Console.Clear();
                Displays.AssignemntSixTwoOneTitle();
                Console.WriteLine("1 - Add item to stack\n2 - Remove top item from stack\n3 - See top item on stack\n4 - See all items in stack");
                Console.WriteLine("Please enter the number correlating to an option or \"Exit\" to exit.");
                userInput = ValidateNumInput(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.Write("Enter a number to add to stack: ");
                        stack.Push(ValidateNumInput(Console.ReadLine()));
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        stack.Peek();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 4:
                        stack.Display();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                }
            }


            Console.ReadKey();
        }

        public static int ValidateNumInput(string input)
        {
            int returnVal;

            if (input == "EXIT") { return -1; }
            bool validInput = Int32.TryParse(input, out returnVal);

            while (!validInput)
            {
                Console.WriteLine("Please enter a number");
                validInput = Int32.TryParse(input, out returnVal);
            }

            return returnVal;
        }
    }
}

public class CustomStack<T>
{
    #region Fields
    private T[] _internalArray;
    int _top = -1;
    #endregion

    #region Properties
    public T Top
    { get => _internalArray[_top]; }

    public bool Empty
    { get => IsEmpty(); }

    public bool Full
    { get => IsFull(); }
    #endregion

    #region Constructor
    public CustomStack(int size)
    {
        _internalArray = new T[size];
    }
    #endregion

    #region Methods
    public bool IsEmpty()
    {
        if (_top == -1) { Console.WriteLine("Stack is empty"); return true; }
        return false;
    }

    public bool IsFull()
    {
        if (_top == _internalArray.Length) { Console.WriteLine("Stack is full"); return true; }
        return false;
    }

    public void Push(T item)
    {
        if (IsFull()) { return; }
        _top++;
        _internalArray[_top] = item;
    }

    public void Pop()
    {
        if (IsEmpty()) { return; }
        _top--;
    }

    public void Peek()
    {
        if (IsEmpty()) { return; }
        Console.WriteLine(_internalArray[_top]);
    }

    public void Display()
    {
        int counter = _top + 1;
        Console.WriteLine("Stack:");
        for (int i = _top; i >= 0; i--)
        {
            Console.WriteLine($"\t{counter}: {_internalArray[i]}");
            counter--;
        }
    }
    #endregion
}

