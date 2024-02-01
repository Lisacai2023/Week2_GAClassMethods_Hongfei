using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_GAClassMethods_Hongfei
{
    //Hongfei
    //Week2_GAClassMethods
    //01/18/2024
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> samGrades = new List<int> { 95, 87, 88, 90, 75 };
            Student samStudent = new Student("Sam", samGrades);

            //test AddGrade method
            samStudent.AddGrade(70);
            samStudent.AddGrade(125);
            samStudent.AddGrade(-98);

            samStudent.DisplayAllGrades();
            samStudent.GetGrade();
            samStudent.DiplayStudentInfo();

            //Generage random students and add students list
            

            List<Student> randomStudents = GenerateRandomStudents();
            //Add student to this list 
            randomStudents.Add(samStudent);

            //Loop and display all the info
            foreach(Student student in randomStudents) 
            {
                student.DiplayStudentInfo();
            }

            Console.ReadKey();
        }
        static List<Student> GenerateRandomStudents()
        {
            List<Student> students = new List<Student>();
            //Random object created
            Random random = new Random();
            for (int i = 1; i <=5; i++)
            {
                //Create new instance with student name value
                Student student = new Student($"Student{i}");
                for (int j = 0; j<5; j++)
                {
                    //Add random score into student score list
                    student.ExamScoures.Add(random.Next(0, 101));
                }
                //Each of student with 5 exam scores add students list
                students.Add(student);
            }
            return students;
        }





    }
}
