namespace Lab11
{
    public static class Program
    {
        private static readonly Random Random = new();

        private static void Main()
        {
            var students = new List<Student>
            {
                new Student("Qafnir", "Albeck", Random.Next(1, 50)),
                new Student("Aafnir", "Blbeck", Random.Next(1, 50)),
                new Student("Bafnir", "Vlbeck", Random.Next(1, 50)),
                new Student("Cafnir", "Clbeck", Random.Next(1, 50)),
                new Student("Dafnir", "Dlbeck", Random.Next(1, 50)),
                new Student("Eafnir", "Elbeck", Random.Next(1, 50)),
                new Student("Fafnir", "Flbeck", Random.Next(1, 50)),
                new Student("Gafnir", "Glbeck", Random.Next(1, 50)),
                new Student("Hafnir", "Hlbeck", Random.Next(1, 50)),
                new Student("Iafnir", "Ilbeck", Random.Next(1, 50))
            };

            bool StudentPredicateDelegateAge(Student student)
            {
                return student.CheckAge();
            }

            bool StudentPredicateDelegateFirstName(Student student)
            {
                return student.CheckAge();
            }

            bool StudentPredicateDelegateLastName(Student student)
            {
                return student.CheckAge();
            }

            var studentsAge = Extension.FindStudent(students, StudentPredicateDelegateAge);
            var studentsFirstName = Extension.FindStudent(students, StudentPredicateDelegateFirstName);
            var studentsLastName = Extension.FindStudent(students, StudentPredicateDelegateLastName);
        }

        private static void DisplayInformation(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.Age);
            }
        }
    }

    public class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }

        public delegate bool StudentPredicateDelegate(Student student);


        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public bool CheckAge()
        {
            return Age >= 18;
        }

        public bool CheckFirstName()
        {
            return FirstName.IndexOf("А") == 0;
        }

        public bool CheckLastName()
        {
            return LastName.Length > 3;
        }
    }
}