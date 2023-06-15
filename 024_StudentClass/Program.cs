using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_StudentClass
{
    public class Student
    {
        // 속성 prop
        public string Name { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }

        //
        private string name;
        private int age;
        public string major;

        public Student(string name, int age, string major)
        {
            this.name = name;
            this.age = age;
            this.major = major;
        }
        public void DisplayInfo()
        {
            Console.WriteLine(name + " " + age + " " + major);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("홍길동", 20, "의료IT공학");
            s.DisplayInfo();
        }
    }
}
