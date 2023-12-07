using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartMenu()
    {
        SceneManager.LoadScene(0);
        DoorOpen.bookInRightPlace = false;
        QuizManager.quizComplete = false;
        GameManager.doorIsOpen = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);
    }
}