using UnityEngine;
using UnityEngine.UI;

public class QuizUIManager : MonoBehaviour
{
    public QuizManager quizManager;
    public Text questionText;
    public Image background;

    int currentQuestionIndex = 0;

    void Start()
    {
        SetQuestion();
    }

    void SetQuestion()
    {
        if (currentQuestionIndex >= quizManager.questions.Length)
        {
            //  огда все вопросы из списка отвечены...
            return;
        }

        Question question = quizManager.questions[currentQuestionIndex];
        questionText.text = question.question;
        background.sprite = Resources.Load<Sprite>(question.background);

        

        currentQuestionIndex++;
    }
}
