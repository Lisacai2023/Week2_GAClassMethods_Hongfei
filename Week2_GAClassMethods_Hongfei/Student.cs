using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_GAClassMethods_Hongfei
{
    //field
    public class Student
    {
        public string name;
        public List<int> examScoures = new List<int>();

        //properties 
        public string Name { get => name; set => name = value; }
        public List<int> ExamScoures { get => examScoures; set => examScoures=value; }

        public Student(string name)
        {
            Name=name;
            ExamScoures = new List<int>();
        }

        public Student(string name,List<int> examScoures)
        {
            Name=name;
            ExamScoures=examScoures;
        }

        //Method 1 for addding list of numerical grades score on the ExamScores list
        public void AddGrade(int grade)
        {
            //Add validation, only allow 0-100 scores can add to the list
            if (grade >0 && grade <= 100)
            {
                //validation input sorce then add grade to ExamSours list
                ExamScoures.Add(grade);
                Console.WriteLine($"Add grade {grade} for {Name}");
            }
            else
            {
                //Display the informaiton why the input score couldn't add to ExamScores list
                Console.WriteLine($"Invalid grade : {grade}. Grade must be between 0 and 100.");
            }
        }

        //Method 2 for grade letter based on the grade score
        private char GetletterGrade(int score)
        {
            if (score>= 90)
            {
                return 'A';
            }
            else if (score >=80)
            {
                return 'B';
            }
            else if (score >=70)
            {
                return 'C';
            }
            else if (score >= 60)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }

        }

        //Method 3: display all the grades and grade letter realted to the student
        public void DisplayAllGrades()
        {
            //use loop to call the getting grades letter method to get each of grades letter
            //And dispay the grades letter and grade
            Console.WriteLine($" The grades for {Name}");
            for( int i=0; i < ExamScoures.Count; i++ )
            {
                //Call method 2 get grade letter
                char letterGrade = GetletterGrade(ExamScoures[i]);
                //Display 
                Console.WriteLine($" Exam {i+1} : {letterGrade} ({ExamScoures[i]})");
            }

        }

        //Method 4 for Caculating average of all the exams scores
        public double CaculateAverageScores() 
        {
            if (ExamScoures.Count == 0)
            {
                return 0;
            }
            int totalScore = 0;
            foreach ( int score in ExamScoures )
            {
                totalScore+=score;
            }
            return (double)totalScore/ ExamScoures.Count;
        }

        //Method 5 based on the average grades to get overall letter grade
        public char GetGrade()
        {
            //call method 4 get average score
            double averageScore = CaculateAverageScores();
            //Round the average score to the whole number
            int roundedAverageScore = (int)Math.Round(averageScore);
            //call method 2 to get the letter grade
            char averageLetterGrade = GetletterGrade(roundedAverageScore);
            Console.WriteLine($" The average score is {roundedAverageScore}, ({averageLetterGrade}).");
            return (GetletterGrade(roundedAverageScore));
        }

        //Method 6 Display all information including student name, average score and letter grade
        public void DiplayStudentInfo()
        {
            //Get the average score
            double averageScore = CaculateAverageScores();
            //Get the average letter grade
            char grade = GetGrade();
            //Display the student name
            Console.WriteLine($"Student Name: {Name}");
            //Display the average score
            Console.WriteLine($"Average score: {averageScore:F2}");
            //Display the final grade
            Console.WriteLine($"Grade: {grade}");

        }
    }

}
