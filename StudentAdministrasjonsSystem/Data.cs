using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonsSystem
{
    internal class Data
    {
        public static List<Student> studentList = new List<Student>();
        public static List<Subject> subjectList = new List<Subject>();
        public static List<Grade> gradeList = new List<Grade>();

        public void GenerateData()
        {
            GenerateSubject(new Subject(2289, "Math", 60));
            GenerateSubject(new Subject(2243, "Physics", 30));
            GenerateSubject(new Subject(2269, "English", 90));

            GenerateStudent(new Student("Jacob", 22, "Math, Physics", 228839));
            GenerateStudent(new Student("Lilly", 19, "Math, Physics, English", 191441));

            GenerateGrade(new Grade(studentList[0], subjectList[0], 5));
            GenerateGrade(new Grade(studentList[0], subjectList[1], 6));
            GenerateGrade(new Grade(studentList[1], subjectList[0], 6));
            GenerateGrade(new Grade(studentList[1], subjectList[1], 5));
            GenerateGrade(new Grade(studentList[1], subjectList[2], 1));
        }

        void GenerateSubject(Subject subject)
        {
            subjectList.Add(subject);
        }

        void GenerateStudent(Student student)
        {
            studentList.Add(student);
        }

        void GenerateGrade(Grade grade)
        {
            gradeList.Add(grade);
        }

        void InitStudents()
        {
            Console.WriteLine("\nStudents:");
            foreach (Student student in studentList)
            {
                student.OutputInfo();
            }
        }

        void InitSubjects()
        {
            Console.WriteLine("\nSubjects:");
            foreach (Subject subject in subjectList)
            {
                subject.OutputInfo();
            }
        }

        void InitGrades()
        {
            Console.WriteLine("\nGrades:");
            foreach (Grade grade in gradeList)
            {
                grade.OutputInfo();
            }
        }

        void InitAverage()
        {
            Console.WriteLine("\nAverages:");
            foreach (Student student in studentList)
            {
                float averageGrades = student.CalculateAverage();
                Console.WriteLine($"{student.Name} has an average grade score of {averageGrades}");
            }
        }

        void InitTotalCredits()
        {
            Console.WriteLine("\nTotal Credits:");
            foreach (Student student in studentList)
            {
                int totalCredits = student.CalculateTotalCredits();
                Console.WriteLine($"{student.Name} has {totalCredits} total credits");
            }
        }
        public void InitAll()
        {
            InitStudents();
            InitSubjects();
            InitGrades();
            InitAverage();
            InitTotalCredits();
        }
    }
}
