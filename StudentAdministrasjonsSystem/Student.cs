using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using StudentAdministrasjonsSystem;

namespace StudentAdministrasjonsSystem
{
    internal class Student
    {
        public string Name;
        public int Age;
        public string StudyProgramme;
        public int StudentId;

        public Student(string name, int age, string studyProgramme, int studentId)
        {
            Name = name;
            Age = age;
            StudyProgramme = studyProgramme;
            StudentId = studentId;
        }

        public void OutputInfo()
        {
            Console.WriteLine($"Student name: {this.Name} \nAge of student: {this.Age} \nStudy Programme: {this.StudyProgramme} \nStudent ID: {this.StudentId}");
        }

        public float CalculateAverage()
        {
            int totalGrade = 0;
            int numberOfGrades = 0;
            int gradeIndex = Data.gradeList.FindIndex(r => r.Student.Name.Equals(this.Name));
            foreach (var subject in Data.subjectList)
            {
                if (StudyProgramme.Contains(subject.Name))
                {
                    totalGrade += Data.gradeList[gradeIndex].CharacterValue;
                    numberOfGrades++;
                    gradeIndex++;
                }
            }
            float averageGrade = ((float)totalGrade / numberOfGrades);
            return averageGrade;
        }

        public int CalculateTotalCredits()
        {
            int totalCredits = 0;
            foreach (var subject in Data.subjectList)
            {
                if (StudyProgramme.Contains(subject.Name))
                {
                    totalCredits += subject.Credits;
                }
            }
            return totalCredits;
        }
    }

}
