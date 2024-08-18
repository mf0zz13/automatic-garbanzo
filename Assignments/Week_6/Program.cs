using System;

namespace WeekSixAssignments
{
    internal class Program
    {
        public static CustomLinkedList linkedList = new();
        public static CustomStack<int> stack = new CustomStack<int>(10);
        public static CustomQueue queue = new CustomQueue();
        public static Dictionary<Displays.Menus, (string, string, string, string, string)> MenuOptions = new Dictionary<Displays.Menus, (string, string, string, string, string)>();
        public static void Initialize()
        {
            #region MenuOptions KVPs
            MenuOptions.Add(Displays.Menus.Main, ("Assignment 6.1", "Assignment 6.2", "Assignment 6.3", "Assignment 6.4", "Week 6 Challenges"));
            MenuOptions.Add(Displays.Menus.Six_One, ("Part One", "Part Two", "Part Three", null, null));
            MenuOptions.Add(Displays.Menus.SixOne_One, ("Add House", "Remove House", "Search House", null, null));
            MenuOptions.Add(Displays.Menus.Six_Two, ("Part One", "Part Two", null, null, null));
            MenuOptions.Add(Displays.Menus.SixTwo_One, ("Add Item to Stack", "Remove Item from Stack", "See Top Item On Stack", "See All Items In Stack", null));
            MenuOptions.Add(Displays.Menus.SixThree, ("Add Customer to Queue", "Call next Customer", null, null, null));
            MenuOptions.Add(Displays.Menus.SixChallenges, ("Challenge One", "Challenge Two", null, null, null));
            #endregion

            #region 6.1.1 TestData
            House h1 = new(1234, "Cedar Road", HouseType.Ranch);
            House h2 = new(6847, "Maple Avenue", HouseType.Craftsman);
            House h3 = new(9641, "Oak Street", HouseType.TownHouse);
            House h4 = new(9354, "Pine Lane", HouseType.Cottage);
            House h5 = new(8792, "Elm Drive", HouseType.Condo);
            House h6 = new(9526, "Birch Boulevard", HouseType.Colonial);
            House h7 = new(1583, "Willow Way", HouseType.TownHouse);
            House h8 = new(1981, "Cherry Court", HouseType.Ranch);
            House h9 = new(1873, "Aspen Circle", HouseType.Craftsman);
            House h10 = new(8934, "Spruce Terrace", HouseType.Condo);
            House h11 = new(3482, "Magnolia Place", HouseType.Ranch);
            House h12 = new(4587, "Sycamore Lane", HouseType.Cottage);
            House h13 = new(9357, "Redwood Avenue", HouseType.Colonial);
            House h14 = new(5287, "Dogwood Street", HouseType.TownHouse);
            House h15 = new(6827, "Poplar Drive", HouseType.Ranch);

            linkedList.AddFirst(h1);
            linkedList.AddLast(h2);
            linkedList.AddLast(h3);
            linkedList.AddLast(h4);
            linkedList.AddLast(h5);
            linkedList.AddLast(h6);
            linkedList.AddLast(h7);
            linkedList.AddLast(h8);
            linkedList.AddLast(h9);
            linkedList.AddLast(h10);
            linkedList.AddLast(h11);
            linkedList.AddLast(h12);
            linkedList.AddLast(h13);
            linkedList.AddLast(h14);
            linkedList.AddLast(h15);
            #endregion
        }
        static void MenuSwitch(Displays.Menus option)
        {
            #region Fields
            bool exit = false;
            int userInput = -1;
            #endregion

            while (!exit)
            {
                userInput = Displays.Display(option);
                switch (userInput)
                {
                    case 1:
                        switch (option)
                        {
                            case Displays.Menus.Main: MenuSwitch(Displays.Menus.Six_One); break;
                            case Displays.Menus.Six_One: MenuSwitch(Displays.Menus.SixOne_One); break;
                            case Displays.Menus.SixOne_One: AssignmentSixOne_One(1); break;
                            case Displays.Menus.Six_Two: MenuSwitch(Displays.Menus.SixTwo_One); break;
                            case Displays.Menus.SixTwo_One: AssignmentSixTwo_One(1); break;
                            case Displays.Menus.SixThree: queue.Display(); AssignmentSixThree(1);  break;
                        }
                        break;
                    case 2:
                        switch (option)
                        {
                            case Displays.Menus.SixOne_One: AssignmentSixOne_One(2); break;
                            case Displays.Menus.Six_One: MenuSwitch(Displays.Menus.SixOne_Two); AssignmentSixOne_Two(); break;
                            case Displays.Menus.Main: MenuSwitch(Displays.Menus.Six_Two); break;
                            case Displays.Menus.SixTwo_One: AssignmentSixTwo_One(2); break;
                            case Displays.Menus.Six_Two: MenuSwitch(Displays.Menus.SixTwo_Two); AssignmentSixTwo_Two(); break;
                            case Displays.Menus.SixThree: queue.Display(); AssignmentSixThree(2); break;
                        }
                        break;
                    case 3:
                        switch (option)
                        {
                            case Displays.Menus.SixOne_One: AssignmentSixOne_One(3); break;
                            case Displays.Menus.Six_One: MenuSwitch(Displays.Menus.SixOne_Three); AssignmentSixOne_Three(); break;
                            case Displays.Menus.SixTwo_One: AssignmentSixTwo_One(3); break;
                            case Displays.Menus.Main: MenuSwitch(Displays.Menus.SixThree); break;
                        }
                        break;
                    case 4:
                        switch (option)
                        {
                            case Displays.Menus.SixTwo_One: AssignmentSixTwo_One(4); break;
                        }
                        break;

                    //            AssignmentSixTwo();
                    //            break;
                    //        case 3:
                    //            switch (opiton)
                    //            {
                    //              break;
                    //    }
                    //    AssignmentSixThree();
                    //    break;
                    //        case 4:
                    //        switch (opiton)
                    //        {
                    //                 break
                    //            }
                    //    AssignmentSixFour();
                    //    break;
                    //        case 5:
                    //        switch (opiton)
                    //        {
                    //                break;
                    //    }
                    //    AssignmentSixChallengeLabs();
                    //    break;
                    case -1:
                        exit = true;
                        break;
                }
            }
        }
        #region SixOne
        static void AssignmentSixOne_One(int userSelection)
        {
            bool exit = false;

            switch (userSelection)
            {
                case 1:
                    linkedList.AddLast(AddHouse());
                    break;
                case 2:
                    linkedList.Remove(RemoveHouse(ref linkedList));
                    break;
                case 3:
                    Search(ref linkedList);
                    break;
            }

        }

