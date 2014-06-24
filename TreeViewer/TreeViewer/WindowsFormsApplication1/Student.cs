class Student
{
    private string Name;
    private string Subject;
    private int Score;
    public Student(string Name, string Subject, int Score)
    {
        this.Name = Name;
        this.Subject = Subject;
        this.Score = Score;
    }
    public string GetName()
    {
        return Name;
    }
    public string GetSubject()
    {
        return Subject;
    }
    public int GetScore()
    {
        return Score;
    }
}