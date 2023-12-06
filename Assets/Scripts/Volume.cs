using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider volumeSlider;

    public void SetVolume()
    {
        float volume = volumeSlider.value;
        audioMixer.SetFloat("Master Volume", Mathf.Log10(volume) * 20);
    }
}