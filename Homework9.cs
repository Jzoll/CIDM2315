using System;

namespace Homework9
{
    class Program{
    static void Main(string[] args)
        {
            Student aStud = new Student(111,"Alice");
            Student bStud = new Student(222,"Bob");
            Student cStud = new Student(333,"Cathy");
            Student dStud = new Student(444,"David");

            Dictionary<string, double> gradebook = new Dictionary<string,double>();
            gradebook.Add("Alice", 4.0);
            gradebook.Add("Bob", 3.6);
            gradebook.Add("Cathy", 2.5);
            gradebook.Add("David", 1.8);

                if (!gradebook.ContainsKey("Tom"))
                {
                    gradebook.Add("Tom", 3.3);
                }

                double totalGPA = 0;
                foreach (var gpa in gradebook.Values)
                {
                    totalGPA += gpa;
                }

                double avgGPA = totalGPA / gradebook.Count;
                Console.WriteLine("The average GPA is: " + avgGPA);


                foreach (Student student in Student.studentList)
                {
                    if (gradebook.ContainsKey(student.getStudName()) && gradebook[student.getStudName()] > avgGPA)
                    {
                        Console.WriteLine("Student ID: {0}, Name: {1}", student.getStudentID(), student.getStudName());
                    }
                }



        }
    }

        class Student
    {
        private int studentID;
        private string studentName;
        public void PrintInfo()
        {
        Console.WriteLine("Student ID: " + studentID);
        Console.WriteLine("Student Name: " + studentName);
        } 
        public static List<Student> studentList = new List<Student>();
        public Student(int id, string name)
        {
        studentID = id;
        studentName = name;
        studentList.Add(this);
        }

        public string getStudName()
        {
        return studentName;
        }
        public int getStudentID()
        {
        return studentID;
        }

        
    }


}