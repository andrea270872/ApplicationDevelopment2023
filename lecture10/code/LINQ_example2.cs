using static System.Formats.Asn1.AsnWriter;

namespace LINQ_example2
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public GradeLevel? Year { get; set; }
        public List<int> ExamScores { get; set; }

        public Student(string FirstName, string LastName, int ID, GradeLevel Year, List<int> ExamScores)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.ID = ID;
            this.Year = Year;
            this.ExamScores = ExamScores;
        }

        public Student(string FirstName, string LastName, int StudentID, List<int>? ExamScores = null)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            ID = StudentID;
            this.ExamScores = ExamScores ?? Enumerable.Empty<int>().ToList();
        }
    }

    enum GradeLevel
    {
        FirstYear = 1,
        SecondYear,
        ThirdYear,
        FourthYear
    };



    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new(){
                    new(
                        FirstName: "Terry", LastName: "Adams", ID: 120,
                        Year: GradeLevel.SecondYear,
                        ExamScores: new() { 99, 82, 81, 79 }
                    ),
                    new(
                        "Fadi", "Fakhouri", 116,
                        GradeLevel.ThirdYear,
                        new() { 99, 86, 90, 94 }
                    ),
                    new(
                        "Hanying", "Feng", 117,
                        GradeLevel.FirstYear,
                        new() { 93, 92, 80, 87 }
                    ),
                    new(
                        "Cesar", "Garcia", 114,
                        GradeLevel.FourthYear,
                        new() { 97, 89, 85, 82 }
                    ),
                    new(
                        "Debra", "Garcia", 115,
                        GradeLevel.ThirdYear,
                        new() { 35, 72, 91, 70 }
                    ),
                    new(
                        "Hugo", "Garcia", 118,
                        GradeLevel.SecondYear,
                        new() { 92, 90, 83, 78 }
                    ),
                    new(
                        "Sven", "Mortensen", 113,
                        GradeLevel.FirstYear,
                        new() { 88, 94, 65, 91 }
                    ),
                    new(
                        "Claire", "O'Donnell", 112,
                        GradeLevel.FourthYear,
                        new() { 75, 84, 91, 39 }
                    ),
                    new(
                        "Svetlana", "Omelchenko", 111,
                        GradeLevel.SecondYear,
                        new() { 97, 92, 81, 60 }
                    ),
                    new(
                        "Lance", "Tucker", 119,
                        GradeLevel.ThirdYear,
                        new() { 68, 79, 88, 92 }
                    ),
                    new(
                        "Michael", "Tucker", 122,
                        GradeLevel.FirstYear,
                        new() { 94, 92, 91, 91 }
                    ),
                    new(
                        "Eugene", "Zabokritski", 121,
                        GradeLevel.FourthYear,
                        new() { 96, 85, 91, 60 }
                    )
            };

            // searching in the list of students ...
            int exam = 1;
            int score = 90;
            var highScores =
                from student in students
                where student.ExamScores[exam] > score
                select new
                {
                    Name = student.FirstName,
                    Score = student.ExamScores[exam]
                };

            foreach (var item in highScores)
            {
                Console.WriteLine(string.Format("name {0}, score {1}",item.Name,item.Score));
            }

        }
    }
}