        #region Methods 6.1_1
        static House AddHouse()
        {
            string _houseNumber;
            int _convertedHouseNumber;
            int _houseType;
            bool intParse = false;
            bool enumParse = false;

            House _tempHouse = new();

            while (!intParse || !enumParse)
            {
                Console.Clear();
                Console.WriteLine("Add New House");

                Console.Write("House number: ");
                _houseNumber = Console.ReadLine();
                intParse = Int32.TryParse(_houseNumber, out _convertedHouseNumber);
                if (!intParse) { Console.WriteLine("Invalid input"); continue; }
                else { _tempHouse.HouseNumber = _convertedHouseNumber; }

                Console.Write("Street Name: ");
                _tempHouse.Address = Console.ReadLine();

                Console.WriteLine("House Types(1 - Ranch, 2 - Colonial, 3 - Craftsman, 4 - Cottage, 5 - TownHouse, 6 - Condo)");
                Console.Write("Please enter the number correlating to the house type: ");
                enumParse = Int32.TryParse(Console.ReadLine(), out _houseType);
                if (!enumParse) { Console.WriteLine("Invalid input"); continue; }
                else
                {
                    switch (_houseType)
                    {
                        case 1:
                            _tempHouse.HouseType = HouseType.Ranch;
                            break;
                        case 2:
                            _tempHouse.HouseType = HouseType.Colonial;
                            break;
                        case 3:
                            _tempHouse.HouseType = HouseType.Craftsman;
                            break;
                        case 4:
                            _tempHouse.HouseType = HouseType.Cottage;
                            break;
                        case 5:
                            _tempHouse.HouseType = HouseType.TownHouse;
                            break;
                        case 6:
                            _tempHouse.HouseType = HouseType.Condo;
                            break;
                    }
                }
            }
            return _tempHouse;
        }

