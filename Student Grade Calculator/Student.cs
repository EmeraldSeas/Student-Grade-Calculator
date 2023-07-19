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
        public int id { get; }
        public string name { get; }
        public int englishScore { get; }
        public int algebraScore { get; }
        public int biologyScore { get; }
        public int csScore { get; }
        public int psychologyScore { get; }
        public int finalScore { get; }
        public string letterScore { get; }


        public Student(string name, int englishScore, int algebraScore, int biologyScore, int csScore, int psyschologyScore)
        {
            this.id = new Random().Next(10000, 99999);
            this.name = name;
            this.englishScore = englishScore;
            this.algebraScore = algebraScore;
            this.biologyScore = biologyScore;
            this.csScore = csScore;
            this.psychologyScore = psyschologyScore;
            this.finalScore = calcScore(this.englishScore, this.algebraScore, this.biologyScore, this.csScore, this.psychologyScore);


            switch (this.finalScore)
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

        public int calcScore(int englishScore, int algebraScore, int biologyScore, int csScore, int psychologyScore)
        {
            int eValue = englishScore * 3;
            int aValue = algebraScore * 3;
            int bValue = biologyScore * 4;
            int cValue = csScore * 4;
            int pValue = psychologyScore * 3;
            return (eValue + aValue + bValue + cValue + pValue) / 17;
        }
    }
}