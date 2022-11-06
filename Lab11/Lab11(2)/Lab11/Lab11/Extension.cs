namespace Lab11
{
    public static class Extension
    {
        private static readonly List<Student> Students = new();

        public static List<Student> FindStudent(List<Student> students,
            Student.StudentPredicateDelegate studentPredicateDelegate)
        {
            foreach (var student in students)
            {
                bool result = studentPredicateDelegate.Invoke(student);
                if (result)
                {
                    Students.Add(student);
                }
            }

            return Students;
        }
    }
}