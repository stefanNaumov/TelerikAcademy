using System;

public class CSharpExam : Exam
{
    public int Score { get; private set; }

    public CSharpExam(int score)
    {
        if (score < 0)
        {
            throw new ArgumentException("Score cannot be a negative number!");
        }
        if (score > 100)
        {
            throw new ArgumentException("Score cannot have a value greater than 100!");
        }
        this.Score = score;
    }

    public override ExamResult Check()
    {

       return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }
}
