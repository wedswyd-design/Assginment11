namespace ConsoleApp1
{ 
    using System;
using System.Collections.Generic;
    using System.Runtime.InteropServices;

    internal class Program
    {
        static void Main(string[] args)
        {
        }


            class Person
        {
            public string Name;

            public Person(string name)
            {
                Name = name;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine("Name: " + Name);
            }
        }
        class Teacher : Person
        {
            public string CourseName;
            public Teacher(string name, string course) : base(name)
            {
                CourseName = course;
            }


            class Student : Person
            {
                public string StudentId;

                public Student(string name, string id) : base(name)
                {
                    StudentId = id;
                }

                public override void DisplayInfo()
                {
                    Console.WriteLine("Student: " + Name + ", ID: " + StudentId);
                }
            }

            class Employee : Person
            {
                public double Salary;

                public Employee(string name, double salary) : base(name)
                {
                    Salary = salary;
                }

                public override void DisplayInfo()
                {
                    Console.WriteLine($"Employee: {Name}, Salary: {Salary} ");

                }


                class Teacher : Person
                {
                    public string CourseName;

                    public Teacher(string name, string course) : base(name)
                    {
                        CourseName = course;
                    }

                    public override void DisplayInfo()
                    {
                        Console.WriteLine($"Teacher:{Name},Course:{CourseName}");
                    }
                }

                class Program
                {
                    static void ShowPerson(Person p)
                    {
                        p.DisplayInfo();
                    }

                    static void Main()
                    {
                        List<Person> people = new List<Person>();

                        people.Add(new Student("Ahmed", "123"));
                        people.Add(new Employee("Ali", 5000));
                        people.Add(new Teacher("Sara", "C#"));

                        foreach (Person p in people)
                        {
                            p.DisplayInfo();
                            Console.WriteLine(p.GetType().Name);
                        }

                        ShowPerson(people[0]);

                    }
                }


            }

        }
    


        }
    
}