        static int RemoveHouse(ref CustomLinkedList linkedList)
        {
            Node _currNode = linkedList.Head;
            if (_currNode == null) { return -1; }
            int houseNumber = -1;

            Console.Clear();
            Console.WriteLine("Remove a House\n");

            for (int i = 0; i < linkedList.Size; i++)
            {
                Console.WriteLine($"{_currNode.Data.HouseNumber}, {_currNode.Data.Address}, {_currNode.Data.HouseType}");
                _currNode = _currNode.Next;
            }

            Console.WriteLine();

            houseNumber = ValidateHouseNumber("Please enter the house number you would like to remove: ", ref linkedList);

            return houseNumber;
        }

        static void Search(ref CustomLinkedList linkedList)
        {
            Node _currNode = linkedList.Head;
            int houseNumber = -1;

            Console.Clear();
            Console.WriteLine("Search for a houses record");
            houseNumber = ValidateHouseNumber("Please enter house number you would like to search: ", ref linkedList);
            if (houseNumber == -1) { return; }
            while (_currNode.Data.HouseNumber != houseNumber)
            {
                _currNode = _currNode.Next;
            }

            Console.WriteLine($"House Number: {_currNode.Data.HouseNumber}\nStreet: {_currNode.Data.Address}\nHouse Type: {_currNode.Data.HouseType}");
            Console.WriteLine("Press any key to return");

            Console.ReadKey();
        }

        static int ValidateHouseNumber(string prompt, ref CustomLinkedList linkedList)
        {
            bool _validInput = false;
            int houseNumber = 0;

            while (!_validInput)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (input.ToUpper() == "EXIT") { return -1; }
                _validInput = Int32.TryParse(input, out houseNumber);
                if (!_validInput) { Console.WriteLine("Invalid input"); continue; }
                _validInput = linkedList.Search(houseNumber).IsInList;
                if (!_validInput) { Console.WriteLine("Invalid input"); continue; }
            }
            return houseNumber;
        }
        #endregion

        static void AssignmentSixOne_Two()
        {
            int[] nums = new int[6];
            int[] nums2 = new int[3];
            int[] nums3 = new int[6];

            Console.WriteLine("This is a demonstration of the LinkedList<T> class");
            Console.WriteLine();
            Console.WriteLine("LinkedList<int> ll = new();");
            LinkedList<int> ll = new();
            Console.WriteLine("ll.AddFirst(1);");
            ll.AddFirst(1);
            Console.WriteLine("ll.AddLast(10);");
            ll.AddLast(10);
            Console.WriteLine("ll.AddFirst(2);");
            ll.AddFirst(2);
            Console.WriteLine("ll.AddLast(9);");
            ll.AddLast(9);
            Console.WriteLine("ll.AddBefore(ll.Last, 15);");
            ll.AddBefore(ll.Last, 15);
            Console.WriteLine("ll.AddAfter(ll.First, 5);");
            ll.AddAfter(ll.First, 5);
            Console.WriteLine("ll.CopyTo(nums, 0);");
            ll.CopyTo(nums, 0);
            Console.WriteLine("foreach (int num in nums) { Console.WriteLine(num); }");
            Console.WriteLine();
            foreach (int num in nums) { Console.WriteLine(num); }
            Console.WriteLine();
            Console.WriteLine("ll.RemoveFirst();");
            ll.RemoveFirst();
            Console.WriteLine("ll.RemoveLast();");
            ll.RemoveLast();
            Console.WriteLine("ll.Remove(10);");
            ll.Remove(10);
            Console.WriteLine("ll.CopyTo(nums2, 0);");
            ll.CopyTo(nums2, 0);
            Console.WriteLine("foreach (int num in nums2) { Console.WriteLine(num); }");
            Console.WriteLine();
            foreach (int num in nums2) { Console.WriteLine(num); }
            Console.WriteLine();
            Console.WriteLine("ll.Clear();");
            ll.Clear();
            Console.WriteLine("Console.WriteLine(ll.Count);");
            Console.WriteLine(ll.Count);
            Console.WriteLine();
            Console.WriteLine("Hit any key to exit");
            Console.ReadKey();
        }

