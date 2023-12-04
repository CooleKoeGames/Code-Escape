using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<Question> questionAndAnswers;
    public GameObject[] options;
    private int currentQuestion;

    public GameObject QuizPanel;
    public GameObject GameOverPanel;

    public TextMeshProUGUI questionText;
    public TextMeshProUGUI scoreText;

    private int totalQuestions = 0;
    private int score;

    private void Start()
    {
        totalQuestions = questionAndAnswers.Count;
        GameOverPanel.SetActive(false);
        GenerateQuestion();
    }

    private void GameOver()
    {
        QuizPanel.SetActive(false);
        GameOverPanel.SetActive(true);
        scoreText.text = score + "/" + totalQuestions;
    }

    public void Correct()
    {
        score += 1;
        questionAndAnswers.RemoveAt(currentQuestion);
        StartCoroutine(WaitForNext());
    }

    public void Wrong()
    {
        //questionAndAnswers.RemoveAt(currentQuestion);
        //StartCoroutine(WaitForNext());
    }

    private IEnumerator WaitForNext()
    {
        yield return new WaitForSeconds(1);
        GenerateQuestion();
    }

    private void SetAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Image>().color = options[i].GetComponent<Answer>().startColor;
            options[i].GetComponent<Answer>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = questionAndAnswers[currentQuestion].answers[i];

            if (questionAndAnswers[currentQuestion].correctAnswer == i + 1)
            {
                options[i].GetComponent<Answer>().isCorrect = true;
            }
        }
    }

    private void GenerateQuestion()
    {
        if (questionAndAnswers.Count > 0)
        {
            currentQuestion = Random.Range(0, questionAndAnswers.Count);

            questionText.text = questionAndAnswers[currentQuestion].question;
            SetAnswer();
        }
        else
        {
            GameOver();
        }
    }
}