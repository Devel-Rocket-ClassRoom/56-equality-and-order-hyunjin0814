using System;

class Student : IComparable<Student>
{
    private string Name;
    private int Grade;
    private int Score;

    public Student(string name, int grade, int score)
    {
        this.Name = name;
        this.Grade = grade;
        this.Score = score;
    }

    public int CompareTo(Student other)
    {
        if (other == null)
        {
            return 1;
        }

        int result = Grade.CompareTo(other.Grade);
        if (result != 0)
        {
            return result;
        }

        result = other.Score.CompareTo(Score);
        if (result != 0)
        {
            return result;
        }

        return Name.CompareTo(other.Name);
    }

    public override string ToString()
    {
        return $"{Grade}학년 {Name} ({Score}점)";
    }
}