        static void AssignmentSixOne_Three()
        {
            int[] numArray = new int[0];
            bool validInput = false;
            while (!validInput)
            {

                Console.WriteLine("Please enter a set of numbers separated by commas:");
                string input = Console.ReadLine();

                try { numArray = input.Split(',').Select(Int32.Parse).ToArray(); validInput = true; }
                catch
                {
                    Console.WriteLine("Please only enter numbers separated by commas");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
            }
            Console.Write("Input: ");
            OutputArray(numArray);

            for (int i = 0; i < numArray.Length; i++)
            {
                switch (numArray[i])
                {
                    case 0:
                        int tempCount = i;
                        while (numArray[tempCount] == 0)
                        {
                            tempCount++;
                            if (tempCount == numArray.Length) { break; }
                        }
                        if (tempCount == numArray.Length) { break; }
                        numArray[i] = numArray[tempCount];
                        numArray[tempCount] = 0;
                        break;
                    default:
                        break;
                }
            }
            Console.Write("Output: ");
            OutputArray(numArray);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        #region Methods 6.1_3
        static void OutputArray(int[] array)
        {
            int counter = 0;
            foreach (int item in array)
            {
                if (counter == 0) { Console.Write($"[{item}, "); }
                else if (counter == array.Length - 1) { Console.WriteLine($"{item}]"); }
                else { Console.Write($"{item}, "); }
                counter++;
            }
        }
        #endregion

        #endregion

        #region SixTwo
        static void AssignmentSixTwo_One(int userInput)
        {
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

        #region SixTwo_One Methods
        public static int ValidateNumInput(string input)
        {
            int returnVal;

            if (input == "EXIT") { return -1; }
            bool validInput = Int32.TryParse(input, out returnVal);

            while (!validInput)
            {
                Console.WriteLine("Please enter a number");
                Console.Write("Input not recognized please try again: ");
                input = Console.ReadLine();
                validInput = Int32.TryParse(input, out returnVal);
            }

            return returnVal;
        }
        #endregion

        static void AssignmentSixTwo_Two()
        {
            int[] inputArray;
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.WriteLine("Please enter the numbers you would like to add to the array separated by commas");
                    inputArray = Console.ReadLine().Split(',').Select(Int32.Parse).ToArray();
                    validInput = true;

                    CalculateProducts(inputArray);
                    Console.Write($"[{inputArray[0]}, ");
                    for (int i = 1; i < inputArray.Length - 1; i++)
                    {
                        Console.Write($"{inputArray[i]}, ");
                    }
                    Console.WriteLine($"{inputArray[inputArray.Length - 1]}]");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Enter only numbers separated by commas");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
            }
        }

        #region SixTwo_Two Methods
        public static void CalculateProducts(int[] numArray)
        {
            Stack<int> numbersForwards = new Stack<int>();

            int priorSum = 1;
            for (int i = 0; i < numArray.Length; i++)
            {
                numbersForwards.Push(priorSum);
                priorSum *= numArray[i];
            }

            priorSum = 1;
            for (int i = numArray.Length - 1; i >= 0; i--)
            {
                int tempNum = numArray[i];
                numArray[i] = numbersForwards.Pop() * priorSum;
                priorSum *= tempNum;
            }
        }
        #endregion
        #endregion

        static void AssignmentSixThree(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Enter customer name: ");
                    queue.Enqueue(Console.ReadLine());
                    break;
                case 2:
                    queue.Dequeue();
                    break;
            }
        }

        static void AssignmentSixFour()
        {

        }

        static void AssignmentSixChallengeLabs()
        {

        }
        static void Main(string[] args)
        {
            Initialize();
            MenuSwitch(Displays.Menus.Main);
        }

    }

