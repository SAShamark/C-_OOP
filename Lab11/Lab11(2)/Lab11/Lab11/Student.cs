namespace Lab11;

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

    public bool CheckAge(int minAge, int maxAge)
    {
        return Age >= minAge && Age <= maxAge;
    }

    public bool CheckFirstNameFirstLetter(char congruousFirstLetter)
    {
        return FirstName.IndexOf(congruousFirstLetter) == 0;
    }

    public bool CheckAllFirstName(string congruousAllName)
    {
        return FirstName == congruousAllName;
    }

    public bool CheckAllLastName(string congruousAllName)
    {
        return LastName == congruousAllName;
    }

    public bool CheckLastNameLenght(int minNameLenght)
    {
        return LastName.Length >= minNameLenght;
    }
}