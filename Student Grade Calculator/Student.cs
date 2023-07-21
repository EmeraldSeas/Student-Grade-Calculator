using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grade_Calculator
{
    internal class Student
    {
        internal int id { get; }
        internal string name { get; }
        internal int finalScore { get; }
        internal string letterScore { get; }
        private List<StudentClasses> classList = new List<StudentClasses>(); // list to keep track of a student's classes
        
        public Student(string name, params StudentClasses[] newClass) // student constructor that accepts an arbitrary number of StudentClasses objects
        {
            id = new Random().Next(10000, 99999);
            this.name = name;
            foreach (StudentClasses newClasses in newClass)
            {
                classList.Add(newClasses);
            }
            
            finalScore = calcScore();
            
            switch (this.finalScore) // converts student's final numerical grade to a letter grade
            {
                case >= 90:
                    this.letterScore = "A";
                    break;
                case >= 80:
                    this.letterScore = "B";
                    break;
                case >= 70:
                    this.letterScore = "C";
                    break;
                case >= 60:
                    this.letterScore = "D";
                    break;
                case < 60:
                    this.letterScore = "F";
                    break;
                default:
                    this.letterScore = "Error";
                    break;
            }
        }

        public void addClass(StudentClasses newStudentClass) // method to add classes to an already existing student's list
        {
            classList.Add(newStudentClass);
        }

        public int calcScore() // calculate total score by iterating through a student's classList
        {
            int GPA = 0;
            int totalCredits = 0;
            foreach (StudentClasses classScore in classList) // iterates through the classList
            {
                GPA += classScore.grade * classScore.credits;
                totalCredits += classScore.credits;
            }

            if (totalCredits > 0) // simple if/else to prevent any division by zero
            {
                return GPA / totalCredits;
            }
            else
            {
                return 0;
            }
        }

        public void toString() // prints out a student's classes with respective grades and credit weights
        {
            foreach (StudentClasses curClass in classList)
            {
                Console.WriteLine($"Class name: {curClass.name}, Current grade: {curClass.grade}, Credit weight: {curClass.credits}");
            }
        }
    }
    
    internal class StudentClasses // class object for keeping a class' name, grade value, and credit weight
    {
        internal string name { get; }
        internal int grade { get; }
        internal int credits { get; }

        public StudentClasses(string name, int grade, int credits)
        {
            this.name = name;
            this.grade = grade;
            this.credits = credits;
        }
    }
}

// TODO: add a GUI