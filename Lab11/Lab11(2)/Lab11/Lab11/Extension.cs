namespace Lab11
{
    public static class Extension
    {
        public static List<Student> FindStudent(List<Student> students,
            Student.StudentPredicateDelegate studentPredicateDelegate)
        {
            List<Student> findStudent = new();
            foreach (var student in students)
            {
                bool result = studentPredicateDelegate.Invoke(student);
                if (result)
                {
                    findStudent.Add(student);
                }
            }

            return findStudent;
        }
    }
}