    public class Node
    {
        #region Fields
        private House _data;
        private Node _next;
        #endregion

        #region Constructor
        public Node(House data, Node next = null)
        {
            _data = data;
            _next = next;
        }
        #endregion

        #region Properties
        public House Data
        { get => _data; set => _data = value; }

        public Node Next
        { get => _next; set => _next = value; }
        #endregion
    }

    public class CustomLinkedList
    {
        #region Fields
        private Node _head;
        private Node _tail;
        private int _size;
        #endregion

        #region Properties
        public Node Head
        { get => _head; }

        public Node Tail
        { get => _tail; }

        public int Size
        { get => _size; }
        #endregion

        #region Constructor
        public CustomLinkedList()
        {
            _head = null;
            _tail = null;
            _size = 0;
        }
        #endregion

        #region Methods
        public void AddFirst(House house)
        {
            Node _tempNode = new(house);

            if (_size == 0) { _tail = _tempNode; }
            else { _tempNode.Next = _head; }
            _head = _tempNode;
            _size++;
        }

        public void AddLast(House house)
        {
            Node _tempNode = new(house);
            Node _currNode;

            if (_size == 0) { _head = _tempNode; _size++; return; }
            _currNode = _head;

            while (_currNode.Next != null)
            {
                _currNode = _currNode.Next;
            }

            _currNode.Next = _tempNode;
            _tail = _tempNode;
            _size++;
        }

        public void AddAfter(House house, int houseNumber)
        {
            Node _tempNode = new(house);
            Node _currNode = _head;
            Node _nextNode = null;
            int _count = 0;

            while (_currNode.Data.HouseNumber != houseNumber)
            {
                _currNode = _currNode.Next;
                _count++;

                if (_count == _size) { throw new IndexOutOfRangeException("The house number entered is not in the list."); }
            }
            if (_currNode == _tail) { AddLast(house); return; }
            else
            {
                _tempNode.Next = _currNode.Next;
                _currNode.Next = _tempNode;
            }
            _size++;
        }

        public void AddBefore(House house, int houseNumber)
        {
            Node _tempNode = new(house);
            Node _previousNode = null;
            Node _currNode = _head;
            int _count = 0;

            while (_currNode.Data.HouseNumber != houseNumber)
            {
                _previousNode = _currNode;
                _currNode = _currNode.Next;

                if (_count == _size) { throw new IndexOutOfRangeException("The house number entered is not in the list."); }
            }

            if (_currNode == _head) { AddFirst(house); return; }
            else
            {
                _previousNode.Next = _tempNode;
                _tempNode.Next = _currNode;
            }
            _size++;
        }

        public void RemoveFirst()
        {
            if (_size == 0) { throw new IndexOutOfRangeException("List is Empty."); }
            else
            {
                Node _CurrNode = _head.Next;
                _head.Next = null;
                _head = _CurrNode;
                _size--;
            }

        }

        public void RemoveLast()
        {
            if (_size == 0) { throw new IndexOutOfRangeException("List is Empty."); }
            else if (_size == 1) { RemoveFirst(); return; }
            else
            {
                Node _currNode = _head;
                Node _priorNode = null;
                int _count = 0;


                while (_currNode.Next != null)
                {
                    _priorNode = _currNode;
                    _currNode = _currNode.Next;
                    if (_count == _size) { throw new IndexOutOfRangeException("The house number entered is not in the list."); }
                    _count++;
                }

                _priorNode.Next = null;
                _tail = _priorNode;
                _size--;
            }

        }

