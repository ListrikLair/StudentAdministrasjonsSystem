using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonsSystem
{
    internal class Subject
    {
        public int Code;
        public string Name;
        public int Credits;

        public Subject(int code, string name, int credits)
        {
            Code = code;
            Name = name;
            Credits = credits;
        }

        public void OutputInfo()
        {
            Console.WriteLine($"Subject name: {this.Name} \nSubject code: {this.Code} \nCredits: {this.Credits}");
        }
    }
}
