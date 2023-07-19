using Student_Grade_Calculator;

Student sneed = new Student("Sneed", 82, 66, 89, 91, 100);
Student jimbo = new Student("Jimbo", 52, 81, 99, 58, 88);
Student chuck = new Student("Chuck", 98, 90, 87, 82, 99);

Console.WriteLine($"Student name: {sneed.name}, ID: {sneed.id}, final grade: {sneed.finalScore}, letter grade: {sneed.letterScore}");
Console.WriteLine($"Student name: {jimbo.name}, ID: {jimbo.id}, final grade: {jimbo.finalScore}, letter grade: {jimbo.letterScore}");
Console.WriteLine($"Student name: {chuck.name}, ID: {chuck.id}, final grade: {chuck.finalScore}, letter grade: {chuck.letterScore}");