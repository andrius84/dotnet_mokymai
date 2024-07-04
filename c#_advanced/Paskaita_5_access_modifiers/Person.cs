using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_5_access_modifiers
{
    internal class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int Age
        {
            get { return age; }
            set { age = value; }
        }
        protected void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    internal class Student : Person
    {
        protected string name;
        protected int age;
        private string studentId { get; set; }
        protected string Name
        {
            get { return name; }
            set { name = value; }
        }
        protected int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void GetStudentId()
        {
            Console.WriteLine($"Student ID: {studentId}");
        }
    }
    internal class Teacher : Person
    {
        protected string name;
        protected int age;
        private string subject { get; set; }
        protected string Name
        {
            get { return name; }
            set { name = value; }
        }
        protected int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void GetSubject()
        {
            Console.WriteLine($"Teacher ID: {subject}");
        }
    }
}

