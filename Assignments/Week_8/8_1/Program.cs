using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;

namespace eight_one
{
    public enum DataType { Binary, XML, JSON };

    public class program
    {
        public static void Main(string[] args)
        {
            IFormatter formatterBinary = new BinaryFormatter();
            IFormatter formatterXML = new SoapFormatter();

            Student studentOne = new Student { FirstName = "Tony", LastName = "Stark", StudentId = 1234 };
            Student studentTwo = new Student { FirstName = "Steve", LastName = "Rodgers", StudentId = 1235 };
            Student studentThree = new Student { FirstName = "Bruce", LastName = "Banner", StudentId = 1236 };

            SeralizeData(studentOne, DataType.Binary, 0, ref formatterBinary, ref formatterXML);
            SeralizeData(studentTwo, DataType.XML, 1, ref formatterBinary, ref formatterXML);
            SeralizeData(studentThree, DataType.JSON, 2, ref formatterBinary, ref formatterXML);

            StreamReader sr1 = new StreamReader(@"C:\Users\micha\OneDrive\Desktop\TestData\testfile_0.txt");
            StreamReader sr2 = new StreamReader(@"C:\Users\micha\OneDrive\Desktop\TestData\testfile_1.txt");
            StreamReader sr3 = new StreamReader(@"C:\Users\micha\OneDrive\Desktop\TestData\testfile_2.txt");

            Console.WriteLine("____________________Serialized Data____________________");
            Console.WriteLine("File One:");
            Console.WriteLine(sr1.ReadToEnd());

            Console.WriteLine("File Two:");
            Console.WriteLine(sr2.ReadToEnd());

            Console.WriteLine("File Three:");
            Console.WriteLine(sr3.ReadToEnd());

            Console.WriteLine("\n___________________Deserialized Data___________________");
            Console.WriteLine("Object One:");
            PrintObject(DeserializeData(0, DataType.Binary, ref formatterBinary, ref formatterXML));

            Console.WriteLine("\nObject Two:");
            PrintObject(DeserializeData(1, DataType.XML, ref formatterBinary, ref formatterXML));

            Console.WriteLine("\nObject Three:");
            PrintObject(DeserializeData(2, DataType.JSON, ref formatterBinary, ref formatterXML));

            Console.ReadKey();

            sr1.Close();
            sr2.Close();
            sr3.Close();

            File.Delete(@"C:\Users\micha\OneDrive\Desktop\TestData\testfile_0.txt");
            File.Delete(@"C:\Users\micha\OneDrive\Desktop\TestData\testfile_1.txt");
            File.Delete(@"C:\Users\micha\OneDrive\Desktop\TestData\testfile_2.txt");
        }

        public static void SeralizeData(Student student, DataType type, int fileNumber, ref IFormatter formatterBinary, ref IFormatter formatterXML)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                string filePath = @"C:\Users\micha\OneDrive\Desktop\TestData\" + $"testfile_{fileNumber}.txt";
                FileStream buffer = File.Create(filePath);

                switch (type)
                {
                    case DataType.Binary:
                        formatterBinary.Serialize(buffer, student);
                        break;
                    case DataType.XML:
                        formatterXML.Serialize(buffer, student);
                        break;
                    case DataType.JSON:
                        buffer.Close();
                        File.AppendAllText(filePath, JsonSerializer.Serialize(student));
                        return;
                }

                buffer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }

        public static Student DeserializeData(int fileNumber, DataType type, ref IFormatter formatterBinary, ref IFormatter formatterXML)
        {
            Student student = new Student();

            try
            {
                string filePath = (@"C:\Users\micha\OneDrive\Desktop\TestData\" + $"testfile_{fileNumber}.txt");
                FileStream buffer = File.OpenRead(filePath);

                switch (type)
                {
                    case DataType.Binary:
                        student = formatterBinary.Deserialize(buffer) as Student;
                        break;
                    case DataType.XML:
                        student = formatterXML.Deserialize(buffer) as Student;
                        break;
                    case DataType.JSON:
                        buffer.Close();
                        Student student1 = JsonSerializer.Deserialize<Student>(File.ReadAllText(filePath));
                        return student1;
                }

                buffer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }


            return student;
        }

        public static void PrintObject(Student student)
        {
            Console.WriteLine($"First Name: {student.FirstName}");
            Console.WriteLine($"Last Name: {student.LastName}");
            Console.WriteLine($"Student ID: {student.StudentId}");
        }
    }

    [Serializable]
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentId { get; set; }
    }
}