        public void Remove(int houseNumber)
        {
            if (houseNumber == -1) { return; }
            if (_size == 0) { throw new IndexOutOfRangeException("List is Empty."); }
            else if (_size == 1) { RemoveFirst(); return; }
            else
            {
                Node _currNode = _head;
                Node _priorNode = null;
                int _count = 0;

                while (_currNode.Data.HouseNumber != houseNumber)
                {
                    _priorNode = _currNode;
                    _currNode = _currNode.Next;
                    if (_count == _size) { throw new IndexOutOfRangeException("The house number entered is not in the list."); }
                    _count++;
                }
                if (_count == 0) { RemoveFirst(); }
                if (_currNode.Next == null) { RemoveLast(); return; }
                else
                {
                    _priorNode.Next = _currNode.Next;
                    _currNode.Next = null;
                }
                _size--;
            }
        }

        public (bool IsInList, int Index) Search(int houseNumber)
        {
            Node _currNode = _head;
            int _index = 1;

            if (_size == 0) { throw new IndexOutOfRangeException("List is Empty."); }

            while (_currNode.Data.HouseNumber != houseNumber)
            {
                _currNode = _currNode.Next;
                if (_index == _size) { return (false, -1); }
                _index++;
            }
            return (true, _index);
        }
        public void Display()
        {
            Node _currNode = _head;

            for (int i = 0; i < _size; i++)
            {
                if (_currNode.Next != null) { Console.Write($"{_currNode.Data.HouseNumber}, {_currNode.Data.Address}, {_currNode.Data.HouseType} -----> "); }
                else { Console.WriteLine($"{_currNode.Data.HouseNumber}, {_currNode.Data.Address}, {_currNode.Data.HouseType}"); }
                _currNode = _currNode.Next;
            }
        }

        #endregion
    }

    public enum HouseType { Ranch, Colonial, Craftsman, Cottage, TownHouse, Condo }

    public class House
    {
        #region Fields
        private int _houseNumber;
        private string _address;
        private HouseType _type;
        #endregion

        #region Properties
        public int HouseNumber
        { get => _houseNumber; set => _houseNumber = value; }

        public string Address
        { get => _address; set => _address = value; }

        public HouseType HouseType
        { get => _type; set => _type = value; }
        #endregion

        #region Constructors
        public House()
        {
            _houseNumber = 0;
            _address = null;
            _type = HouseType.Condo;
        }

        public House(int houseNumber, string address, HouseType houseType)
        {
            _houseNumber = houseNumber;
            _address = address;
            _type = houseType;
        }
        #endregion
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

    public class CustomQueue
    {
        private string _currentCustomer;
        LinkedList<string> _linkedList = new LinkedList<string>();

        public CustomQueue()
        {
            LinkedList<string> _linkedList = new LinkedList<string>();
            _currentCustomer = "";
        }

        public void Enqueue(string name)
        {
            if (_linkedList.Count == 0) { _linkedList.AddFirst(name); _currentCustomer = ""; }
            else { _linkedList.AddLast(name); }
        }

        public void Dequeue()
        {
            _currentCustomer = _linkedList.First.Value.ToString();
            _linkedList.RemoveFirst();
        }

        public void Display()
        {
            Console.WriteLine($"" +
            $"Now Serving: {_currentCustomer}\n" +
            $"           Customers Waiting\n" +
            $"+======================================+\n");

            LinkedListNode<string> name = _linkedList.First;
            for (int i = 0; i < _linkedList.Count; i++)
            {
                if (name != null)
                {
                    Console.WriteLine($"{i + 1}: {name.Value.ToString()}");
                }
                name = name.Next;
            }
        }
    }
}

