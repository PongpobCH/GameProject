using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class THISISTHEVOICE : MonoBehaviour
{
    [Header("Oprion Menu")]
    [SerializeField] public GameObject optionmenu;

    [Header("Audio Settings")]
    [SerializeField] public AudioClip audioClip;
    private AudioSource audioSource;

    [Header("Volume Settings")]
    [Range(0f, 1f)]
    public float volume = 1f; // Default volume
    [SerializeField] private Slider volumeSlider; // Optional: Attach a UI slider for player control

    void Start()
    {
        optionmenu.SetActive(false);

        // Initialize audio source
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.volume = volume; // Set initial volume
        audioSource.Play();

        // Configure volume slider if present
        if (volumeSlider != null)
        {
            volumeSlider.value = volume;
            volumeSlider.onValueChanged.AddListener(AdjustVolume);
        }
    }

    // Method to adjust volume
    public void AdjustVolume(float newVolume)
    {
        volume = newVolume;
        audioSource.volume = volume;
    }

    public void openOption()
    {
        optionmenu.SetActive(true);
    }

    public void closeOption()
    {
        optionmenu.SetActive(false);
    }

    public void backtomenu()
    {
        GameManager2.Instance.RowData = 0;
        GameManager2.Instance.SavedRow();
        optionmenu.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }
}
