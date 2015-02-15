using System;

public class ExamResult
{
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("The grade cannot be negative number!");
        }

        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("The minimum grade cannot be negative number!");
        }

        if (maxGrade < minGrade)
        {
            throw new ArgumentException("The minimum grade should not be bigger than the maximal grade");
        }

        if (comments == null || comments == string.Empty)
        {
            throw new ArgumentNullException("Comments are obligatory!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade { get; private set; }

    public int MinGrade { get; private set; }

    public int MaxGrade { get; private set; }

    public string Comments { get; private set; }
}