//using System;
//using System.Windows.Forms;

//namespace WeekSixAssignments
//{
//    public static class SixThree
//    {
//        public static void SixThreeOne()
//        {
//            bool exit = false;
//            CustomQueue queue = new CustomQueue();
//            while (!exit)
//            {
//                try
//                {
//                    Displays.AssignementsSixThreeTitle();
//                    Console.WriteLine();
//                    queue.Display();
//                    Console.WriteLine();
//                    Console.WriteLine("1 - Add Customer to Queue\n2 - Call next customer\n");
//                    Console.WriteLine("Please enter the number correlating to an option or \"Exit\" to exit.");
//                    int userInput = SixTwo.ValidateNumInput(Console.ReadLine().ToUpper());

//                    switch (userInput)
//                    {
//                        case 1:
//                            Console.WriteLine("Enter customer name: ");
//                            queue.Enqueue(Console.ReadLine());
//                            break;
//                        case 2:
//                            queue.Dequeue();
//                            break;
//                        case -1:
//                            exit = true;
//                            break;
//                        default:
//                            throw new ArgumentOutOfRangeException("Invalid Input");
//                    }
//                }
//                catch (Exception e)
//                { MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
//            }
//        }


//        public class CustomQueue
//        {
//            private string _currentCustomer;
//            LinkedList<string> _linkedList = new LinkedList<string>();

//            public CustomQueue()
//            {
//                LinkedList<string> _linkedList = new LinkedList<string>();
//                _currentCustomer = "";
//            }

//            public void Enqueue(string name)
//            {
//                if (_linkedList.Count == 0) { _linkedList.AddFirst(name); _currentCustomer = ""; }
//                else { _linkedList.AddLast(name); }
//            }

//            public void Dequeue()
//            {
//                _currentCustomer = _linkedList.First.Value.ToString();
//                _linkedList.RemoveFirst();
//            }

//            public void Display()
//            {
//                Console.WriteLine($"" +
//                $"Now Serving: {_currentCustomer}\n" +
//                $"           Customers Waiting\n" +
//                $"+======================================+\n");

//                LinkedListNode<string> name = _linkedList.First;
//                for (int i = 0; i < _linkedList.Count; i++)
//                {
//                    if (name != null)
//                    {
//                        Console.WriteLine($"{i + 1}: {name.Value.ToString()}");
//                    }
//                    name = name.Next;
//                }
//            }

//        }
//    }
//}