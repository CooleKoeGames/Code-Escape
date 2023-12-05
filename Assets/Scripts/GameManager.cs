using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] gameObjectsToDisable;

    public GameObject doorAnimation;
    private bool doorIsOpen = false;

    private void Start()
    {
        foreach (GameObject gameObject in gameObjectsToDisable)
        {
            gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (DoorOpen.bookInRightPlace == true && QuizManager.quizComplete == true && doorIsOpen == false)
        {
            doorIsOpen = true;
            doorAnimation.GetComponent<Animator>().Play("DoorOpen");
        }
    }
}