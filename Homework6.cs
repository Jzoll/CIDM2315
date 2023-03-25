using System;

namespace Homework6
{
    class Program
    {
        //Q1 Professor class
        class Professor
        {
            public string profName;
            public string classTeach;
            private double salary;
            public double salaryProp
            {
                get { return salary; }
                set { salary = value; }
            }
        }
            //Q2 Student class
            class Student
        {
            public string studentName;
            public string classEnroll;
            private double studentGrade;
            public double studentGradeProp
            {
                get { return studentGrade; }
                set { studentGrade = value; }
            }
        }
        static void Main(string[] args)
        {
            Professor aProfessor = new Professor();
            aProfessor.profName = "Alice";
            aProfessor.classTeach = "Java";
            aProfessor.salaryProp = 9000;

            Professor bProfessor = new Professor();
            bProfessor.profName = "Bob";
            bProfessor.classTeach = "Math";
            bProfessor.salaryProp = 8000;

            Student aStudent = new Student();
            aStudent.studentName = "Lisa";
            aStudent.classEnroll = "Java";
            aStudent.studentGradeProp = 90;

            Student bStudent = new Student();
            bStudent.studentName = "Tom";
            bStudent.classEnroll = "Math";
            bStudent.studentGradeProp = 80;

            //Q2 Print Results
            printProf(aProfessor.profName, aProfessor.classTeach, aProfessor.salaryProp);
            printProf(bProfessor.profName, bProfessor.classTeach, bProfessor.salaryProp);

            printStudent(aStudent.studentName, aStudent.classEnroll, aStudent.studentGradeProp);
            printStudent(bStudent.studentName, bStudent.classEnroll, bStudent.studentGradeProp);

            Console.WriteLine("The salary difference between alice and Bob is: " + (aProfessor.salaryProp - bProfessor.salaryProp));
            Console.WriteLine("The total grade of Lisa and Tom is: " + (aStudent.studentGradeProp + bStudent.studentGradeProp));
        }
        //Method to print professor information
        public static void printProf(string name, string classTeach, double salary){
            Console.WriteLine("Professor " + name + " teaches " + classTeach + ", and the salary is: " + salary);
        }
        //Method to print student information
         public static void printStudent(string name, string classEnroll, double grade){
            Console.WriteLine("Student " + name + " enrolls " + classEnroll + ", and the grade is: " + grade);
        }

    }
}