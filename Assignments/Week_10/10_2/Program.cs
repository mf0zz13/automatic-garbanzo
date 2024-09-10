using System.Linq;

namespace ten_two
{
    public class Program
    {
        public static void Main(string[] args)
        {

            TestCase(nameof(PartOne));
            TestCase(nameof(PartTwo));

            Console.ReadLine();
        }

        public static int[] PartOne(int[] nums)
        {
            int[] results = (from num in nums
                             where num >= 0
                             select num).ToArray();

            return results;
        }

        public static Employee[] PartTwo(List<Employee> employees)
        {
            Employee[] results = (from employee in employees
                                  where employee.Salary > 5_000 && employee.Age < 30
                                  select employee).ToArray();
            return results;

        }

        public static void TestCase(string part)
        {
            // Test inputs
            int[] numArray1 = new int[] { 2, -1, 3, -3, 10, -200 };
            int[] numArray2 = new int[] { 7, 2, -100, 50 };
            int[] numArray3 = new int[] { -1, -2, -3, -50 };
            int[] numArray4 = new int[] { 1, 2, 3, 4 };

            // Valid outputs
            int[] output1 = new int[] { 2, 3, 10 };
            int[] output2 = new int[] { 7, 2, 50 };
            int[] output3 = new int[0];
            int[] output4 = new int[] { 1, 2, 3, 4 };

            // Employees for part two test
            Employee employee1 = new() { FirstName = "James", LastName = "Kirk", Salary = 10_000, Age = 32 };
            Employee employee2 = new() { FirstName = "Leonard", LastName = "McCoy", Salary = 7_800, Age = 38 };
            Employee employee3 = new() { FirstName = "Montgomery", LastName = "Scott", Salary = 4_500, Age = 43 };
            Employee employee4 = new() { FirstName = "Nyota", LastName = "Uhura", Salary = 5_100, Age = 26 };
            Employee employee5 = new() { FirstName = "S'chn T'gai", LastName = "Spock", Salary = 8_700, Age = 35 };

            // List that holds employees
            List<Employee> employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);


            if (part == nameof(PartOne))
            {
                // Running test cases
                var result1 = PartOne(numArray1);
                var result2 = PartOne(numArray2);
                var result3 = PartOne(numArray3);
                var result4 = PartOne(numArray4);

                // Outputing results
                Console.WriteLine($"XXXXXXXXXXXXXXXXXXXXXXXXXXXX {part} XXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("Test Case 1: " + (result1.SequenceEqual(output1) ? true : false));
                Console.WriteLine("Test Case 2: " + (result2.SequenceEqual(output2) ? true : false));
                Console.WriteLine("Test Case 3: " + (result3.SequenceEqual(output3) ? true : false));
                Console.WriteLine("Test Case 4: " + (result4.SequenceEqual(output4) ? true : false));

                return;
            }
            else
            {
                // Running test case
                Employee[] selectedEmployees = PartTwo(employees);
                bool validInput = (selectedEmployees.Length == 1 && selectedEmployees[0].FirstName == "Nyota");

                // Outputing results
                Console.WriteLine();
                Console.WriteLine($"XXXXXXXXXXXXXXXXXXXXXXXXXXXX {part} XXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine($"Test Case 1: {validInput}");

                if (validInput)
                {
                    Console.WriteLine();

                    foreach (Employee employee in selectedEmployees)
                    {
                        Console.WriteLine($"First Name: {employee.FirstName}");
                        Console.WriteLine($"Last Name: {employee.LastName}");
                        Console.WriteLine($"Age: {employee.Age}");
                        Console.WriteLine($"Salary: {employee.Salary}");
                    }
                }
            }
        }
    }

    public struct Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
    }
}