using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Scources")]
    [SerializeField] private AudioSource quizAudioScource;
    [SerializeField] private AudioSource doorAudioScource;

    [Header("Audio Clips")]
    public AudioClip correct;
    public AudioClip wrong;
    public AudioClip door;

    public void PlayQuizAudio(AudioClip clip)
    {
        quizAudioScource.PlayOneShot(clip);
    }

    public void PlayDoorAudio(AudioClip clip)
    {
        doorAudioScource.PlayOneShot(clip);
    }
}