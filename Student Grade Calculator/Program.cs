using Student_Grade_Calculator;

Student sneed = new Student("Sneed", new StudentClasses("Biology I", 89, 3), new StudentClasses("Computer Science", 96, 4));
Student jimbo = new Student("Jimbo", new StudentClasses("Biology I", 76, 3), new StudentClasses("Computer Science", 88, 4));
Student chuck = new Student("Chuck", new StudentClasses("Biology I", 82, 3), new StudentClasses("Computer Science", 91, 4));

Console.WriteLine($"Student Name: {sneed.Name}, ID: {sneed.Id}, Final Grade: {sneed.FinalScore}, Letter Grade: {sneed.LetterScore}");
sneed.PrintString();
Console.WriteLine($"Student Name: {jimbo.Name}, ID: {jimbo.Id}, Final Grade: {jimbo.FinalScore}, Letter Grade: {jimbo.LetterScore}");
jimbo.PrintString();
Console.WriteLine($"Student Name: {chuck.Name}, ID: {chuck.Id}, Final Grade: {chuck.FinalScore}, Letter Grade: {chuck.LetterScore}");
jimbo.PrintString();