using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;

    public Color startColor;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    //private void Start()
    //{
    //    startColor = GetComponent<Image>().color;
    //}

    public void AnswerCheck()
    {
        if (isCorrect)
        {
            GetComponent<Image>().color = Color.green;
            audioManager.PlayQuizAudio(audioManager.correct);
            quizManager.Correct();
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            audioManager.PlayQuizAudio(audioManager.wrong);
            //quizManager.Wrong();
        }
    }
}