namespace Student_Grade_Calculator
{
    internal class Student
    {
        internal int Id;
        internal string Name;
        internal int FinalScore;
        internal string LetterScore { get; }
        private List<StudentClasses> classList = new List<StudentClasses>(); // list to keep track of a student's classes
        
        public Student(string name, params StudentClasses[] newClass) // student constructor that accepts an arbitrary number of StudentClasses objects
        {
            Id = new Random().Next(10000, 99999);
            Name = name;
            foreach (StudentClasses newClasses in newClass)
            {
                classList.Add(newClasses);
            }
            
            FinalScore = CalcScore();
            
            switch (FinalScore) // converts student's final numerical Grade to a letter Grade
            {
                case >= 90:
                    LetterScore = "A";
                    break;
                case >= 80:
                    LetterScore = "B";
                    break;
                case >= 70:
                    LetterScore = "C";
                    break;
                case >= 60:
                    LetterScore = "D";
                    break;
                case < 60:
                    LetterScore = "F";
                    break;
                default:
                    LetterScore = "Error";
                    break;
            }
        }

        public void AddClass(StudentClasses newStudentClass) // method to add classes to an already existing student's list
        {
            classList.Add(newStudentClass);
        }

        private int CalcScore() // calculate total score by iterating through a student's classList
        {
            int gpa = 0;
            int totalCredits = 0;
            foreach (StudentClasses classScore in classList) // iterates through the classList
            {
                gpa += classScore.Grade * classScore.Credits;
                totalCredits += classScore.Credits;
            }

            if (totalCredits > 0) // simple if/else to prevent any division by zero
            {
                return gpa / totalCredits;
            }
            else
            {
                return 0;
            }
        }

        public void PrintString() // prints out a student's classes with respective grades and credit weights
        {
            foreach (StudentClasses curClass in classList)
            {
                Console.WriteLine($"Class Name: {curClass.Name}, Current Grade: {curClass.Grade}, Credit Weight: {curClass.Credits}");
            }
        }

        public void ChangeGrade(string name, int grade) // method to search for a class belonging to a student and change their grade
        {
            // use List's inbuilt Find method to match the name argument to Name in StudentClasses
            // use String's Equals method with StringComparison set to OrdinalIgnoreCase to make the search case-insensitive
            // match strings, find specific class instance in classList, call its SetGrade
            classList.Find(x => name.Equals(x.Name, StringComparison.OrdinalIgnoreCase)).SetGrade(grade);
        }
    }
    
    internal class StudentClasses // class object for keeping a class' Name, Grade value, and credit weight
    {
        internal string Name;
        internal int Grade;
        internal int Credits;

        public StudentClasses(string name, int grade, int credits)
        {
            this.Name = name;
            switch (grade) // clamps grade values
            {
                case <= 100 and >= 0:
                    Grade = grade;
                    break;
                case > 100:
                    Grade = 100;
                    break;
                case < 0:
                    Grade = 0;
                    break;
            }
            this.Credits = credits;
        }

        public void SetGrade(int grade) // setter so a student's grades can be changed after initialization
        {
            switch (grade) // clamps grade values
            {
                case <= 100 and >= 0:
                    Grade = grade;
                    break;
                case > 100:
                    Grade = 100;
                    break;
                case < 0:
                    Grade = 0;
                    break;
            }
        }
    }
}

// TODO: add a GUI