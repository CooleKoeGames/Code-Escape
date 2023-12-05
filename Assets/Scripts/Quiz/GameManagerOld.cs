//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using TMPro;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class GameManager : MonoBehaviour
//{
//    public Question[] questions;
//    private static List<Question> unansweredQuestions;

//    private Question currentQuestion;

//    [SerializeField] private TextMeshProUGUI questionText;

//    [SerializeField] private float timeBetweenQuestions = 1f;

//    private void Start()
//    {
//        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
//        {
//            unansweredQuestions = questions.ToList<Question>();
//        }

//        SetCurrentQuestion();
//    }

//    private void SetCurrentQuestion()
//    {
//        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
//        currentQuestion = unansweredQuestions[randomQuestionIndex];

//        questionText.text = currentQuestion.question;
//    }

//    private IEnumerator TransitionToNextQuestion()
//    {
//        unansweredQuestions.Remove(currentQuestion);

//        yield return new WaitForSeconds(timeBetweenQuestions);

//        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
//    }

//    public void UserSelectA()
//    {
//        if (currentQuestion.A)
//        {
//            Debug.Log("correct");
//        }
//        else
//        {
//            Debug.Log("wrong");
//        }

//        //StartCoroutine(TransitionToNextQuestion());
//    }

//    public void UserSelectB()
//    {
//        if (currentQuestion.B)
//        {
//            Debug.Log("correct");
//        }
//        else
//        {
//            Debug.Log("wrong");
//        }
//    }

//    public void UserSelectC()
//    {
//        if (currentQuestion.C)
//        {
//            Debug.Log("correct");
//        }
//        else
//        {
//            Debug.Log("wrong");
//        }
//    }
//}