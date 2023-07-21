namespace Student_Grade_Calculator
{
    internal class Student
    {
        internal int Id { get; }
        internal string Name { get; }
        internal int FinalScore { get; }
        internal string LetterScore { get; }
        private List<StudentClasses> classList = new List<StudentClasses>(); // list to keep track of a student's classes
        
        public Student(string name, params StudentClasses[] newClass) // student constructor that accepts an arbitrary number of StudentClasses objects
        {
            Id = new Random().Next(10000, 99999);
            this.Name = name;
            foreach (StudentClasses newClasses in newClass)
            {
                classList.Add(newClasses);
            }
            
            FinalScore = CalcScore();
            
            switch (this.FinalScore) // converts student's final numerical Grade to a letter Grade
            {
                case >= 90:
                    this.LetterScore = "A";
                    break;
                case >= 80:
                    this.LetterScore = "B";
                    break;
                case >= 70:
                    this.LetterScore = "C";
                    break;
                case >= 60:
                    this.LetterScore = "D";
                    break;
                case < 60:
                    this.LetterScore = "F";
                    break;
                default:
                    this.LetterScore = "Error";
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
    }
    
    internal class StudentClasses // class object for keeping a class' Name, Grade value, and credit weight
    {
        internal string Name { get; }
        internal int Grade { get; }
        internal int Credits { get; }

        public StudentClasses(string name, int grade, int credits)
        {
            this.Name = name;
            this.Grade = grade;
            this.Credits = credits;
        }
    }
}

// TODO: add a GUI