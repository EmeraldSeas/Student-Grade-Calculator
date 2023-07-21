using Student_Grade_Calculator;

Student sneed = new Student("Sneed", new StudentClasses("Biology I", 89, 3), new StudentClasses("Computer Science", 96, 4));
Student jimbo = new Student("Jimbo", new StudentClasses("Biology I", 76, 3), new StudentClasses("Computer Science", 88, 4));
Student chuck = new Student("Chuck", new StudentClasses("Biology I", 82, 3), new StudentClasses("Computer Science", 91, 4));

Console.WriteLine($"Student name: {sneed.name}, ID: {sneed.id}, Final grade: {sneed.finalScore}, Letter grade: {sneed.letterScore}");
sneed.toString();
Console.WriteLine($"Student name: {jimbo.name}, ID: {jimbo.id}, Final grade: {jimbo.finalScore}, Letter grade: {jimbo.letterScore}");
jimbo.toString();
Console.WriteLine($"Student name: {chuck.name}, ID: {chuck.id}, Final grade: {chuck.finalScore}, Letter grade: {chuck.letterScore}");
jimbo.toString();