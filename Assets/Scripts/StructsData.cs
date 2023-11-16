[System.Serializable]
public struct Answer
{
    public string text;
    public bool correct;
}

[System.Serializable]
public struct Question
{
    public string question;
    public Answer[] answers;
    public string background;
}
