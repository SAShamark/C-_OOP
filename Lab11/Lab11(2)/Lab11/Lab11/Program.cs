namespace Lab11
{
    public static class Program
    {
        private static readonly Random Random = new();

        private static void Main()
        {
            var students = new List<Student>
            {
                new Student("Qafnir", "Ak", Random.Next(1, 50)),
                new Student("Andrew", "Blbeck", Random.Next(1, 50)),
                new Student("Andrew", "Vlbeck", Random.Next(1, 50)),
                new Student("Andrew", "Clbeck", Random.Next(1, 50)),
                new Student("Dafnir", "Dlbeck", Random.Next(1, 50)),
                new Student("Eafnir", "Troelsen", Random.Next(1, 50)),
                new Student("Aafnir", "Flbeck", Random.Next(1, 50)),
                new Student("Gafnir", "Troelsen", Random.Next(1, 50)),
                new Student("Aafnir", "Troelsen", Random.Next(1, 50)),
                new Student("Iafnir", "Troelsen", Random.Next(1, 50))
            };

            SelectionOfStudentsType1(students);
            SelectionOfStudentsType2(students);
        }

        private static void SelectionOfStudentsType1(List<Student> students)
        {
            bool StudentPredicateDelegateAge(Student student)
            {
                return student.CheckAge(18, int.MaxValue);
            }

            bool StudentPredicateDelegateFirstNameFirstLatter(Student student)
            {
                return student.CheckFirstNameFirstLetter('A');
            }

            bool StudentPredicateDelegateLastName(Student student)
            {
                return student.CheckLastNameLenght(3);
            }

            var studentsAge = Extension.FindStudent(students, StudentPredicateDelegateAge);
            var studentsFirstName = Extension.FindStudent(students, StudentPredicateDelegateFirstNameFirstLatter);
            var studentsLastName = Extension.FindStudent(students, StudentPredicateDelegateLastName);
            PrintInfoAboutStudents(studentsAge, studentsFirstName, studentsLastName);
        }

        private static void SelectionOfStudentsType2(List<Student> students)
        {
            bool StudentPredicateDelegateAge(Student student)
            {
                return student.CheckAge(20, 25);
            }

            bool StudentPredicateDelegateFirstName(Student student)
            {
                return student.CheckAllFirstName("Andrew");
            }

            bool StudentPredicateDelegateLastName(Student student)
            {
                return student.CheckAllLastName("Troelsen");
            }

            var studentsAge = Extension.FindStudent(students, StudentPredicateDelegateAge);
            var studentsFirstName = Extension.FindStudent(students, StudentPredicateDelegateFirstName);
            var studentsLastName = Extension.FindStudent(students, StudentPredicateDelegateLastName);

            PrintInfoAboutStudents(studentsAge, studentsFirstName, studentsLastName);
        }

        private static void PrintInfoAboutStudents(List<Student> studentsAge, List<Student> studentsFirstName,
            List<Student> studentsLastName)
        {
            for (int i = 0; i < studentsAge.Count; i++)
            {
                var student = studentsAge[i];
                Console.WriteLine(i + "- Age: " + student.Age);
            }

            Console.WriteLine();
            for (int i = 0; i < studentsFirstName.Count; i++)
            {
                var student = studentsFirstName[i];
                Console.WriteLine(i + "- First name: " + student.FirstName);
            }

            Console.WriteLine();

            for (int i = 0; i < studentsLastName.Count; i++)
            {
                var student = studentsLastName[i];
                Console.WriteLine(i + "- Last name: " + student.LastName);
            }

            Console.WriteLine();
        }
    }
}