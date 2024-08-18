using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Minigame3_Controller : MonoBehaviour
{
    public static Minigame3_Controller Instance { get; private set; }
    private int correctDropsCount = 0;

    public GameObject UImenu;
    public void startGame()
    {
        UImenu.SetActive(false);
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Keep this instance persistent across scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances
        }
    }

    public void IncrementCorrectDrop()
    {
        correctDropsCount++;
        Debug.Log("Correct Drops: " + correctDropsCount);
        CheckWinCondition();
    }

    public void DecrementCorrectDrop()
    {
        if (correctDropsCount > 0)
        {
            correctDropsCount--;
            Debug.Log("Correct Drops: " + correctDropsCount);
        }
    }

    private void CheckWinCondition()
    {
        if (correctDropsCount >= 6)
        {
            Debug.Log("You win!");
            // Trigger win state here (e.g., load a new scene, show a win UI, etc.)
            OnWin();
        }
    }

    public RectTransform imageTransform; // Assign the RectTransform of the Image in the Inspector
    public float popDuration = 1.0f; // Duration of the pop-out effect
    public float holdDuration = 2.0f; // Duration to hold the image before changing the scene
    public float targetScale = 1.5f; // Target scale of the image
    public string sceneToLoad = "NextScene"; // Name of the scene to load

    private Vector3 originalScale;
    private void Start()
    {
        originalScale = imageTransform.localScale;
        imageTransform.localScale = Vector3.zero; 
    }

    private void OnWin()
    {
        
        Debug.Log("Congratulations! You've won the game!");
        StartCoroutine(PopAndChangeScene());
    }

    private IEnumerator PopAndChangeScene()
    {
        float elapsedTime = 0f;
        while (elapsedTime < popDuration)
        {
            imageTransform.localScale = Vector3.Lerp(Vector3.zero, originalScale, elapsedTime / popDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        imageTransform.localScale = originalScale; // Ensure it reaches the original scale

        // Hold the image at its original scale for a few seconds
        yield return new WaitForSeconds(holdDuration);

        // Change the scene
        SceneManager.LoadScene(sceneToLoad);
    }

    public int GetCorrectDropsCount()
    {
        return correctDropsCount;
    }
}
