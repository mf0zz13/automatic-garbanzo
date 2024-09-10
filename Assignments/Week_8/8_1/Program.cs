using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace eight_one
{
    public enum DataType { Binary, XML, JSON };

    public class program
    {
        public static void Main(string[] args)
        {

        }

        public stat
    }

    [Serializable]
    public class Student : ISerializable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentId { get; set; }

        public Student(SerializationInfo info, StreamingContext context)
        {
            this.FirstName = info.GetValue("FirstName", typeof(string)).ToString();
            this.LastName = info.GetValue("LastName", typeof(string)).ToString();
            this.StudentId = Convert.ToInt32(info.GetValue("StudentId", typeof(int)));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("FirstName", this.FirstName);
            info.AddValue("LastName", this.LastName);
            info.AddValue("StudentId", this.StudentId);
        }

        public Student()
        {
            this.FirstName = "Unknown";
            this.LastName = "Unknown";
            this.StudentId = -1;
        }
    }
}