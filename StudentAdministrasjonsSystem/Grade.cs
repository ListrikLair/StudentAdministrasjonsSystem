using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonsSystem
{
    internal class Grade
    {
        public Student Student;
        public Subject Subject;
        public int CharacterValue;

        public Grade(Student student, Subject subject, int characterValue)
        {
            Student = student;
            Subject = subject;
            CharacterValue = characterValue;
        }

        public void OutputInfo()
        {
            Console.WriteLine($"Student name: {this.Student.Name} \nSubject: {this.Subject.Name} \nGrade: {this.CharacterValue}");
        }
    }
}
