using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;

    public Color startColor;

    //private void Start()
    //{
    //    startColor = GetComponent<Image>().color;
    //}

    public void AnswerCheck()
    {
        if (isCorrect)
        {
            GetComponent<Image>().color = Color.green;
            quizManager.Correct();
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            //quizManager.Wrong();
        }
    }
}