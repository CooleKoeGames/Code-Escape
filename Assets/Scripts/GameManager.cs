using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] gameObjectsToDisable;

    public GameObject doorAnimation;
    public static bool doorIsOpen = false;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

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
            Debug.Log("door open");
            doorIsOpen = true;
            Timer.exited = true;
            audioManager.PlayDoorAudio(audioManager.door);
            doorAnimation.GetComponent<Animator>().Play("DoorOpen");
        }
    }
}