using UnityEngine;
using System.IO;

public class QuizManager : MonoBehaviour
{
    [SerializeField] private string fileName;

    public Question[] questions;

    void Start()
    {
        ReadQuestionsFromFile();
    }

    void ReadQuestionsFromFile()
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, fileName);
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            questions = JsonUtility.FromJson<Question[]>(json);
            Debug.Log(questions.ToString());
        }
        else
        {
            Debug.LogError("File not found!");
        }
    }
}