namespace assginment
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        { }

        class Person
        {
            public string Name;
            public string Email;

            public Person(string name, string email)
            {
                Console.WriteLine("Person constructor");
                Name = name;
                Email = email;
            }

            public void DisplayBasicInfo()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Email: " + Email);
            }
        }

        class Student : Person
        {
            public string StudentId;
            public double GPA;

            public Student(string name, string email, string id, double gpa)
                : base(name, email)
            {
                Console.WriteLine("Student constructor");
                StudentId = id;
                GPA = gpa;
            }

            public void Study()
            {
                Console.WriteLine("Student is studying");
            }
        }

        class Employee : Person
        {
            public string EmployeeId;
            public double Salary;

            public Employee(string name, string email, string id, double salary)
                : base(name, email)
            {
                Console.WriteLine("Employee constructor");
                EmployeeId = id;
                Salary = salary;
            }
        }

        class Teacher : Employee
        {
            public string CourseName;

            public Teacher(string name, string email, string id, double salary, string course)
                : base(name, email, id, salary)
            {
                Console.WriteLine("Teacher constructor");
                CourseName = course;
            }

            public void Teach()
            {
                Console.WriteLine("Teacher is teaching " + CourseName);
            }


            class Program
            {
                static void Main()
                {
                    Student s = new Student("Ahmed", "ahmed@gmail.com", "S101", 3.5);

                    Console.WriteLine();
                    s.DisplayBasicInfo();
                    s.Study();

                    Console.WriteLine();

                    Teacher t = new Teacher("Ali", "ali@gmail.com", "E101", 5000, "C#");

                    Console.WriteLine();
                    t.DisplayBasicInfo();
                    t.Teach();
                }
            }

            }
        }
    }